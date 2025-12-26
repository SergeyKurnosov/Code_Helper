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
	public partial class Form1 : Form
	{
		Form_Create_Variable form_Create_Variable = new Form_Create_Variable();
		Form_Create_Method create_Method = new Form_Create_Method();
		Form_Create_CLass create_CLass = new Form_Create_CLass();

		public Form1()
		{
			InitializeComponent();		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			create_CLass.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			create_Method.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			form_Create_Variable.ShowDialog();
		}
	}
}
