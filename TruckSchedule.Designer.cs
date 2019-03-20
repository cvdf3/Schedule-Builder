namespace Schedule_Builder
{
    partial class TruckSchedule
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
            this.gridSt2 = new System.Windows.Forms.DataGridView();
            this.gridSt3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.gridSt1 = new System.Windows.Forms.DataGridView();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSt1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSt2
            // 
            this.gridSt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSt2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridSt2.Location = new System.Drawing.Point(464, 55);
            this.gridSt2.Name = "gridSt2";
            this.gridSt2.Size = new System.Drawing.Size(327, 354);
            this.gridSt2.TabIndex = 1;
            // 
            // gridSt3
            // 
            this.gridSt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSt3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridSt3.Location = new System.Drawing.Point(925, 55);
            this.gridSt3.Name = "gridSt3";
            this.gridSt3.Size = new System.Drawing.Size(327, 354);
            this.gridSt3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Station 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Station 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Station 3";
            // 
            // lbNotes
            // 
            this.lbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.Location = new System.Drawing.Point(12, 556);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(1240, 108);
            this.lbNotes.TabIndex = 6;
            // 
            // gridSt1
            // 
            this.gridSt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSt1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridSt1.Location = new System.Drawing.Point(12, 55);
            this.gridSt1.Name = "gridSt1";
            this.gridSt1.Size = new System.Drawing.Size(327, 354);
            this.gridSt1.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(598, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 8;
            // 
            // TruckSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gridSt1);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSt3);
            this.Controls.Add(this.gridSt2);
            this.Name = "TruckSchedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.gridSt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSt2;
        private System.Windows.Forms.DataGridView gridSt3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.DataGridView gridSt1;
        private System.Windows.Forms.Label dateLabel;
    }
}