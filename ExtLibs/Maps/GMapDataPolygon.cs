
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Collections.Generic;

namespace MissionPlanner.Maps
{

    public class GMapDataPolygon : GMapPolygon
    {
        public GMapDataPolygon(List<PointLatLng> points, string name) : base(points, name)
        {
        }

        public object Data { get; set; }
    }
}