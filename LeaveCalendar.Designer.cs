namespace Schedule_Builder
{
    partial class LeaveCalendar
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
            this.gridCalendar = new System.Windows.Forms.DataGridView();
            this.boxMonth = new System.Windows.Forms.ComboBox();
            this.boxYear = new System.Windows.Forms.ComboBox();
            this.boxShift = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCalendar
            // 
            this.gridCalendar.AllowUserToAddRows = false;
            this.gridCalendar.AllowUserToDeleteRows = false;
            this.gridCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCalendar.Location = new System.Drawing.Point(12, 12);
            this.gridCalendar.Name = "gridCalendar";
            this.gridCalendar.Size = new System.Drawing.Size(1240, 506);
            this.gridCalendar.TabIndex = 4;
            this.gridCalendar.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCalendar_ColumnHeaderMouseClick_1);
            // 
            // boxMonth
            // 
            this.boxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxMonth.FormattingEnabled = true;
            this.boxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.boxMonth.Location = new System.Drawing.Point(12, 572);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(121, 21);
            this.boxMonth.TabIndex = 0;
            // 
            // boxYear
            // 
            this.boxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxYear.FormattingEnabled = true;
            this.boxYear.Location = new System.Drawing.Point(199, 572);
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(121, 21);
            this.boxYear.TabIndex = 1;
            // 
            // boxShift
            // 
            this.boxShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boxShift.FormattingEnabled = true;
            this.boxShift.Items.AddRange(new object[] {
            "A",
            "B"});
            this.boxShift.Location = new System.Drawing.Point(395, 572);
            this.boxShift.Name = "boxShift";
            this.boxShift.Size = new System.Drawing.Size(121, 21);
            this.boxShift.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(596, 570);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LeaveCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.boxShift);
            this.Controls.Add(this.boxYear);
            this.Controls.Add(this.boxMonth);
            this.Controls.Add(this.gridCalendar);
            this.Name = "LeaveCalendar";
            this.Text = "Leave Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCalendar;
        private System.Windows.Forms.ComboBox boxMonth;
        private System.Windows.Forms.ComboBox boxYear;
        private System.Windows.Forms.ComboBox boxShift;
        private System.Windows.Forms.Button btnSearch;
    }
}