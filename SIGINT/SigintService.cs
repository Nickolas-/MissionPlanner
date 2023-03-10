using ExifLibrary;
using MissionPlanner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static MAVLink;

namespace SIGINT
{
    public class SigintService
    {
        private const int ProtocolVersion = 1;
        private SimpleTimer _timer;
        private readonly HttpClient _httpClient = new HttpClient() { BaseAddress = new Uri("http://sigint.bavovna.ai/") };
        private readonly MAVLinkInterface _mAV;

        public event EventHandler<List<SessionData>> OnSessionData;
        public event EventHandler<string> OnError;

        public SigintService(MAVLinkInterface mAV)
        {
            this._mAV = mAV;
        }

        public int CurrentUnixTime => (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        public long? SessionId { get; private set; }

        public Task<Stream> GetTimeDomainSignatureImageAsync(long targetId)
        {
            return InnerGetImageAsync("get-pattern-td", targetId);
        }

        public Task<Stream> GetFrequencyDomainSignatureImageAsync(long targetId)
        {
            return InnerGetImageAsync("get-pattern-fd", targetId);
        }

        public Task<Stream> GetTargetImageAsync(long targetId)
        {
            return InnerGetImageAsync("get-image", targetId);
        }

        private async Task<Stream> InnerGetImageAsync(string endpoint, long targetId)
        {
            if (SessionId == null)
                await GetActiveSessionAsync();

            if (SessionId == null || SessionId == 0 || targetId == 0)
                return null;

            var response = await _httpClient.PostAsJsonAsync(endpoint, new
            {
                session_id = SessionId,
                target_id = targetId,
                timestamp = CurrentUnixTime,
                protocol_v = ProtocolVersion
            });

            if (response.StatusCode != System.Net.HttpStatusCode.OK || 
                response.Content == null ||
                response.Content.Headers.ContentLength < 10)
                return null;

            var imageData = await response.Content.ReadAsStreamAsync();
            return imageData;
        }

        public void StartFetchingData()
        {
            _timer = new SimpleTimer(CheckPeriodicData, TimeSpan.FromSeconds(5));
        }

        private async void CheckPeriodicData()
        {
            try
            {
                SessionId = null;

                var session = await GetActiveSessionAsync();

                if (session is null || session.SessionId == 0)
                    return;

                var sessionTargets = await GetSessionTargetsAsync(session);

                if (sessionTargets == null || sessionTargets.Targets == null)
                    return;

                var toReturn = new List<SessionData>();
                foreach (var item in sessionTargets.Targets)
                {
                    var data = await GetSessionDataAsync(session, item);
                    toReturn.Add(data);
                }

                if (!toReturn.Any())
                    return;

                OnSessionData?.Invoke(this, toReturn);
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this, ex.Message);
                _timer.Dispose();
            }
        }

        private string GetUavId()
        {
            var serialString = _mAV.MAVlist[_mAV.sysidcurrent, _mAV.compidcurrent].SerialString;
            return serialString;
        }

        private async Task<Session> GetActiveSessionAsync()
        {
            var uavId = GetUavId();

            if (string.IsNullOrEmpty(uavId))
                return null;

            var response = await _httpClient.PostAsJsonAsync("get-active-session", new
            {
                uav_id = uavId,
                timestamp = CurrentUnixTime,
                protocol_v = ProtocolVersion
            });

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var jsonString = await response.Content.ReadAsStringAsync();
            var session = JsonConvert.DeserializeObject<Session>(jsonString);

            if (session == null || session.SessionId == 0)
                return null;

            SessionId = session.SessionId;
            return session;
        }

        private async Task<SessionTargets> GetSessionTargetsAsync(Session session)
        {
            var response = await _httpClient.PostAsJsonAsync("get-targets", new
            {
                session_id = session.SessionId,
                timestamp = CurrentUnixTime,
                protocol_v = ProtocolVersion
            });

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SessionTargets>(jsonString);
        }

        private async Task<SessionData> GetSessionDataAsync(Session session, Target item)
        {
            var response = await _httpClient.PostAsJsonAsync("get-data", new
            {
                session_id = session.SessionId,
                target_id = item.TargetId,
                timestamp = CurrentUnixTime,
                protocol_v = ProtocolVersion
            });

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SessionData>(jsonString);
        }

    }

    public class Session
    {
        [JsonProperty("session_id")]
        public long SessionId { get; set; }
        [JsonProperty("state")]
        public int State { get; set; }
    }

    public class Sessions
    {
        [JsonProperty("data")]
        public List<Session> Data { get; set; }
    }

    public class SessionTargets
    {
        [JsonProperty("session_id")]
        public long SessionId { get; set; }
        [JsonProperty("state")]
        public int State { get; set; }
        [JsonProperty("targets")]
        public List<Target> Targets { get; set; }
    }

    public class Target
    {
        [JsonProperty("target_id")]
        public long TargetId { get; set; }
    }

    public class SessionData
    {
        [JsonProperty("session_id")]
        public long SessionId { get; set; }
        [JsonProperty("state")]
        public int State { get; set; }
        [JsonProperty("data")]
        public List<Data> Data { get; set; } = new List<Data>();
    }

    public class Data
    {
        [JsonProperty("target_id")]
        public long TargetId { get; set; }
        [JsonProperty("num_pt")]
        public long NumPt { get; set; }
        [JsonProperty("data_pt")]
        public List<SigintPoint> Points { get; set; }
        [JsonProperty("freq")]
        public long Freq { get; set; }
        [JsonProperty("mag")]
        public long Mag { get; set; }
        [JsonProperty("wgs_long")]
        public double CenterLong { get; set; }
        [JsonProperty("wgs_lat")]
        public double CenterLat { get; set; }
        [JsonProperty("width")]
        public double Width { get; set; }
        [JsonProperty("beam")]
        public double Beam { get; set; }
        [JsonProperty("sd_x")]
        public long SdX { get; set; }
        [JsonProperty("sd_y")]
        public long SdY { get; set; }
        [JsonProperty("sd_avg")]
        public long SdAvg { get; set; }
        [JsonProperty("rmse")]
        public long Rmse { get; set; }
        [JsonProperty("area")]
        public long Area { get; set; }
    }

    public class SigintPoint
    {
        [JsonProperty("pt_id")]
        public int Id { get; set; }
        [JsonProperty("pt_long")]
        public double Longitude { get; set; }
        [JsonProperty("pt_lat")]
        public double Latitude { get; set; }

    }

    public class GeoArea
    {
        public List<SigintPoint> Points { get; private set; }
        public SigintPoint Center { get; private set; }
        public double RadiusX { get; private set; }
        public double RadiusY { get; private set; }

        public GeoArea(List<SigintPoint> points)
        {
            Points = points;
            CalculateCenterAndRadius();
        }


        private void CalculateCenterAndRadius()
        {
            // Find the latitude and longitude boundaries of the area
            double minLatitude = double.MaxValue;
            double maxLatitude = double.MinValue;
            double minLongitude = double.MaxValue;
            double maxLongitude = double.MinValue;
            foreach (var point in Points)
            {
                if (point.Latitude < minLatitude) minLatitude = point.Latitude;
                if (point.Latitude > maxLatitude) maxLatitude = point.Latitude;
                if (point.Longitude < minLongitude) minLongitude = point.Longitude;
                if (point.Longitude > maxLongitude) maxLongitude = point.Longitude;
            }

            // Calculate the center of the area
            double centerLatitude = (minLatitude + maxLatitude) / 2.0;
            double centerLongitude = (minLongitude + maxLongitude) / 2.0;
            Center = new SigintPoint { Latitude = centerLatitude, Longitude = centerLongitude };

            // Calculate the radii
            double latDist = GetDistance(centerLatitude, minLongitude, centerLatitude, maxLongitude);
            double lonDist = GetDistance(minLatitude, centerLongitude, maxLatitude, centerLongitude);
            RadiusX = lonDist / 2.0;
            RadiusY = latDist / 2.0;
        }

        private double GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Calculate the distance between two points using the Haversine formula
            // (https://en.wikipedia.org/wiki/Haversine_formula)
            double earthRadius = 6371000.0; // meters
            double deltaLat = ToRadians(lat2 - lat1);
            double deltaLon = ToRadians(lon2 - lon1);
            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) + Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) * Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = earthRadius * c;
            return distance;
        }

        private double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }
}
