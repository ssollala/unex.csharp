namespace StopwatchTimer
{
    partial class fmDigitalClock
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
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinuites = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblColon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPmAm = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(51, 105);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(185, 135);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "00";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinuites
            // 
            this.lblMinuites.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuites.Location = new System.Drawing.Point(303, 105);
            this.lblMinuites.Name = "lblMinuites";
            this.lblMinuites.Size = new System.Drawing.Size(185, 135);
            this.lblMinuites.TabIndex = 1;
            this.lblMinuites.Text = "00";
            this.lblMinuites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(552, 105);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(185, 135);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon.Location = new System.Drawing.Point(233, 133);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(52, 76);
            this.lblColon.TabIndex = 6;
            this.lblColon.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // lblPmAm
            // 
            this.lblPmAm.AutoSize = true;
            this.lblPmAm.Location = new System.Drawing.Point(727, 190);
            this.lblPmAm.Name = "lblPmAm";
            this.lblPmAm.Size = new System.Drawing.Size(82, 25);
            this.lblPmAm.TabIndex = 8;
            this.lblPmAm.Text = "PM/AM";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(274, 26);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(251, 46);
            this.lblTable.TabIndex = 9;
            this.lblTable.Text = "Current Time";
            // 
            // fmDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 297);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblPmAm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinuites);
            this.Controls.Add(this.lblHours);
            this.Name = "fmDigitalClock";
            this.Text = "DigitalClock";
            this.Load += new System.EventHandler(this.fmDigitalClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinuites;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPmAm;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTable;
    }
}

