using DotSpatial.Data;
using SIGINT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class PolygonInfo : Form
    {
        private WeakReference<SigintService> _sigintService;

        public PolygonInfo(Data data, SigintService service)
        {
            TargetId = data.TargetId;
            InitializeComponent();
            SetData(data);
            _sigintService = new WeakReference<SigintService>(service);
        }

        public long TargetId { get; }

        private void SetData(Data data)
        {
            groupBox.Text = $"Target Id {data.TargetId}";
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

        private async void OnGetTargetImageClicked(object sender, EventArgs e)
        {
            if (!_sigintService.TryGetTarget(out var service))
                return;

            var imageData = await service.GetTargetImageAsync(TargetId);

            if (imageData == null)
                return;

            ShowImageForm(imageData);
        }

        private async void OnGetFDClicked(object sender, EventArgs e)
        {
            if (!_sigintService.TryGetTarget(out var service))
                return;

            var imageData = await service.GetFrequencyDomainSignatureImageAsync(TargetId);

            if (imageData == null)
                return;

            ShowImageForm(imageData);
        }

        private async void OnGetTDClicked(object sender, EventArgs e)
        {
            if (!_sigintService.TryGetTarget(out var service))
                return;

            var imageData = await service.GetTimeDomainSignatureImageAsync(TargetId);

            if (imageData == null)
                return;

            ShowImageForm(imageData);
        }

        private void labelLatValue_Click(object sender, EventArgs e)
        {
            string value = ((Label)sender).Text;

            if (string.IsNullOrWhiteSpace(value))
                return;

            try
            {
                System.Windows.Forms.Clipboard.SetText(value);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void ShowImageForm(Stream imageData)
        {
            if (imageData == null)
                return;

            var image = Image.FromStream(imageData);

            Form form = new Form();
            form.AutoSize = true;
            form.StartPosition = FormStartPosition.CenterParent;
            MissionPlanner.Utilities.ThemeManager.ApplyThemeTo(form);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            form.Controls.Add(pictureBox);
            pictureBox.Image = image;
            pictureBox.Location = new Point(
                (pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2),
                (pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2));
            pictureBox.Refresh();
            form.Size = pictureBox.Size;
            form.ShowDialog();
        }

        private Image BytesToImage(byte[] sourceData)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(sourceData, 0, Convert.ToInt32(sourceData.Length));
            var image = Image.FromStream(stream);
            stream.Dispose();
            return image;
        }
    }
}
