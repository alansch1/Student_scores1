namespace EntryPage
{
	partial class AddScore
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
			this.scoreAdd4lbl = new System.Windows.Forms.Label();
			this.addScore4Txt = new System.Windows.Forms.TextBox();
			this.addScore4Btn = new System.Windows.Forms.Button();
			this.cancelScore4Btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// scoreAdd4lbl
			// 
			this.scoreAdd4lbl.AutoSize = true;
			this.scoreAdd4lbl.Location = new System.Drawing.Point(12, 9);
			this.scoreAdd4lbl.Name = "scoreAdd4lbl";
			this.scoreAdd4lbl.Size = new System.Drawing.Size(38, 13);
			this.scoreAdd4lbl.TabIndex = 0;
			this.scoreAdd4lbl.Text = "Score:";
			// 
			// addScore4Txt
			// 
			this.addScore4Txt.Location = new System.Drawing.Point(56, 6);
			this.addScore4Txt.Name = "addScore4Txt";
			this.addScore4Txt.Size = new System.Drawing.Size(158, 20);
			this.addScore4Txt.TabIndex = 1;
			// 
			// addScore4Btn
			// 
			this.addScore4Btn.Location = new System.Drawing.Point(12, 44);
			this.addScore4Btn.Name = "addScore4Btn";
			this.addScore4Btn.Size = new System.Drawing.Size(75, 23);
			this.addScore4Btn.TabIndex = 2;
			this.addScore4Btn.Text = "Add";
			this.addScore4Btn.UseVisualStyleBackColor = true;
			this.addScore4Btn.Click += new System.EventHandler(this.addScore4Btn_Click);
			// 
			// cancelScore4Btn
			// 
			this.cancelScore4Btn.Location = new System.Drawing.Point(149, 44);
			this.cancelScore4Btn.Name = "cancelScore4Btn";
			this.cancelScore4Btn.Size = new System.Drawing.Size(75, 23);
			this.cancelScore4Btn.TabIndex = 3;
			this.cancelScore4Btn.Text = "Cancel";
			this.cancelScore4Btn.UseVisualStyleBackColor = true;
			this.cancelScore4Btn.Click += new System.EventHandler(this.cancelScore4Btn_Click);
			// 
			// AddScore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 79);
			this.Controls.Add(this.cancelScore4Btn);
			this.Controls.Add(this.addScore4Btn);
			this.Controls.Add(this.addScore4Txt);
			this.Controls.Add(this.scoreAdd4lbl);
			this.Name = "AddScore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Score";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label scoreAdd4lbl;
		private System.Windows.Forms.TextBox addScore4Txt;
		private System.Windows.Forms.Button addScore4Btn;
		private System.Windows.Forms.Button cancelScore4Btn;
	}
}