namespace Timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.WallLabelHours = new System.Windows.Forms.Label();
            this.WallLabelMinutes = new System.Windows.Forms.Label();
            this.WallLabelSeconds = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.PlusHoursButton = new System.Windows.Forms.Button();
            this.PlusSecondsButton = new System.Windows.Forms.Button();
            this.MinusHoursButton = new System.Windows.Forms.Button();
            this.MinusMinutesButton = new System.Windows.Forms.Button();
            this.PlusMinutesButton = new System.Windows.Forms.Button();
            this.MinusSecondsButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursLabel.Location = new System.Drawing.Point(12, 9);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(98, 108);
            this.HoursLabel.TabIndex = 1;
            this.HoursLabel.Text = "0";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesLabel.Location = new System.Drawing.Point(173, 9);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(98, 108);
            this.MinutesLabel.TabIndex = 2;
            this.MinutesLabel.Text = "0";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLabel.Location = new System.Drawing.Point(342, 9);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(98, 108);
            this.SecondsLabel.TabIndex = 3;
            this.SecondsLabel.Text = "0";
            // 
            // WallLabelHours
            // 
            this.WallLabelHours.AutoSize = true;
            this.WallLabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WallLabelHours.Location = new System.Drawing.Point(44, 117);
            this.WallLabelHours.Name = "WallLabelHours";
            this.WallLabelHours.Size = new System.Drawing.Size(29, 25);
            this.WallLabelHours.TabIndex = 4;
            this.WallLabelHours.Text = "ч.";
            // 
            // WallLabelMinutes
            // 
            this.WallLabelMinutes.AutoSize = true;
            this.WallLabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WallLabelMinutes.Location = new System.Drawing.Point(186, 117);
            this.WallLabelMinutes.Name = "WallLabelMinutes";
            this.WallLabelMinutes.Size = new System.Drawing.Size(57, 25);
            this.WallLabelMinutes.TabIndex = 5;
            this.WallLabelMinutes.Text = "мин.";
            // 
            // WallLabelSeconds
            // 
            this.WallLabelSeconds.AutoSize = true;
            this.WallLabelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WallLabelSeconds.Location = new System.Drawing.Point(372, 117);
            this.WallLabelSeconds.Name = "WallLabelSeconds";
            this.WallLabelSeconds.Size = new System.Drawing.Size(29, 25);
            this.WallLabelSeconds.TabIndex = 6;
            this.WallLabelSeconds.Text = "с.";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(12, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(259, 52);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(280, 157);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(242, 52);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PlusHoursButton
            // 
            this.PlusHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusHoursButton.Location = new System.Drawing.Point(140, 25);
            this.PlusHoursButton.Name = "PlusHoursButton";
            this.PlusHoursButton.Size = new System.Drawing.Size(43, 44);
            this.PlusHoursButton.TabIndex = 9;
            this.PlusHoursButton.Text = "+";
            this.PlusHoursButton.UseVisualStyleBackColor = true;
            this.PlusHoursButton.Click += new System.EventHandler(this.PlusHoursButton_Click);
            // 
            // PlusSecondsButton
            // 
            this.PlusSecondsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusSecondsButton.Location = new System.Drawing.Point(476, 25);
            this.PlusSecondsButton.Name = "PlusSecondsButton";
            this.PlusSecondsButton.Size = new System.Drawing.Size(43, 44);
            this.PlusSecondsButton.TabIndex = 10;
            this.PlusSecondsButton.Text = "+";
            this.PlusSecondsButton.UseVisualStyleBackColor = true;
            this.PlusSecondsButton.Click += new System.EventHandler(this.PlusSecondsButton_Click);
            // 
            // MinusHoursButton
            // 
            this.MinusHoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusHoursButton.Location = new System.Drawing.Point(140, 73);
            this.MinusHoursButton.Name = "MinusHoursButton";
            this.MinusHoursButton.Size = new System.Drawing.Size(43, 44);
            this.MinusHoursButton.TabIndex = 11;
            this.MinusHoursButton.Text = "-";
            this.MinusHoursButton.UseVisualStyleBackColor = true;
            this.MinusHoursButton.Click += new System.EventHandler(this.MinusHoursButton_Click);
            // 
            // MinusMinutesButton
            // 
            this.MinusMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusMinutesButton.Location = new System.Drawing.Point(307, 73);
            this.MinusMinutesButton.Name = "MinusMinutesButton";
            this.MinusMinutesButton.Size = new System.Drawing.Size(43, 44);
            this.MinusMinutesButton.TabIndex = 12;
            this.MinusMinutesButton.Text = "-";
            this.MinusMinutesButton.UseVisualStyleBackColor = true;
            this.MinusMinutesButton.Click += new System.EventHandler(this.MinusMinutesButton_Click);
            // 
            // PlusMinutesButton
            // 
            this.PlusMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusMinutesButton.Location = new System.Drawing.Point(307, 25);
            this.PlusMinutesButton.Name = "PlusMinutesButton";
            this.PlusMinutesButton.Size = new System.Drawing.Size(43, 44);
            this.PlusMinutesButton.TabIndex = 13;
            this.PlusMinutesButton.Text = "+";
            this.PlusMinutesButton.UseVisualStyleBackColor = true;
            this.PlusMinutesButton.Click += new System.EventHandler(this.PlusMinutesButton_Click);
            // 
            // MinusSecondsButton
            // 
            this.MinusSecondsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusSecondsButton.Location = new System.Drawing.Point(476, 73);
            this.MinusSecondsButton.Name = "MinusSecondsButton";
            this.MinusSecondsButton.Size = new System.Drawing.Size(43, 44);
            this.MinusSecondsButton.TabIndex = 14;
            this.MinusSecondsButton.Text = "-";
            this.MinusSecondsButton.UseVisualStyleBackColor = true;
            this.MinusSecondsButton.Click += new System.EventHandler(this.MinusSecondsButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 218);
            this.Controls.Add(this.MinusSecondsButton);
            this.Controls.Add(this.PlusMinutesButton);
            this.Controls.Add(this.MinusMinutesButton);
            this.Controls.Add(this.MinusHoursButton);
            this.Controls.Add(this.PlusSecondsButton);
            this.Controls.Add(this.PlusHoursButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.WallLabelSeconds);
            this.Controls.Add(this.WallLabelMinutes);
            this.Controls.Add(this.WallLabelHours);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label WallLabelHours;
        private System.Windows.Forms.Label WallLabelMinutes;
        private System.Windows.Forms.Label WallLabelSeconds;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PlusHoursButton;
        private System.Windows.Forms.Button PlusSecondsButton;
        private System.Windows.Forms.Button MinusHoursButton;
        private System.Windows.Forms.Button MinusMinutesButton;
        private System.Windows.Forms.Button PlusMinutesButton;
        private System.Windows.Forms.Button MinusSecondsButton;
        private System.Windows.Forms.Timer Timer;
    }
}

