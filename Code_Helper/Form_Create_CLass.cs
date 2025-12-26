using Code_Helper.Language_packs.C__;
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
	public partial class Form_Create_CLass : Form
	{
		private Class Class;
		public Form_Create_CLass()
		{
			InitializeComponent();
			Class = new Class();
		}

		private void buttonAddField_Click(object sender, EventArgs e)
		{
			Form_Create_Variable form_Create_Variable = new Form_Create_Variable();
			form_Create_Variable.ShowDialog();
			Variable newField = form_Create_Variable.GetVariable();
			if (newField != null)
				Class.AddField(newField);
			richTextBoxResult.Text = Class.ToString();
		}

		private void buttonAddMethod_Click(object sender, EventArgs e)
		{
			Form_Create_Method form_Create_Method = new Form_Create_Method();
			form_Create_Method.ShowDialog();
			Method newMethod = form_Create_Method.GetMethod();
			if (newMethod != null)
				Class.AddMethod(newMethod);
			richTextBoxResult.Text = Class.ToString();
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxName.Text))
			{
				Class.name = textBoxName.Text;
				richTextBoxResult.Text = Class.ToString();
			}
		}

		private void checkBoxDefaultConstructor_CheckedChanged(object sender, EventArgs e)
		{
			Class.defaultConstructor = checkBoxDefaultConstructor.Checked;
			richTextBoxResult.Text = Class.ToString();
		}

		private void checkBoxConstructor_CheckedChanged(object sender, EventArgs e)
		{
			Class.constructor = checkBoxConstructor.Checked;
			richTextBoxResult.Text = Class.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(richTextBoxResult.Text);
			MessageBox.Show("The text has been copied to the clipboard.");
		}

		private void checkBoxAddCPP_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAddCPP.Checked)
			{
				CPP cPP = new CPP();
				cPP.addText(Class.ToString_cpp());
				cPP.Show();
			}
			else
			{
				richTextBoxResult.Text = "";
			}
		}
	}
}
