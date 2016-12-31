namespace Arkanoid_v2._0
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_control = new System.Windows.Forms.Button();
            this.label_up = new System.Windows.Forms.Label();
            this.button_hard = new System.Windows.Forms.Button();
            this.button_medium = new System.Windows.Forms.Button();
            this.button_easy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_mouse = new System.Windows.Forms.Button();
            this.button_console = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_records = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(390, 104);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(120, 40);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(390, 192);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(120, 40);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_control
            // 
            this.button_control.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_control.Location = new System.Drawing.Point(68, 196);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(120, 40);
            this.button_control.TabIndex = 2;
            this.button_control.Text = "Сontrol";
            this.button_control.UseVisualStyleBackColor = true;
            this.button_control.Click += new System.EventHandler(this.button_control_Click);
            // 
            // label_up
            // 
            this.label_up.BackColor = System.Drawing.Color.White;
            this.label_up.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_up.Location = new System.Drawing.Point(12, 9);
            this.label_up.Name = "label_up";
            this.label_up.Size = new System.Drawing.Size(253, 46);
            this.label_up.TabIndex = 13;
            this.label_up.Text = "Выбирете сложность игры (easy по умолчанию):";
            // 
            // button_hard
            // 
            this.button_hard.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hard.Location = new System.Drawing.Point(68, 104);
            this.button_hard.Name = "button_hard";
            this.button_hard.Size = new System.Drawing.Size(120, 40);
            this.button_hard.TabIndex = 14;
            this.button_hard.Text = "hard";
            this.button_hard.UseVisualStyleBackColor = true;
            this.button_hard.Click += new System.EventHandler(this.button_hard_Click);
            // 
            // button_medium
            // 
            this.button_medium.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_medium.Location = new System.Drawing.Point(138, 58);
            this.button_medium.Name = "button_medium";
            this.button_medium.Size = new System.Drawing.Size(120, 40);
            this.button_medium.TabIndex = 15;
            this.button_medium.Text = "medium";
            this.button_medium.UseVisualStyleBackColor = true;
            this.button_medium.Click += new System.EventHandler(this.button_medium_Click);
            // 
            // button_easy
            // 
            this.button_easy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_easy.Location = new System.Drawing.Point(12, 58);
            this.button_easy.Name = "button_easy";
            this.button_easy.Size = new System.Drawing.Size(120, 40);
            this.button_easy.TabIndex = 16;
            this.button_easy.Text = "easy";
            this.button_easy.UseVisualStyleBackColor = true;
            this.button_easy.Click += new System.EventHandler(this.button_easy_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выбирете управление (console по умолчанию):";
            // 
            // button_mouse
            // 
            this.button_mouse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mouse.Location = new System.Drawing.Point(401, 58);
            this.button_mouse.Name = "button_mouse";
            this.button_mouse.Size = new System.Drawing.Size(120, 40);
            this.button_mouse.TabIndex = 18;
            this.button_mouse.Text = "mouse";
            this.button_mouse.UseVisualStyleBackColor = true;
            this.button_mouse.Click += new System.EventHandler(this.button_mouse_Click);
            // 
            // button_console
            // 
            this.button_console.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_console.Location = new System.Drawing.Point(275, 58);
            this.button_console.Name = "button_console";
            this.button_console.Size = new System.Drawing.Size(120, 40);
            this.button_console.TabIndex = 19;
            this.button_console.Text = "console";
            this.button_console.UseVisualStyleBackColor = true;
            this.button_console.Click += new System.EventHandler(this.button_console_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 46);
            this.label2.TabIndex = 20;
            this.label2.Text = "Инструкция по управлению через Console";
            // 
            // button_records
            // 
            this.button_records.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_records.Location = new System.Drawing.Point(390, 146);
            this.button_records.Name = "button_records";
            this.button_records.Size = new System.Drawing.Size(120, 40);
            this.button_records.TabIndex = 21;
            this.button_records.Text = "Records";
            this.button_records.UseVisualStyleBackColor = true;
            this.button_records.Click += new System.EventHandler(this.button_records_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(532, 244);
            this.Controls.Add(this.button_records);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_console);
            this.Controls.Add(this.button_mouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_easy);
            this.Controls.Add(this.button_medium);
            this.Controls.Add(this.button_hard);
            this.Controls.Add(this.label_up);
            this.Controls.Add(this.button_control);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Arkanoid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_control;
        private System.Windows.Forms.Label label_up;
        private System.Windows.Forms.Button button_hard;
        private System.Windows.Forms.Button button_medium;
        private System.Windows.Forms.Button button_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_mouse;
        private System.Windows.Forms.Button button_console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_records;
    }
}

