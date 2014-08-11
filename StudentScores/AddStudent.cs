using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntryPage
{
	public partial class AddStudent : Form
	{
        Dictionary<string, List<int>> newStudent = new Dictionary<string, List<int>>();
        List<int> newScores = new List<int>();

		public AddStudent()
		{
			InitializeComponent();
		}

		private void cancelNewStudentBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addScoreBtn_Click(object sender, EventArgs e)
		{
			 try
            {
                if (Int32.Parse(score2Txt.Text) >= 0 && Int32.Parse(score2Txt.Text) <= 100)
                {
                    InitializeAddScore();	                                                         //Runs The Add Student Method, clears the box after
                    score2Txt.Clear();																	//then re-sets the focus onto it
				    score2Txt.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter a score between 0 and 100.", "Invalid score");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Entry");
            }
			
		}

		private void InitializeAddScore()
		{
			int score = Convert.ToInt32(score2Txt.Text);
			newScores.Add(score);

		}

		private void okNewStudentBtn_Click(object sender, EventArgs e)
		{
            if (name2Txt.Text != "")
            {
				EntryPage.newStudent1.Add(name2Txt.Text, newScores);				// String name = null;
				// foreach(Int32 number in newScores) { printList += number.toString() + ", ";
                this.Close();															// txt = printlist
            }
            else
            {
                MessageBox.Show("Please enter a name", "Empty name field");
                name2Txt.Focus();
            }
		}

		private void name2Txt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}