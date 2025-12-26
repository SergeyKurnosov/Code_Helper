namespace Code_Helper
{
	partial class Form_Create_Method
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create_Method));
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelTypeData = new System.Windows.Forms.Label();
			this.comboBoxTypeData = new System.Windows.Forms.ComboBox();
			this.labelAccessModifier = new System.Windows.Forms.Label();
			this.comboBoxAccessModifier = new System.Windows.Forms.ComboBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.buttonAddParametr = new System.Windows.Forms.Button();
			this.checkBoxFlagOverride = new System.Windows.Forms.CheckBox();
			this.checkBoxFlagConst = new System.Windows.Forms.CheckBox();
			this.checkBoxFlagFinal = new System.Windows.Forms.CheckBox();
			this.checkBoxFlagStatic = new System.Windows.Forms.CheckBox();
			this.checkBoxFlagVirtual = new System.Windows.Forms.CheckBox();
			this.checkBoxFlagNone = new System.Windows.Forms.CheckBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(138, 57);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 11;
			this.labelName.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(141, 72);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(117, 20);
			this.textBoxName.TabIndex = 10;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			// 
			// labelTypeData
			// 
			this.labelTypeData.AutoSize = true;
			this.labelTypeData.Location = new System.Drawing.Point(134, 10);
			this.labelTypeData.Name = "labelTypeData";
			this.labelTypeData.Size = new System.Drawing.Size(54, 13);
			this.labelTypeData.TabIndex = 9;
			this.labelTypeData.Text = "TypeData";
			// 
			// comboBoxTypeData
			// 
			this.comboBoxTypeData.FormattingEnabled = true;
			this.comboBoxTypeData.Location = new System.Drawing.Point(137, 26);
			this.comboBoxTypeData.Name = "comboBoxTypeData";
			this.comboBoxTypeData.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTypeData.TabIndex = 8;
			this.comboBoxTypeData.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeData_SelectedIndexChanged);
			// 
			// labelAccessModifier
			// 
			this.labelAccessModifier.AutoSize = true;
			this.labelAccessModifier.Location = new System.Drawing.Point(7, 10);
			this.labelAccessModifier.Name = "labelAccessModifier";
			this.labelAccessModifier.Size = new System.Drawing.Size(79, 13);
			this.labelAccessModifier.TabIndex = 7;
			this.labelAccessModifier.Text = "AccessModifier";
			// 
			// comboBoxAccessModifier
			// 
			this.comboBoxAccessModifier.FormattingEnabled = true;
			this.comboBoxAccessModifier.Location = new System.Drawing.Point(7, 26);
			this.comboBoxAccessModifier.Name = "comboBoxAccessModifier";
			this.comboBoxAccessModifier.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccessModifier.TabIndex = 6;
			this.comboBoxAccessModifier.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccessModifier_SelectedIndexChanged);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(4, 163);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(37, 13);
			this.labelResult.TabIndex = 14;
			this.labelResult.Text = "Result";
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(7, 179);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(438, 20);
			this.textBoxResult.TabIndex = 13;
			// 
			// buttonAddParametr
			// 
			this.buttonAddParametr.Location = new System.Drawing.Point(10, 72);
			this.buttonAddParametr.Name = "buttonAddParametr";
			this.buttonAddParametr.Size = new System.Drawing.Size(82, 23);
			this.buttonAddParametr.TabIndex = 15;
			this.buttonAddParametr.Text = "AddParameter";
			this.buttonAddParametr.UseVisualStyleBackColor = true;
			this.buttonAddParametr.Click += new System.EventHandler(this.buttonAddParametr_Click);
			// 
			// checkBoxFlagOverride
			// 
			this.checkBoxFlagOverride.AutoSize = true;
			this.checkBoxFlagOverride.Location = new System.Drawing.Point(306, 72);
			this.checkBoxFlagOverride.Name = "checkBoxFlagOverride";
			this.checkBoxFlagOverride.Size = new System.Drawing.Size(66, 17);
			this.checkBoxFlagOverride.TabIndex = 16;
			this.checkBoxFlagOverride.Text = "Override";
			this.checkBoxFlagOverride.UseVisualStyleBackColor = true;
			this.checkBoxFlagOverride.CheckedChanged += new System.EventHandler(this.checkBoxFlagOverride_CheckedChanged);
			// 
			// checkBoxFlagConst
			// 
			this.checkBoxFlagConst.AutoSize = true;
			this.checkBoxFlagConst.Location = new System.Drawing.Point(392, 49);
			this.checkBoxFlagConst.Name = "checkBoxFlagConst";
			this.checkBoxFlagConst.Size = new System.Drawing.Size(53, 17);
			this.checkBoxFlagConst.TabIndex = 17;
			this.checkBoxFlagConst.Text = "Const";
			this.checkBoxFlagConst.UseVisualStyleBackColor = true;
			this.checkBoxFlagConst.CheckedChanged += new System.EventHandler(this.checkBoxFlagConst_CheckedChanged);
			// 
			// checkBoxFlagFinal
			// 
			this.checkBoxFlagFinal.AutoSize = true;
			this.checkBoxFlagFinal.Location = new System.Drawing.Point(392, 72);
			this.checkBoxFlagFinal.Name = "checkBoxFlagFinal";
			this.checkBoxFlagFinal.Size = new System.Drawing.Size(48, 17);
			this.checkBoxFlagFinal.TabIndex = 18;
			this.checkBoxFlagFinal.Text = "Final";
			this.checkBoxFlagFinal.UseVisualStyleBackColor = true;
			this.checkBoxFlagFinal.CheckedChanged += new System.EventHandler(this.checkBoxFlagFinal_CheckedChanged);
			// 
			// checkBoxFlagStatic
			// 
			this.checkBoxFlagStatic.AutoSize = true;
			this.checkBoxFlagStatic.Location = new System.Drawing.Point(392, 26);
			this.checkBoxFlagStatic.Name = "checkBoxFlagStatic";
			this.checkBoxFlagStatic.Size = new System.Drawing.Size(53, 17);
			this.checkBoxFlagStatic.TabIndex = 19;
			this.checkBoxFlagStatic.Text = "Static";
			this.checkBoxFlagStatic.UseVisualStyleBackColor = true;
			this.checkBoxFlagStatic.CheckedChanged += new System.EventHandler(this.checkBoxFlagStatic_CheckedChanged);
			// 
			// checkBoxFlagVirtual
			// 
			this.checkBoxFlagVirtual.AutoSize = true;
			this.checkBoxFlagVirtual.Location = new System.Drawing.Point(306, 49);
			this.checkBoxFlagVirtual.Name = "checkBoxFlagVirtual";
			this.checkBoxFlagVirtual.Size = new System.Drawing.Size(55, 17);
			this.checkBoxFlagVirtual.TabIndex = 20;
			this.checkBoxFlagVirtual.Text = "Virtual";
			this.checkBoxFlagVirtual.UseVisualStyleBackColor = true;
			this.checkBoxFlagVirtual.CheckedChanged += new System.EventHandler(this.checkBoxFlagVirtual_CheckedChanged);
			// 
			// checkBoxFlagNone
			// 
			this.checkBoxFlagNone.AutoSize = true;
			this.checkBoxFlagNone.Location = new System.Drawing.Point(306, 26);
			this.checkBoxFlagNone.Name = "checkBoxFlagNone";
			this.checkBoxFlagNone.Size = new System.Drawing.Size(52, 17);
			this.checkBoxFlagNone.TabIndex = 21;
			this.checkBoxFlagNone.Text = "None";
			this.checkBoxFlagNone.UseVisualStyleBackColor = true;
			this.checkBoxFlagNone.CheckedChanged += new System.EventHandler(this.checkBoxFlagNone_CheckedChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(183, 128);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 22;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(370, 150);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(75, 23);
			this.buttonCopy.TabIndex = 23;
			this.buttonCopy.Text = "buffer";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// Form_Create_Method
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 211);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkBoxFlagNone);
			this.Controls.Add(this.checkBoxFlagVirtual);
			this.Controls.Add(this.checkBoxFlagStatic);
			this.Controls.Add(this.checkBoxFlagFinal);
			this.Controls.Add(this.checkBoxFlagConst);
			this.Controls.Add(this.checkBoxFlagOverride);
			this.Controls.Add(this.buttonAddParametr);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelTypeData);
			this.Controls.Add(this.comboBoxTypeData);
			this.Controls.Add(this.labelAccessModifier);
			this.Controls.Add(this.comboBoxAccessModifier);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Create_Method";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Create_Method";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelTypeData;
		private System.Windows.Forms.ComboBox comboBoxTypeData;
		private System.Windows.Forms.Label labelAccessModifier;
		private System.Windows.Forms.ComboBox comboBoxAccessModifier;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Button buttonAddParametr;
		private System.Windows.Forms.CheckBox checkBoxFlagOverride;
		private System.Windows.Forms.CheckBox checkBoxFlagConst;
		private System.Windows.Forms.CheckBox checkBoxFlagFinal;
		private System.Windows.Forms.CheckBox checkBoxFlagStatic;
		private System.Windows.Forms.CheckBox checkBoxFlagVirtual;
		private System.Windows.Forms.CheckBox checkBoxFlagNone;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCopy;
	}
}