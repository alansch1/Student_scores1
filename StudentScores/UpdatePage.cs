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
	public partial class UpdatePage : Form
	{
        public static Dictionary<string, List<int>> listStudents;
        BindingSource bs = new BindingSource();
        public static int selected;

		public UpdatePage()
		{
			InitializeComponent();
		}

		private void cancel3Btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addScore3btn_Click(object sender, EventArgs e)
		{
			AddScore openAddWindow = new AddScore();
			openAddWindow.Show();
		}

		private void updateScoreBtn_Click(object sender, EventArgs e)
		{
			UpdateScore openUpdateWindow = new UpdateScore();
			openUpdateWindow.Show();
		}

        private void score3List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePage_Load(object sender, EventArgs e)
        {

        }
	}
}
