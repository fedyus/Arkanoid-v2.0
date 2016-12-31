using System;
using System.Windows.Forms;

namespace Arkanoid_v2._0
{
    public partial class Form_cx : Form
    {
        int point;
        public Form_cx(int x)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            point = x;
            label_point.Text = point.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"records.txt",true);
            textFile.WriteLine($" Player  {text.Text} scored : { point} point ");
            textFile.Close();
            this.Close();
        }
    }
}
