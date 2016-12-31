using System;
using System.Windows.Forms;
using System.IO;

namespace Arkanoid_v2._0
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
            FileStream file1 = new FileStream(@"records.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            label.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"records.txt");
            textFile.WriteLine($"");
            textFile.Close();
            FileStream file1 = new FileStream(@"records.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            label.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
}
