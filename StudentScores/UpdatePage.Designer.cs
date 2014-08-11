namespace EntryPage
{
	partial class UpdatePage
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
            this.name3Lbl = new System.Windows.Forms.Label();
            this.studentNameDisplayLbl = new System.Windows.Forms.Label();
            this.score3Lbl = new System.Windows.Forms.Label();
            this.score3List = new System.Windows.Forms.ListBox();
            this.addScore3btn = new System.Windows.Forms.Button();
            this.updateScoreBtn = new System.Windows.Forms.Button();
            this.removeScore3Btn = new System.Windows.Forms.Button();
            this.clearScore3Btn = new System.Windows.Forms.Button();
            this.ok3Btn = new System.Windows.Forms.Button();
            this.cancel3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name3Lbl
            // 
            this.name3Lbl.AutoSize = true;
            this.name3Lbl.Location = new System.Drawing.Point(30, 20);
            this.name3Lbl.Name = "name3Lbl";
            this.name3Lbl.Size = new System.Drawing.Size(38, 13);
            this.name3Lbl.TabIndex = 0;
            this.name3Lbl.Text = "Name:";
            // 
            // studentNameDisplayLbl
            // 
            this.studentNameDisplayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentNameDisplayLbl.Location = new System.Drawing.Point(103, 20);
            this.studentNameDisplayLbl.Name = "studentNameDisplayLbl";
            this.studentNameDisplayLbl.Size = new System.Drawing.Size(199, 24);
            this.studentNameDisplayLbl.TabIndex = 0;
            this.studentNameDisplayLbl.Text = "label2";
            // 
            // score3Lbl
            // 
            this.score3Lbl.AutoSize = true;
            this.score3Lbl.Location = new System.Drawing.Point(30, 70);
            this.score3Lbl.Name = "score3Lbl";
            this.score3Lbl.Size = new System.Drawing.Size(49, 13);
            this.score3Lbl.TabIndex = 0;
            this.score3Lbl.Text = "Score(s):";
            // 
            // score3List
            // 
            this.score3List.FormattingEnabled = true;
            this.score3List.Location = new System.Drawing.Point(106, 70);
            this.score3List.Name = "score3List";
            this.score3List.Size = new System.Drawing.Size(196, 212);
            this.score3List.TabIndex = 1;
            this.score3List.SelectedIndexChanged += new System.EventHandler(this.score3List_SelectedIndexChanged);
            // 
            // addScore3btn
            // 
            this.addScore3btn.Location = new System.Drawing.Point(352, 70);
            this.addScore3btn.Name = "addScore3btn";
            this.addScore3btn.Size = new System.Drawing.Size(75, 23);
            this.addScore3btn.TabIndex = 2;
            this.addScore3btn.Text = "Add";
            this.addScore3btn.UseVisualStyleBackColor = true;
            this.addScore3btn.Click += new System.EventHandler(this.addScore3btn_Click);
            // 
            // updateScoreBtn
            // 
            this.updateScoreBtn.Location = new System.Drawing.Point(352, 99);
            this.updateScoreBtn.Name = "updateScoreBtn";
            this.updateScoreBtn.Size = new System.Drawing.Size(75, 23);
            this.updateScoreBtn.TabIndex = 3;
            this.updateScoreBtn.Text = "Update";
            this.updateScoreBtn.UseVisualStyleBackColor = true;
            this.updateScoreBtn.Click += new System.EventHandler(this.updateScoreBtn_Click);
            // 
            // removeScore3Btn
            // 
            this.removeScore3Btn.Location = new System.Drawing.Point(352, 128);
            this.removeScore3Btn.Name = "removeScore3Btn";
            this.removeScore3Btn.Size = new System.Drawing.Size(75, 23);
            this.removeScore3Btn.TabIndex = 4;
            this.removeScore3Btn.Text = "Remove";
            this.removeScore3Btn.UseVisualStyleBackColor = true;
            // 
            // clearScore3Btn
            // 
            this.clearScore3Btn.Location = new System.Drawing.Point(352, 157);
            this.clearScore3Btn.Name = "clearScore3Btn";
            this.clearScore3Btn.Size = new System.Drawing.Size(75, 23);
            this.clearScore3Btn.TabIndex = 5;
            this.clearScore3Btn.Text = "Clear Scores";
            this.clearScore3Btn.UseVisualStyleBackColor = true;
            // 
            // ok3Btn
            // 
            this.ok3Btn.Location = new System.Drawing.Point(227, 305);
            this.ok3Btn.Name = "ok3Btn";
            this.ok3Btn.Size = new System.Drawing.Size(75, 23);
            this.ok3Btn.TabIndex = 6;
            this.ok3Btn.Text = "&OK";
            this.ok3Btn.UseVisualStyleBackColor = true;
            // 
            // cancel3Btn
            // 
            this.cancel3Btn.Location = new System.Drawing.Point(352, 305);
            this.cancel3Btn.Name = "cancel3Btn";
            this.cancel3Btn.Size = new System.Drawing.Size(75, 23);
            this.cancel3Btn.TabIndex = 7;
            this.cancel3Btn.Text = "Cancel";
            this.cancel3Btn.UseVisualStyleBackColor = true;
            this.cancel3Btn.Click += new System.EventHandler(this.cancel3Btn_Click);
            // 
            // UpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 351);
            this.Controls.Add(this.cancel3Btn);
            this.Controls.Add(this.ok3Btn);
            this.Controls.Add(this.clearScore3Btn);
            this.Controls.Add(this.removeScore3Btn);
            this.Controls.Add(this.updateScoreBtn);
            this.Controls.Add(this.addScore3btn);
            this.Controls.Add(this.score3List);
            this.Controls.Add(this.score3Lbl);
            this.Controls.Add(this.studentNameDisplayLbl);
            this.Controls.Add(this.name3Lbl);
            this.Name = "UpdatePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Scores";
            this.Load += new System.EventHandler(this.UpdatePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label name3Lbl;
		private System.Windows.Forms.Label studentNameDisplayLbl;
		private System.Windows.Forms.Label score3Lbl;
		private System.Windows.Forms.ListBox score3List;
		private System.Windows.Forms.Button addScore3btn;
		private System.Windows.Forms.Button updateScoreBtn;
		private System.Windows.Forms.Button removeScore3Btn;
		private System.Windows.Forms.Button clearScore3Btn;
		private System.Windows.Forms.Button ok3Btn;
		private System.Windows.Forms.Button cancel3Btn;
	}
}