using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Helper
{
	public partial class CPP : Form
	{
		public CPP()
		{
			InitializeComponent();
		}

		private void buttonCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(richTextBoxResult.Text);
			MessageBox.Show("The text has been copied to the clipboard.");
			this.Close();
		}

		public void addText(string text)
		{
			richTextBoxResult.Text = text;
		}
	}
}
