namespace PlayGround
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.c1QRCode1 = new C1.Win.C1BarCode.C1QRCode();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // c1QRCode1
            // 
            this.c1QRCode1.Location = new System.Drawing.Point(310, 216);
            this.c1QRCode1.Name = "c1QRCode1";
            this.c1QRCode1.Size = new System.Drawing.Size(75, 64);
            this.c1QRCode1.TabIndex = 2;
            this.c1QRCode1.Text = "c1QRCode1";
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.c1Calendar1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-PH");
            this.c1Calendar1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Calendar1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.c1Calendar1.Location = new System.Drawing.Point(12, 12);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Size = new System.Drawing.Size(187, 144);
            this.c1Calendar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 387);
            this.Controls.Add(this.c1Calendar1);
            this.Controls.Add(this.c1QRCode1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private C1.Win.C1BarCode.C1QRCode c1QRCode1;
        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
    }
}

