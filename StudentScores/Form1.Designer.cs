namespace StudentScores
{
    partial class studentScores
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
            this.addNewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.studentLbl = new System.Windows.Forms.Label();
            this.scoreTotalLbl = new System.Windows.Forms.Label();
            this.scoreCountLbl = new System.Windows.Forms.Label();
            this.averageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(325, 24);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(96, 23);
            this.addNewBtn.TabIndex = 0;
            this.addNewBtn.Text = "&Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(325, 53);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "&Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(325, 82);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(325, 192);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(96, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Location = new System.Drawing.Point(12, 9);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(52, 13);
            this.studentLbl.TabIndex = 0;
            this.studentLbl.Text = "Students:";
            // 
            // scoreTotalLbl
            // 
            this.scoreTotalLbl.AutoSize = true;
            this.scoreTotalLbl.Location = new System.Drawing.Point(151, 178);
            this.scoreTotalLbl.Name = "scoreTotalLbl";
            this.scoreTotalLbl.Size = new System.Drawing.Size(65, 13);
            this.scoreTotalLbl.TabIndex = 0;
            this.scoreTotalLbl.Text = "Score Total:";
            // 
            // scoreCountLbl
            // 
            this.scoreCountLbl.AutoSize = true;
            this.scoreCountLbl.Location = new System.Drawing.Point(147, 204);
            this.scoreCountLbl.Name = "scoreCountLbl";
            this.scoreCountLbl.Size = new System.Drawing.Size(69, 13);
            this.scoreCountLbl.TabIndex = 0;
            this.scoreCountLbl.Text = "Score Count:";
            this.scoreCountLbl.Click += new System.EventHandler(this.scoreCountLbl_Click);
            // 
            // averageLbl
            // 
            this.averageLbl.AutoSize = true;
            this.averageLbl.Location = new System.Drawing.Point(166, 230);
            this.averageLbl.Name = "averageLbl";
            this.averageLbl.Size = new System.Drawing.Size(50, 13);
            this.averageLbl.TabIndex = 0;
            this.averageLbl.Text = "Average:";
            // 
            // studentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 262);
            this.Controls.Add(this.averageLbl);
            this.Controls.Add(this.scoreCountLbl);
            this.Controls.Add(this.scoreTotalLbl);
            this.Controls.Add(this.studentLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addNewBtn);
            this.Name = "studentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.Label scoreTotalLbl;
        private System.Windows.Forms.Label scoreCountLbl;
        private System.Windows.Forms.Label averageLbl;
    }
}

