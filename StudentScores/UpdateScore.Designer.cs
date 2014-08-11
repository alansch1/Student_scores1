namespace EntryPage
{
	partial class UpdateScore
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
			this.cancelScore5Btn = new System.Windows.Forms.Button();
			this.updateScore5Btn = new System.Windows.Forms.Button();
			this.updateScore5Txt = new System.Windows.Forms.TextBox();
			this.scoreAdd5lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelScore5Btn
			// 
			this.cancelScore5Btn.Location = new System.Drawing.Point(149, 47);
			this.cancelScore5Btn.Name = "cancelScore5Btn";
			this.cancelScore5Btn.Size = new System.Drawing.Size(75, 23);
			this.cancelScore5Btn.TabIndex = 3;
			this.cancelScore5Btn.Text = "Cancel";
			this.cancelScore5Btn.UseVisualStyleBackColor = true;
			this.cancelScore5Btn.Click += new System.EventHandler(this.cancelScore5Btn_Click);
			// 
			// updateScore5Btn
			// 
			this.updateScore5Btn.Location = new System.Drawing.Point(12, 47);
			this.updateScore5Btn.Name = "updateScore5Btn";
			this.updateScore5Btn.Size = new System.Drawing.Size(75, 23);
			this.updateScore5Btn.TabIndex = 2;
			this.updateScore5Btn.Text = "Update";
			this.updateScore5Btn.UseVisualStyleBackColor = true;
			this.updateScore5Btn.Click += new System.EventHandler(this.updateScore5Btn_Click);
			// 
			// updateScore5Txt
			// 
			this.updateScore5Txt.Location = new System.Drawing.Point(56, 9);
			this.updateScore5Txt.Name = "updateScore5Txt";
			this.updateScore5Txt.Size = new System.Drawing.Size(158, 20);
			this.updateScore5Txt.TabIndex = 1;
			// 
			// scoreAdd5lbl
			// 
			this.scoreAdd5lbl.AutoSize = true;
			this.scoreAdd5lbl.Location = new System.Drawing.Point(12, 12);
			this.scoreAdd5lbl.Name = "scoreAdd5lbl";
			this.scoreAdd5lbl.Size = new System.Drawing.Size(38, 13);
			this.scoreAdd5lbl.TabIndex = 0;
			this.scoreAdd5lbl.Text = "Score:";
			// 
			// UpdateScore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 79);
			this.Controls.Add(this.cancelScore5Btn);
			this.Controls.Add(this.updateScore5Btn);
			this.Controls.Add(this.updateScore5Txt);
			this.Controls.Add(this.scoreAdd5lbl);
			this.Name = "UpdateScore";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Score";
			this.Load += new System.EventHandler(this.UpdateScore_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cancelScore5Btn;
		private System.Windows.Forms.Button updateScore5Btn;
		private System.Windows.Forms.TextBox updateScore5Txt;
		private System.Windows.Forms.Label scoreAdd5lbl;
	}
}