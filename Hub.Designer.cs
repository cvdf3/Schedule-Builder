namespace Schedule_Builder
{
    partial class Hub
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
            this.btnEditPersonnel = new System.Windows.Forms.Button();
            this.btnEditTrucks = new System.Windows.Forms.Button();
            this.btnLeaveCalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditPersonnel
            // 
            this.btnEditPersonnel.Location = new System.Drawing.Point(101, 194);
            this.btnEditPersonnel.Name = "btnEditPersonnel";
            this.btnEditPersonnel.Size = new System.Drawing.Size(92, 40);
            this.btnEditPersonnel.TabIndex = 0;
            this.btnEditPersonnel.Text = "Edit Personnel";
            this.btnEditPersonnel.UseVisualStyleBackColor = true;
            this.btnEditPersonnel.Click += new System.EventHandler(this.btnEditPersonnel_Click);
            // 
            // btnEditTrucks
            // 
            this.btnEditTrucks.Location = new System.Drawing.Point(347, 194);
            this.btnEditTrucks.Name = "btnEditTrucks";
            this.btnEditTrucks.Size = new System.Drawing.Size(92, 40);
            this.btnEditTrucks.TabIndex = 1;
            this.btnEditTrucks.Text = "Edit Trucks";
            this.btnEditTrucks.UseVisualStyleBackColor = true;
            this.btnEditTrucks.Click += new System.EventHandler(this.btnEditTrucks_Click);
            // 
            // btnLeaveCalendar
            // 
            this.btnLeaveCalendar.Location = new System.Drawing.Point(566, 194);
            this.btnLeaveCalendar.Name = "btnLeaveCalendar";
            this.btnLeaveCalendar.Size = new System.Drawing.Size(92, 40);
            this.btnLeaveCalendar.TabIndex = 2;
            this.btnLeaveCalendar.Text = "Leave Calendar";
            this.btnLeaveCalendar.UseVisualStyleBackColor = true;
            this.btnLeaveCalendar.Click += new System.EventHandler(this.btnLeaveCalendar_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeaveCalendar);
            this.Controls.Add(this.btnEditTrucks);
            this.Controls.Add(this.btnEditPersonnel);
            this.Name = "Hub";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditPersonnel;
        private System.Windows.Forms.Button btnEditTrucks;
        private System.Windows.Forms.Button btnLeaveCalendar;
    }
}