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
	public partial class EntryPage : Form
	{
		public Dictionary<string, List<int>> newStudent1 = new Dictionary<string, List<int>>();
		public static int highlighted;



		public EntryPage()
		{
			InitializeComponent();
			newStudent1.Add("Dude Marley", new List<int> { 21, 14, 44 });
			newStudent1.Add("Charls Iknownothing", new List<int> { 23, 41, 44 });
			newStudent1.Add("Little Wayne", new List<int> { 51, 99, 11 });

			makeList();
		}

		private void button3_Click(object sender, EventArgs e)
		{ 
		}


		private void makeList()
		{
			foreach (var student in newStudent1)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(student.Key.ToString());
				sb.Append(" - ");
				for (int i = 0; i < student.Value.Count; i++)
				{
					sb.Append(student.Value[i]);
					if (i != student.Value.Count - 1)
					{
						sb.Append(", ");
					}
				}
				listBox1.Items.Add(sb);
				listBox1.SetSelected(0, true);
				TableUpdate();
			}
		}

		private void TableUpdate()
		{
			try
			{

				scoreTotalLbl.Text = newStudent1.Values.ElementAt(listBox1.SelectedIndex).Sum().ToString();
				scoreCountLbl.Text = newStudent1.Values.ElementAt(listBox1.SelectedIndex).Count.ToString();
				scoreAverageLbl.Text = Math.Round(newStudent1.Values.ElementAt(listBox1.SelectedIndex).Average()).ToString();
			}
			catch (Exception)
			{
				scoreTotalLbl.Text = "";
				scoreCountLbl.Text = "";
				scoreAverageLbl.Text = "";
			}
		}
		private void scoreCountLbl_Click(object sender, EventArgs e)
		{

		}

		private void studentList_SelectedIndexChanged(object sender, EventArgs e)
		{
			TableUpdate();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void addNewBtn_Click(object sender, EventArgs e)
		{

			Form openAddStudent = new AddStudent();
			openAddStudent.ShowDialog();
			listBox1.Items.Clear();
			makeList();


		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			UpdatePage openUpdatePage = new UpdatePage();
			openUpdatePage.Show();
		}

		private void studentScores_Load(object sender, EventArgs e)
		{

		}


	}
}
