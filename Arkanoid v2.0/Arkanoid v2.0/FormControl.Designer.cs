namespace Arkanoid_v2._0
{
    partial class FormControl
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
            this.label_pause = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_pause
            // 
            this.label_pause.BackColor = System.Drawing.Color.White;
            this.label_pause.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pause.Location = new System.Drawing.Point(12, 9);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(573, 200);
            this.label_pause.TabIndex = 11;
            this.label_pause.Text = "Pause - Space\r\nExit     - Escape(только во время остановки игры)\r\nСontrol racket " +
    "- keys left and right";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(495, 210);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(90, 30);
            this.button_exit.TabIndex = 12;
            this.button_exit.Text = "Ok";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(595, 252);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_pause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControl";
            this.Text = "FormControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_pause;
        private System.Windows.Forms.Button button_exit;
    }
}