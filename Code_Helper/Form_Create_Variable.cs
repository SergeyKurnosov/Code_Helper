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
	public partial class Form_Create_Variable : Form
	{
		private Variable variable;
		private AccessModifier[] modifiers_array;
		private TypeData[] typeDatas_array;
		private bool Variable_is_Ready = false;
		public Form_Create_Variable()
		{
			InitializeComponent();

			comboBoxAccessModifier.DataSource = Enum.GetNames(typeof(AccessModifier));
			modifiers_array = (AccessModifier[])Enum.GetValues(typeof(AccessModifier));
			comboBoxTypeData.DataSource = Enum.GetNames(typeof(TypeData));
			typeDatas_array = (TypeData[])Enum.GetValues(typeof(TypeData));

			variable = new Variable();
		}

		private void checkBoxIsArray_CheckedChanged(object sender, EventArgs e)
		{
			labelArraySize.Visible = checkBoxIsArray.Checked;
			textBoxArraySize.Visible = checkBoxIsArray.Checked;
			variable.isArray = checkBoxIsArray.Checked;
			textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
		}

		private void comboBoxAccessModifier_SelectedIndexChanged(object sender, EventArgs e)
		{
			variable.modifier = modifiers_array[comboBoxAccessModifier.SelectedIndex];
			textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
		}

		private void comboBoxTypeData_SelectedIndexChanged(object sender, EventArgs e)
		{
			variable.typeData = typeDatas_array[comboBoxTypeData.SelectedIndex];
			textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxName.Text))
			{
				variable.name = textBoxName.Text;
				textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
			}
		}

		private void textBoxValue_TextChanged(object sender, EventArgs e)
		{
			variable.value = textBoxValue.Text;
			textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
		}

		private void textBoxArraySize_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxArraySize.Text))
			{
				variable.arraySize = Convert.ToInt32(textBoxArraySize.Text);
				textBoxResult.Text = variable.ToStringWithAccesModifier() + " ;";
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Variable_is_Ready = true;
			this.Close();
		}


		public Variable GetVariable()
		{
			if (Variable_is_Ready)
				return variable;
			return null;
		}

		private void buttonCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(textBoxResult.Text);
			MessageBox.Show("The text has been copied to the clipboard.");
		}
	}
}
