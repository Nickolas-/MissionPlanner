using SIGINT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class PolygonInfo : Form
    {

        public PolygonInfo(Data data)
        {
            InitializeComponent();
            SetData(data);
        }

        private void SetData(Data data)
        {
            labelNumPtValue.Text = data.NumPt.ToString();
            labelFreqValue.Text = data.Freq.ToString();
            labelMagValue.Text = data.Mag.ToString();
            labelLatValue.Text = $"{data.CenterLat}, {data.CenterLong}";
            labelWidthValue.Text = data.Width.ToString();
            labelBeamValue.Text = data.Beam.ToString();
            labelSdXValue.Text = data.SdX.ToString();
            labelSdYValue.Text = data.SdY.ToString();
            labelSdAvgValue.Text = data.SdAvg.ToString();
            labelRmseValue.Text = data.Rmse.ToString();
            labelAreaValue.Text = data.Area.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
