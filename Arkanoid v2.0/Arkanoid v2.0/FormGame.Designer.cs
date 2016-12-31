namespace Arkanoid_v2._0
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.label_top = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.RadioButton();
            this.racket = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_point = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_pause = new System.Windows.Forms.Label();
            this.label_gameover = new System.Windows.Forms.Label();
            this.label_up = new System.Windows.Forms.Label();
            this.life_2 = new System.Windows.Forms.Label();
            this.life_1 = new System.Windows.Forms.Label();
            this.life_3 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Label();
            this.button_cx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_top
            // 
            this.label_top.BackColor = System.Drawing.Color.White;
            this.label_top.Location = new System.Drawing.Point(0, 0);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(1366, 40);
            this.label_top.TabIndex = 0;
            // 
            // label_left
            // 
            this.label_left.BackColor = System.Drawing.Color.White;
            this.label_left.Location = new System.Drawing.Point(0, 0);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(10, 768);
            this.label_left.TabIndex = 1;
            // 
            // label_right
            // 
            this.label_right.BackColor = System.Drawing.Color.White;
            this.label_right.Location = new System.Drawing.Point(1356, 0);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(10, 768);
            this.label_right.TabIndex = 2;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(474, 583);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 3;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // racket
            // 
            this.racket.Enabled = false;
            this.racket.Location = new System.Drawing.Point(560, 733);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(140, 20);
            this.racket.TabIndex = 4;
            this.racket.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(16, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 23);
            this.label.TabIndex = 5;
            this.label.Text = "Point : ";
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.BackColor = System.Drawing.Color.White;
            this.label_point.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_point.Location = new System.Drawing.Point(101, 9);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(22, 23);
            this.label_point.TabIndex = 6;
            this.label_point.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 35;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_pause
            // 
            this.label_pause.BackColor = System.Drawing.Color.White;
            this.label_pause.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pause.Location = new System.Drawing.Point(500, 300);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(400, 200);
            this.label_pause.TabIndex = 10;
            this.label_pause.Text = "\r\n        Pause";
            // 
            // label_gameover
            // 
            this.label_gameover.BackColor = System.Drawing.Color.White;
            this.label_gameover.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gameover.Location = new System.Drawing.Point(500, 300);
            this.label_gameover.Name = "label_gameover";
            this.label_gameover.Size = new System.Drawing.Size(400, 200);
            this.label_gameover.TabIndex = 11;
            this.label_gameover.Text = "\r\n   Game Over";
            // 
            // label_up
            // 
            this.label_up.BackColor = System.Drawing.Color.White;
            this.label_up.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_up.Location = new System.Drawing.Point(500, 300);
            this.label_up.Name = "label_up";
            this.label_up.Size = new System.Drawing.Size(400, 128);
            this.label_up.TabIndex = 12;
            this.label_up.Text = "     Level up\r\n   (click Enter)";
            // 
            // life_2
            // 
            this.life_2.Image = global::Arkanoid_v2._0.Properties.Resources._104_1_1_design_sm__1__30x35;
            this.life_2.Location = new System.Drawing.Point(1288, 2);
            this.life_2.Name = "life_2";
            this.life_2.Size = new System.Drawing.Size(30, 30);
            this.life_2.TabIndex = 9;
            // 
            // life_1
            // 
            this.life_1.Image = global::Arkanoid_v2._0.Properties.Resources._104_1_1_design_sm__1__30x35;
            this.life_1.Location = new System.Drawing.Point(1252, 2);
            this.life_1.Name = "life_1";
            this.life_1.Size = new System.Drawing.Size(30, 30);
            this.life_1.TabIndex = 8;
            // 
            // life_3
            // 
            this.life_3.Image = global::Arkanoid_v2._0.Properties.Resources._104_1_1_design_sm__1__30x35;
            this.life_3.Location = new System.Drawing.Point(1324, 2);
            this.life_3.Name = "life_3";
            this.life_3.Size = new System.Drawing.Size(30, 30);
            this.life_3.TabIndex = 7;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.Black;
            this.button_exit.Location = new System.Drawing.Point(706, 461);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(190, 29);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "            Exit";
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_cx
            // 
            this.button_cx.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_cx.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cx.ForeColor = System.Drawing.Color.Black;
            this.button_cx.Location = new System.Drawing.Point(510, 461);
            this.button_cx.Name = "button_cx";
            this.button_cx.Size = new System.Drawing.Size(190, 29);
            this.button_cx.TabIndex = 16;
            this.button_cx.Text = "Сохранить результат";
            this.button_cx.Click += new System.EventHandler(this.button_cx_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button_cx);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_up);
            this.Controls.Add(this.label_gameover);
            this.Controls.Add(this.label_pause);
            this.Controls.Add(this.life_2);
            this.Controls.Add(this.life_1);
            this.Controls.Add(this.life_3);
            this.Controls.Add(this.label_point);
            this.Controls.Add(this.label);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Button racket;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.Label life_3;
        private System.Windows.Forms.Label life_1;
        private System.Windows.Forms.Label life_2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_pause;
        private System.Windows.Forms.Label label_gameover;
        private System.Windows.Forms.Label label_up;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label button_cx;
    }
}