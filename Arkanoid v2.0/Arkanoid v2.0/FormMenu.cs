using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Arkanoid_v2._0
{
    public partial class FormMenu : Form
    {
        SoundPlayer sp_1, sp_3;
        int point = 0, life = 3 , lvl = 0;
        int ball_shift_x = 7, ball_shift_y = 5;
        bool cont = true;

        public FormMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;           

            sp_1 = new SoundPlayer();
            sp_1.Stream = Properties.Resources.Track_1;

            sp_3 = new SoundPlayer();
            sp_3.Stream = Properties.Resources.Ark_Enter;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame(point, life, lvl, ball_shift_x, ball_shift_y, cont );
            game.ShowDialog();           
        }

        private void button_easy_Click(object sender, EventArgs e)
        {
            ball_shift_x = 7;
            ball_shift_y = 5;
            sp_3.Play();
        }

        private void button_medium_Click(object sender, EventArgs e)
        {
            ball_shift_x = 13;
            ball_shift_y = 10;
            sp_3.Play();
        }

        private void button_console_Click(object sender, EventArgs e)
        {
            cont = true;
            sp_3.Play();
        }

        private void button_records_Click(object sender, EventArgs e)
        {
            FormRecords game = new FormRecords();
            game.ShowDialog();
        }

        private void button_mouse_Click(object sender, EventArgs e)
        {
            cont = false;
            sp_3.Play();
        }

        private void button_hard_Click(object sender, EventArgs e)
        {
            ball_shift_x = 17;
            ball_shift_y = 15;
            sp_3.Play();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_control_Click(object sender, EventArgs e)
        {
            FormControl game = new FormControl();
            game.ShowDialog();
            sp_3.Play();
        }
    }
}
