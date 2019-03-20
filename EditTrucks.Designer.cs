namespace Schedule_Builder
{
    partial class EditTrucks
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNum = new System.Windows.Forms.TextBox();
            this.boxStation = new System.Windows.Forms.TextBox();
            this.boxPositions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTrucks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Positions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Station:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vehicle #:";
            // 
            // boxNum
            // 
            this.boxNum.Location = new System.Drawing.Point(78, 12);
            this.boxNum.Name = "boxNum";
            this.boxNum.Size = new System.Drawing.Size(100, 20);
            this.boxNum.TabIndex = 0;
            // 
            // boxStation
            // 
            this.boxStation.Location = new System.Drawing.Point(78, 38);
            this.boxStation.Name = "boxStation";
            this.boxStation.Size = new System.Drawing.Size(100, 20);
            this.boxStation.TabIndex = 1;
            // 
            // boxPositions
            // 
            this.boxPositions.Location = new System.Drawing.Point(78, 64);
            this.boxPositions.Name = "boxPositions";
            this.boxPositions.Size = new System.Drawing.Size(100, 20);
            this.boxPositions.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vehicles";
            // 
            // lbTrucks
            // 
            this.lbTrucks.FormattingEnabled = true;
            this.lbTrucks.Location = new System.Drawing.Point(225, 12);
            this.lbTrucks.Name = "lbTrucks";
            this.lbTrucks.Size = new System.Drawing.Size(283, 212);
            this.lbTrucks.TabIndex = 22;
            this.lbTrucks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbTrucks_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(78, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add / Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(78, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTrucks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNum);
            this.Controls.Add(this.boxStation);
            this.Controls.Add(this.boxPositions);
            this.Name = "EditTrucks";
            this.Text = "Manage Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNum;
        private System.Windows.Forms.TextBox boxStation;
        private System.Windows.Forms.TextBox boxPositions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTrucks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}