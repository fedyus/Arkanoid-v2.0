using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Arkanoid_v2._0
{
    public partial class FormGame : Form
    {
        SoundPlayer sp, sp_2;
        int k_brick = 0;
        int racket_x, racket_y;
        int ball_x, ball_y;
        int racket_shift_x = 20;
        int ball_shift_x, ball_shift_y;
        int ball_sx, ball_sy ;
        int point, life, lvl;
        bool cont;

        List<Label> array = new List<Label>();
        private Label block0 = new Label();
        private Label block1 = new Label();
        private Label block2 = new Label();
        private Label block3 = new Label();
        private Label block4 = new Label();
        private Label block5 = new Label();
        private Label block6 = new Label();
        private Label block7 = new Label();
        private Label block8 = new Label();
        private Label block9 = new Label();
        private Label block10 = new Label();
        private Label block11 = new Label();
        private Label block12 = new Label();
        private Label block13 = new Label();
        private Label block14 = new Label();
        private Label block15 = new Label();
        private Label block16 = new Label();
        private Label block17 = new Label();
        private Label block18 = new Label();
        private Label block19 = new Label();   
        private Label block20 = new Label();

        public FormGame(int x, int y,int l,int s_1,int s_2, bool con)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            point = x;
            label_point.Text = point.ToString();
            life = y;
            if (life < 3)
            {
                life_1.Visible = false;
                if (life < 2)
                {
                    life_2.Visible = false;
                    if (life < 1)
                        life_3.Visible = false;
                }
            }
            ball_shift_x = s_1;
            ball_shift_y = s_2;
            ball_sx = s_1;
            ball_sy = s_2;
            lvl = l + 1;
            cont = con;
            Cursor.Hide();
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            sp = new SoundPlayer();
            sp.Stream = Properties.Resources.Ark_die_2;

            sp_2 = new SoundPlayer();
            sp_2.Stream = Properties.Resources.Ark_Game_Over_Music_2;
         
            array.Add(block0);
            array.Add(block1);
            array.Add(block2);
            array.Add(block3);
            array.Add(block4);
            array.Add(block5);
            array.Add(block6);
            array.Add(block7);
            array.Add(block8);
            array.Add(block9);
            array.Add(block10);
            array.Add(block11);
            array.Add(block12);
            array.Add(block13);
            array.Add(block14);
            array.Add(block15);
            array.Add(block16);
            array.Add(block17);
            array.Add(block18);
            array.Add(block19);
            array.Add(block20);

            Random r = new Random();
            foreach (Label tBlock in array)
            {
                tBlock.AutoSize = false;
                Controls.Add(tBlock);
                tBlock.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                tBlock.Location = new Point(r.Next(40, 1250), r.Next(50, 500));
                tBlock.Name = "block";
                tBlock.Size = new Size(90, 30);
                tBlock.TabIndex = 21;
            }
        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            init_game();
        }

        private void init_game()
        {
            racket_x = racket.Location.X;
            racket_y = racket.Location.Y;
            ball_x = ball.Location.X;
            ball_y = ball.Location.Y;
            timer.Enabled = true;
            label_pause.Visible = false;
            label_gameover.Visible = false;
            label_up.Visible = false;
            button_cx.Visible = false;
            button_exit.Visible = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (button_exit.Visible == true)
            {
                this.Close();
            }
        }

        private void button_cx_Click(object sender, EventArgs e)
        {
           if( button_cx.Visible ==true)
            {                
                Form_cx game = new Form_cx(point);
                game.ShowDialog();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            move_ball();
            Random r = new Random();
            if (cont == false)
                racket.Left = Cursor.Position.X - (racket.Width / 2);
            if (cont == false)
            {
                if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom &&
                    ball.Left >= racket.Left && ball.Right <= racket.Right)
                {
                    ball_sy = -ball_shift_y + r.Next(-1, 2);
                    point += 1;
                    label_point.Text = point.ToString();
                    sp.Play();
                }

                if (ball.Top > racket.Top)
                {
                    lose_ball();
                }
            }
        }

        private void move_ball()
        {
            Random r = new Random();
            if (ball_x + ball_sx < label_left.Location.X + label_left.Width)
            {
                ball_sx = ball_shift_x;
                sp.Play();
                point += 1;
                label_point.Text = point.ToString();
            }

            if (ball_x + ball_sx + ball.Width > label_right.Location.X)
            {
                ball_sx = -ball_shift_x;
                sp.Play();
                point += 1;
                label_point.Text = point.ToString();
            }

            if (ball_y + ball_sy < label_top.Location.Y + label_top.Height)
            {
                ball_sy = ball_shift_y;
                sp.Play();
                point += 1;
                label_point.Text = point.ToString();
            }

            if (ball_y + ball.Height + ball_sy > racket_y && cont == true) 
            {
                int bx, by;
                bx = ball_x + ball.Width / 2;
                by = ball_y + ball.Height / 2;
                if (racket_x <= bx && bx <= racket_x + racket.Width)
                {
                    ball_sy = -ball_shift_y + r.Next(-1, 2);
                    sp.Play();
                    point += 1;
                    label_point.Text = point.ToString();
                }
                else
                if (racket_x <= ball_x + ball.Width && ball_x + ball.Width <= racket_x + racket.Width)
                {
                    ball_sy = -ball_shift_y + r.Next(-1, 2);
                    ball_sx = -ball_shift_x + r.Next(-1, 2);
                    sp.Play();
                    point += 1;
                    label_point.Text = point.ToString();
                }
                else
                    if (racket_x <= ball_x && ball_x <= racket_x + racket.Width)
                {
                    ball_sy = -ball_shift_y + r.Next(-1, 2);
                    ball_sx = ball_shift_x + r.Next(-1, 2);
                    sp.Play();
                    point += 1;
                    label_point.Text = point.ToString();
                }
                else lose_ball();
            }

            ball_x += ball_sx;
            ball_y += ball_sy;
            ball.Location = new Point(ball_x, ball_y);
            foreach (Label tBlock in array)
            {
                cross_brick(tBlock);
            }
        }

        private void cross_brick(Label brick)
        {
            if (!brick.Visible) return;

            int bx1, bx0, bx2,
                by1, by0, by2;
            int rx1, rx2,
                ry1, ry2;

            bx1 = ball_x;
            bx2 = ball_x + ball.Width;
            bx0 = (bx1 + bx2) / 2;
            by1 = ball_y;
            by2 = ball_y + ball.Height;
            by0 = (by1 + by2) / 2;
            rx1 = brick.Location.X;
            rx2 = rx1 + brick.Width;
            ry1 = brick.Location.Y;
            ry2 = ry1 + brick.Height;

            if (rx1 <= bx0 && bx0 <= rx2 &&
                ry1 <= by2 && by2 <= ry2)
            {
                drop_brick(brick);
                ball_sy = -ball_sy;
                return;
            }
            if (rx1 <= bx2 && bx2 <= rx2 &&
                ry1 <= by0 && by0 <= ry2)
            {
                drop_brick(brick);
                ball_sy = -ball_sy;
                return;
            }
            if (rx1 <= bx1 && bx1 <= rx2 &&
                ry1 <= by0 && by0 <= ry2)
            {
                drop_brick(brick);
                ball_sx = -ball_sx;
                return;
            }
        }

        private void drop_brick(Label brick)
        {
            brick.Visible = false;
            point += 10;
            label_point.Text = point.ToString();
            sp.Play();
            k_brick++;
            if (k_brick == 21)
            {
                timer.Enabled = false;
                label_up.Visible = true; 
            }
        }

        private void lose_ball()
        {
            if (life > 0)
            {
                life--;
                ball_y = 200;
                if (life == 2)
                    life_1.Visible = false;
                if (life == 1)
                    life_2.Visible = false;
                if (life == 0)
                    life_3.Visible = false;
                ball.Location = new Point(ball_x, ball_y);
            }
            else
            {
                timer.Enabled = false;
                label_gameover.Visible = true;
                button_cx.Visible = true;
                button_exit.Visible = true;
                Cursor.Show();
                sp_2.Play();
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Left:
                    shift_racket(-racket_shift_x);
                    break;
                case Keys.Right:
                    shift_racket(racket_shift_x);
                    break;
                case Keys.Escape:
                    {
                        if (timer.Enabled == false)
                        {
                            this.Close();
                            Cursor.Show();
                        }
                    }
                    break;
                case Keys.Enter:
                    {
                        if (k_brick == 21)
                        {
                            this.Close();
                            FormGame game = new FormGame(point, life, lvl, ball_shift_x, ball_shift_y,cont );
                            game.ShowDialog();
                        }
                    }
                    break;
                case Keys.Space:
                    {
                        if (life > 0)
                        {
                            timer.Enabled = !timer.Enabled;
                            label_pause.Visible = !label_pause.Visible;
                        }
                    }
                    break;
            }
        }

        private void shift_racket(int x)
        {
            if (cont == true)
            {
                racket_x += x;
                if (racket_x < label_left.Location.X + label_left.Width) racket_x = label_left.Location.X + label_left.Width;
                if (racket_x + racket.Width > label_right.Location.X) racket_x = label_right.Location.X - racket.Width;
                racket.Location = new Point(racket_x, racket_y);
            }
        }
    }
}
