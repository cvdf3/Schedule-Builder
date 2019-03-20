namespace Schedule_Builder
{
    partial class PersonnelList
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
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAshift = new System.Windows.Forms.ListBox();
            this.lbBshift = new System.Windows.Forms.ListBox();
            this.checkConnection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.boxPosition = new System.Windows.Forms.ComboBox();
            this.boxStation = new System.Windows.Forms.ComboBox();
            this.boxKellyDay = new System.Windows.Forms.ComboBox();
            this.boxShift = new System.Windows.Forms.ComboBox();
            this.boxAdmin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(76, 40);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 1;
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(76, 14);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(100, 20);
            this.boxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Admin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Shift:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kelly Day:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Station:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add / Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAshift
            // 
            this.lbAshift.FormattingEnabled = true;
            this.lbAshift.Location = new System.Drawing.Point(198, 12);
            this.lbAshift.Name = "lbAshift";
            this.lbAshift.Size = new System.Drawing.Size(283, 420);
            this.lbAshift.TabIndex = 17;
            this.lbAshift.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAshift_MouseClick);
            // 
            // lbBshift
            // 
            this.lbBshift.FormattingEnabled = true;
            this.lbBshift.Location = new System.Drawing.Point(505, 12);
            this.lbBshift.Name = "lbBshift";
            this.lbBshift.Size = new System.Drawing.Size(283, 420);
            this.lbBshift.TabIndex = 18;
            this.lbBshift.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbBshift_MouseClick);
            // 
            // checkConnection
            // 
            this.checkConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(12, 426);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(16, 13);
            this.checkConnection.TabIndex = 19;
            this.checkConnection.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "A Shift";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(624, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "B Shift";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(76, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 29);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // boxPosition
            // 
            this.boxPosition.FormattingEnabled = true;
            this.boxPosition.Items.AddRange(new object[] {
            "Firefighter",
            "Driver",
            "Crew Chief",
            "Station Captain",
            "AC"});
            this.boxPosition.Location = new System.Drawing.Point(76, 118);
            this.boxPosition.Name = "boxPosition";
            this.boxPosition.Size = new System.Drawing.Size(100, 21);
            this.boxPosition.TabIndex = 5;
            // 
            // boxStation
            // 
            this.boxStation.FormattingEnabled = true;
            this.boxStation.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.boxStation.Location = new System.Drawing.Point(76, 170);
            this.boxStation.Name = "boxStation";
            this.boxStation.Size = new System.Drawing.Size(100, 21);
            this.boxStation.TabIndex = 7;
            // 
            // boxKellyDay
            // 
            this.boxKellyDay.FormattingEnabled = true;
            this.boxKellyDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.boxKellyDay.Location = new System.Drawing.Point(76, 144);
            this.boxKellyDay.Name = "boxKellyDay";
            this.boxKellyDay.Size = new System.Drawing.Size(100, 21);
            this.boxKellyDay.TabIndex = 6;
            // 
            // boxShift
            // 
            this.boxShift.FormattingEnabled = true;
            this.boxShift.Items.AddRange(new object[] {
            "A",
            "B"});
            this.boxShift.Location = new System.Drawing.Point(76, 92);
            this.boxShift.Name = "boxShift";
            this.boxShift.Size = new System.Drawing.Size(100, 21);
            this.boxShift.TabIndex = 3;
            // 
            // boxAdmin
            // 
            this.boxAdmin.FormattingEnabled = true;
            this.boxAdmin.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.boxAdmin.Location = new System.Drawing.Point(76, 66);
            this.boxAdmin.Name = "boxAdmin";
            this.boxAdmin.Size = new System.Drawing.Size(100, 21);
            this.boxAdmin.TabIndex = 2;
            // 
            // PersonnelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxAdmin);
            this.Controls.Add(this.boxShift);
            this.Controls.Add(this.boxKellyDay);
            this.Controls.Add(this.boxStation);
            this.Controls.Add(this.boxPosition);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.lbBshift);
            this.Controls.Add(this.lbAshift);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.boxName);
            this.Name = "PersonnelList";
            this.Text = "Personnel List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbAshift;
        private System.Windows.Forms.ListBox lbBshift;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox boxPosition;
        private System.Windows.Forms.ComboBox boxStation;
        private System.Windows.Forms.ComboBox boxKellyDay;
        private System.Windows.Forms.ComboBox boxShift;
        private System.Windows.Forms.ComboBox boxAdmin;
    }
}

