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
	public partial class UpdateScore : Form
	{
		public UpdateScore()
		{
			InitializeComponent();
		}

		private void UpdateScore_Load(object sender, EventArgs e)
		{

		}

		private void cancelScore5Btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void updateScore5Btn_Click(object sender, EventArgs e)
		{
			String scoreUpdate = updateScore5Txt.Text;
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < scoreUpdate.Length; i++)
			{
				if (!char.IsNumber(scoreUpdate[i]) || String.IsNullOrEmpty(updateScore5Txt.Text) || String.IsNullOrWhiteSpace(updateScore5Txt.Text))
				{
					MessageBox.Show("Please Enter A Valid Number!");
					updateScore5Txt.Text = "";
					return;
				}
			}
		}
	}
}
