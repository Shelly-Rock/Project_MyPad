using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_WordPad
{
	public partial class FindReplaceForm : Form
	{

		public string FindText => txtFind.Text;
		public string ReplaceText => txtReplace.Text;
		public bool ReplaceAll => chkReplaceAll.Checked;
		public FindReplaceForm()
		{
			InitializeComponent();
		}

		private void FindReplaceForm_Load(object sender, EventArgs e)
		{

		}

		private void btn_Tim_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();

		}

		private void btn_ThayThe_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Close();
		}
	}
}
