namespace EntryPage
{
    partial class AddStudent
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
			this.name2Lbl = new System.Windows.Forms.Label();
			this.score2Lbl = new System.Windows.Forms.Label();
			this.scores2Lbl = new System.Windows.Forms.Label();
			this.name2Txt = new System.Windows.Forms.TextBox();
			this.score2Txt = new System.Windows.Forms.TextBox();
			this.scoreDisplayLbl = new System.Windows.Forms.Label();
			this.addScoreBtn = new System.Windows.Forms.Button();
			this.clearScoreBtn = new System.Windows.Forms.Button();
			this.okNewStudentBtn = new System.Windows.Forms.Button();
			this.cancelNewStudentBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name2Lbl
			// 
			this.name2Lbl.AutoSize = true;
			this.name2Lbl.Location = new System.Drawing.Point(52, 46);
			this.name2Lbl.Name = "name2Lbl";
			this.name2Lbl.Size = new System.Drawing.Size(38, 13);
			this.name2Lbl.TabIndex = 0;
			this.name2Lbl.Text = "Name:";
			// 
			// score2Lbl
			// 
			this.score2Lbl.AutoSize = true;
			this.score2Lbl.Location = new System.Drawing.Point(52, 97);
			this.score2Lbl.Name = "score2Lbl";
			this.score2Lbl.Size = new System.Drawing.Size(38, 13);
			this.score2Lbl.TabIndex = 0;
			this.score2Lbl.Text = "Score:";
			// 
			// scores2Lbl
			// 
			this.scores2Lbl.AutoSize = true;
			this.scores2Lbl.Location = new System.Drawing.Point(52, 148);
			this.scores2Lbl.Name = "scores2Lbl";
			this.scores2Lbl.Size = new System.Drawing.Size(43, 13);
			this.scores2Lbl.TabIndex = 0;
			this.scores2Lbl.Text = "Scores:";
			// 
			// name2Txt
			// 
			this.name2Txt.Location = new System.Drawing.Point(116, 43);
			this.name2Txt.Name = "name2Txt";
			this.name2Txt.Size = new System.Drawing.Size(327, 20);
			this.name2Txt.TabIndex = 1;
			this.name2Txt.TextChanged += new System.EventHandler(this.name2Txt_TextChanged);
			// 
			// score2Txt
			// 
			this.score2Txt.Location = new System.Drawing.Point(116, 94);
			this.score2Txt.Name = "score2Txt";
			this.score2Txt.Size = new System.Drawing.Size(153, 20);
			this.score2Txt.TabIndex = 2;
			// 
			// scoreDisplayLbl
			// 
			this.scoreDisplayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.scoreDisplayLbl.Location = new System.Drawing.Point(116, 148);
			this.scoreDisplayLbl.Name = "scoreDisplayLbl";
			this.scoreDisplayLbl.Size = new System.Drawing.Size(327, 23);
			this.scoreDisplayLbl.TabIndex = 0;
			// 
			// addScoreBtn
			// 
			this.addScoreBtn.Location = new System.Drawing.Point(313, 97);
			this.addScoreBtn.Name = "addScoreBtn";
			this.addScoreBtn.Size = new System.Drawing.Size(129, 23);
			this.addScoreBtn.TabIndex = 3;
			this.addScoreBtn.Text = "Add Score";
			this.addScoreBtn.UseVisualStyleBackColor = true;
			this.addScoreBtn.Click += new System.EventHandler(this.addScoreBtn_Click);
			// 
			// clearScoreBtn
			// 
			this.clearScoreBtn.Location = new System.Drawing.Point(314, 190);
			this.clearScoreBtn.Name = "clearScoreBtn";
			this.clearScoreBtn.Size = new System.Drawing.Size(129, 23);
			this.clearScoreBtn.TabIndex = 4;
			this.clearScoreBtn.Text = "Clear Scores";
			this.clearScoreBtn.UseVisualStyleBackColor = true;
			// 
			// okNewStudentBtn
			// 
			this.okNewStudentBtn.Location = new System.Drawing.Point(160, 234);
			this.okNewStudentBtn.Name = "okNewStudentBtn";
			this.okNewStudentBtn.Size = new System.Drawing.Size(129, 23);
			this.okNewStudentBtn.TabIndex = 5;
			this.okNewStudentBtn.Text = "&OK";
			this.okNewStudentBtn.UseVisualStyleBackColor = true;
			this.okNewStudentBtn.Click += new System.EventHandler(this.okNewStudentBtn_Click);
			// 
			// cancelNewStudentBtn
			// 
			this.cancelNewStudentBtn.Location = new System.Drawing.Point(313, 234);
			this.cancelNewStudentBtn.Name = "cancelNewStudentBtn";
			this.cancelNewStudentBtn.Size = new System.Drawing.Size(129, 23);
			this.cancelNewStudentBtn.TabIndex = 6;
			this.cancelNewStudentBtn.Text = "&Cancel";
			this.cancelNewStudentBtn.UseVisualStyleBackColor = true;
			this.cancelNewStudentBtn.Click += new System.EventHandler(this.cancelNewStudentBtn_Click);
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 282);
			this.Controls.Add(this.cancelNewStudentBtn);
			this.Controls.Add(this.okNewStudentBtn);
			this.Controls.Add(this.clearScoreBtn);
			this.Controls.Add(this.addScoreBtn);
			this.Controls.Add(this.scoreDisplayLbl);
			this.Controls.Add(this.score2Txt);
			this.Controls.Add(this.name2Txt);
			this.Controls.Add(this.scores2Lbl);
			this.Controls.Add(this.score2Lbl);
			this.Controls.Add(this.name2Lbl);
			this.Name = "AddStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Student";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name2Lbl;
        private System.Windows.Forms.Label score2Lbl;
        private System.Windows.Forms.Label scores2Lbl;
        private System.Windows.Forms.TextBox name2Txt;
        private System.Windows.Forms.TextBox score2Txt;
        private System.Windows.Forms.Label scoreDisplayLbl;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.Button clearScoreBtn;
        private System.Windows.Forms.Button okNewStudentBtn;
        private System.Windows.Forms.Button cancelNewStudentBtn;
    }
}