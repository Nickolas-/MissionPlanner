using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using SIGINT;

namespace MissionPlanner.Controls
{
    public class GMapMarkerDataSigint : GMarkerGoogle
    {
        public Data Data { get; set; }
        
      

        public GMapMarkerDataSigint(PointLatLng p, GMarkerGoogleType type) : base(p, type)
        {
        }

        public GMapMarkerDataSigint(PointLatLng p, Bitmap Bitmap) : base(p, Bitmap)
        {
        }

        protected GMapMarkerDataSigint(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    
    
}