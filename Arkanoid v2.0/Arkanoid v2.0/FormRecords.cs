using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
