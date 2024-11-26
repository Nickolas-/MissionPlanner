using System;
using System.Windows.Forms;

namespace MissionPlanner.Utilities
{
    public partial class CustomModal : Form
    {
        public CustomModal()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            AcceptButton = button1;

            textBox1.Multiline = true;

            button1.Text = "OK";

        }
        
        public void SetText(string text)
        {
            textBox1.Text = text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}