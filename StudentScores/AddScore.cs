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
	public partial class AddScore : Form
	{
		public AddScore()
		{
			InitializeComponent();
		}

		private void cancelScore4Btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addScore4Btn_Click(object sender, EventArgs e)
		{
			try
            {
                if (Int32.Parse(addScore4Txt.Text) >= 0 && Int32.Parse(addScore4Txt.Text) <= 100)
                {
                    UpdatePage.listStudents.Values.ElementAt(EntryPage.highlighted).Add(Int32.Parse(addScore4Txt.Text));
                    this.Close();
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
	}
}
