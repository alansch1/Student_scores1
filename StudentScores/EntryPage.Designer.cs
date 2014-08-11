namespace EntryPage
{
	partial class EntryPage
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
			this.scoreTotalNameLbl = new System.Windows.Forms.Label();
			this.scoreCountNameLbl = new System.Windows.Forms.Label();
			this.averageNameLbl = new System.Windows.Forms.Label();
			this.scoreTotalLbl = new System.Windows.Forms.Label();
			this.scoreCountLbl = new System.Windows.Forms.Label();
			this.scoreAverageLbl = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// addNewBtn
			// 
			this.addNewBtn.Location = new System.Drawing.Point(350, 25);
			this.addNewBtn.Name = "addNewBtn";
			this.addNewBtn.Size = new System.Drawing.Size(96, 23);
			this.addNewBtn.TabIndex = 2;
			this.addNewBtn.Text = "&Add New";
			this.addNewBtn.UseVisualStyleBackColor = true;
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(350, 54);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(96, 23);
			this.updateBtn.TabIndex = 3;
			this.updateBtn.Text = "&Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(350, 120);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(96, 23);
			this.deleteBtn.TabIndex = 4;
			this.deleteBtn.Text = "&Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(350, 194);
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
			// scoreTotalNameLbl
			// 
			this.scoreTotalNameLbl.AutoSize = true;
			this.scoreTotalNameLbl.Location = new System.Drawing.Point(132, 172);
			this.scoreTotalNameLbl.Name = "scoreTotalNameLbl";
			this.scoreTotalNameLbl.Size = new System.Drawing.Size(65, 13);
			this.scoreTotalNameLbl.TabIndex = 0;
			this.scoreTotalNameLbl.Text = "Score Total:";
			// 
			// scoreCountNameLbl
			// 
			this.scoreCountNameLbl.AutoSize = true;
			this.scoreCountNameLbl.Location = new System.Drawing.Point(128, 198);
			this.scoreCountNameLbl.Name = "scoreCountNameLbl";
			this.scoreCountNameLbl.Size = new System.Drawing.Size(69, 13);
			this.scoreCountNameLbl.TabIndex = 0;
			this.scoreCountNameLbl.Text = "Score Count:";
			// 
			// averageNameLbl
			// 
			this.averageNameLbl.AutoSize = true;
			this.averageNameLbl.Location = new System.Drawing.Point(147, 224);
			this.averageNameLbl.Name = "averageNameLbl";
			this.averageNameLbl.Size = new System.Drawing.Size(50, 13);
			this.averageNameLbl.TabIndex = 0;
			this.averageNameLbl.Text = "Average:";
			// 
			// scoreTotalLbl
			// 
			this.scoreTotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.scoreTotalLbl.Location = new System.Drawing.Point(230, 172);
			this.scoreTotalLbl.Name = "scoreTotalLbl";
			this.scoreTotalLbl.Size = new System.Drawing.Size(75, 23);
			this.scoreTotalLbl.TabIndex = 0;
			this.scoreTotalLbl.Text = "~ Total ~";
			this.scoreTotalLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// scoreCountLbl
			// 
			this.scoreCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.scoreCountLbl.Location = new System.Drawing.Point(230, 198);
			this.scoreCountLbl.Name = "scoreCountLbl";
			this.scoreCountLbl.Size = new System.Drawing.Size(75, 23);
			this.scoreCountLbl.TabIndex = 0;
			this.scoreCountLbl.Text = "~ Count ~";
			this.scoreCountLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// scoreAverageLbl
			// 
			this.scoreAverageLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.scoreAverageLbl.Location = new System.Drawing.Point(230, 224);
			this.scoreAverageLbl.Name = "scoreAverageLbl";
			this.scoreAverageLbl.Size = new System.Drawing.Size(75, 23);
			this.scoreAverageLbl.TabIndex = 0;
			this.scoreAverageLbl.Text = "~ Average ~";
			this.scoreAverageLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(15, 25);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(290, 134);
			this.listBox1.TabIndex = 6;
			// 
			// EntryPage
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(472, 262);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.scoreAverageLbl);
			this.Controls.Add(this.scoreCountLbl);
			this.Controls.Add(this.scoreTotalLbl);
			this.Controls.Add(this.averageNameLbl);
			this.Controls.Add(this.scoreCountNameLbl);
			this.Controls.Add(this.scoreTotalNameLbl);
			this.Controls.Add(this.studentLbl);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.addNewBtn);
			this.Name = "EntryPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Scores";
			this.Load += new System.EventHandler(this.studentScores_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addNewBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label studentLbl;
		private System.Windows.Forms.Label scoreTotalNameLbl;
		private System.Windows.Forms.Label scoreCountNameLbl;
		private System.Windows.Forms.Label averageNameLbl;
		private System.Windows.Forms.Label scoreTotalLbl;
		private System.Windows.Forms.Label scoreCountLbl;
		private System.Windows.Forms.Label scoreAverageLbl;
		private System.Windows.Forms.ListBox listBox1;
	}
}
