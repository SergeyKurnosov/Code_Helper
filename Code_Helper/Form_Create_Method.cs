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
	public partial class Form_Create_Method : Form
	{
		private Method method;
		private AccessModifier[] modifiers_array;
		private TypeData[] typeDatas_array;
		private bool Method_is_ready = false;
		public Form_Create_Method()
		{
			InitializeComponent();

			comboBoxAccessModifier.DataSource = Enum.GetNames(typeof(AccessModifier));
			modifiers_array = (AccessModifier[])Enum.GetValues(typeof(AccessModifier));
			comboBoxTypeData.DataSource = Enum.GetNames(typeof(TypeData));
			typeDatas_array = (TypeData[])Enum.GetValues(typeof(TypeData));

			method = new Method();
		}

		private void comboBoxAccessModifier_SelectedIndexChanged(object sender, EventArgs e)
		{
			method.accessModifier = modifiers_array[comboBoxAccessModifier.SelectedIndex];
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void comboBoxTypeData_SelectedIndexChanged(object sender, EventArgs e)
		{
			method.typeData = typeDatas_array[comboBoxTypeData.SelectedIndex];
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxName.Text))
			{
				method.name = textBoxName.Text;
				textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
			}
		}

		private void buttonAddParametr_Click(object sender, EventArgs e)
		{
			Form_Create_Variable form_Create_Variable = new Form_Create_Variable();
			form_Create_Variable.ShowDialog();
			method.parameters.Add(form_Create_Variable.GetVariable());
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagNone_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagNone.Checked)
			{
				checkBoxFlagStatic.Checked = checkBoxFlagVirtual.Checked =
					checkBoxFlagConst.Checked = checkBoxFlagOverride.Checked =
					checkBoxFlagFinal.Checked = false;

				method.modifiers = MethodModifiers.None;
			}
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagVirtual_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagVirtual.Checked)
				method.modifiers |= MethodModifiers.Virtual;
			else
				method.modifiers &= ~MethodModifiers.Virtual;
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagStatic_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagStatic.Checked)
				method.modifiers |= MethodModifiers.Static;
			else
				method.modifiers &= ~MethodModifiers.Static;
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagConst_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagConst.Checked)
				method.modifiers |= MethodModifiers.Const;
			else
				method.modifiers &= ~MethodModifiers.Const;
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagOverride_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagOverride.Checked)
				method.modifiers |= MethodModifiers.Override;
			else
				method.modifiers &= ~MethodModifiers.Override;
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void checkBoxFlagFinal_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxFlagFinal.Checked)
				method.modifiers |= MethodModifiers.Final;
			else
				method.modifiers &= ~MethodModifiers.Final;
			textBoxResult.Text = method.ToStringWithoutAccesModifier() + " ;";
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Method_is_ready = true;
			this.Close();
		}

		public Method GetMethod()
		{
			if (Method_is_ready)
				return method;
			else
				return null;
		}

		private void buttonCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(textBoxResult.Text);
			MessageBox.Show("The text has been copied to the clipboard.");
		}
	}
}
