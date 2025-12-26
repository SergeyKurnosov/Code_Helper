namespace Code_Helper
{
	partial class Form_Create_Variable
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create_Variable));
			this.comboBoxAccessModifier = new System.Windows.Forms.ComboBox();
			this.labelAccessModifier = new System.Windows.Forms.Label();
			this.labelTypeData = new System.Windows.Forms.Label();
			this.comboBoxTypeData = new System.Windows.Forms.ComboBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelValue = new System.Windows.Forms.Label();
			this.textBoxValue = new System.Windows.Forms.TextBox();
			this.labelArraySize = new System.Windows.Forms.Label();
			this.textBoxArraySize = new System.Windows.Forms.TextBox();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.checkBoxIsArray = new System.Windows.Forms.CheckBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxAccessModifier
			// 
			this.comboBoxAccessModifier.FormattingEnabled = true;
			this.comboBoxAccessModifier.Location = new System.Drawing.Point(12, 25);
			this.comboBoxAccessModifier.Name = "comboBoxAccessModifier";
			this.comboBoxAccessModifier.Size = new System.Drawing.Size(121, 21);
			this.comboBoxAccessModifier.TabIndex = 0;
			this.comboBoxAccessModifier.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccessModifier_SelectedIndexChanged);
			// 
			// labelAccessModifier
			// 
			this.labelAccessModifier.AutoSize = true;
			this.labelAccessModifier.Location = new System.Drawing.Point(12, 9);
			this.labelAccessModifier.Name = "labelAccessModifier";
			this.labelAccessModifier.Size = new System.Drawing.Size(79, 13);
			this.labelAccessModifier.TabIndex = 1;
			this.labelAccessModifier.Text = "AccessModifier";
			// 
			// labelTypeData
			// 
			this.labelTypeData.AutoSize = true;
			this.labelTypeData.Location = new System.Drawing.Point(139, 9);
			this.labelTypeData.Name = "labelTypeData";
			this.labelTypeData.Size = new System.Drawing.Size(54, 13);
			this.labelTypeData.TabIndex = 3;
			this.labelTypeData.Text = "TypeData";
			// 
			// comboBoxTypeData
			// 
			this.comboBoxTypeData.FormattingEnabled = true;
			this.comboBoxTypeData.Location = new System.Drawing.Point(142, 25);
			this.comboBoxTypeData.Name = "comboBoxTypeData";
			this.comboBoxTypeData.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTypeData.TabIndex = 2;
			this.comboBoxTypeData.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeData_SelectedIndexChanged);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(269, 25);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(117, 20);
			this.textBoxName.TabIndex = 4;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(266, 10);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Name";
			// 
			// labelValue
			// 
			this.labelValue.AutoSize = true;
			this.labelValue.Location = new System.Drawing.Point(12, 56);
			this.labelValue.Name = "labelValue";
			this.labelValue.Size = new System.Drawing.Size(34, 13);
			this.labelValue.TabIndex = 7;
			this.labelValue.Text = "Value";
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(12, 72);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(314, 20);
			this.textBoxValue.TabIndex = 6;
			this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
			// 
			// labelArraySize
			// 
			this.labelArraySize.AutoSize = true;
			this.labelArraySize.Location = new System.Drawing.Point(332, 56);
			this.labelArraySize.Name = "labelArraySize";
			this.labelArraySize.Size = new System.Drawing.Size(54, 13);
			this.labelArraySize.TabIndex = 10;
			this.labelArraySize.Text = "Array Size";
			this.labelArraySize.Visible = false;
			// 
			// textBoxArraySize
			// 
			this.textBoxArraySize.Location = new System.Drawing.Point(332, 72);
			this.textBoxArraySize.Name = "textBoxArraySize";
			this.textBoxArraySize.Size = new System.Drawing.Size(121, 20);
			this.textBoxArraySize.TabIndex = 9;
			this.textBoxArraySize.Visible = false;
			this.textBoxArraySize.TextChanged += new System.EventHandler(this.textBoxArraySize_TextChanged);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(15, 179);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(438, 20);
			this.textBoxResult.TabIndex = 11;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(12, 163);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(37, 13);
			this.labelResult.TabIndex = 12;
			this.labelResult.Text = "Result";
			// 
			// checkBoxIsArray
			// 
			this.checkBoxIsArray.AutoSize = true;
			this.checkBoxIsArray.Location = new System.Drawing.Point(392, 27);
			this.checkBoxIsArray.Name = "checkBoxIsArray";
			this.checkBoxIsArray.Size = new System.Drawing.Size(61, 17);
			this.checkBoxIsArray.TabIndex = 13;
			this.checkBoxIsArray.Text = "Is Array";
			this.checkBoxIsArray.UseVisualStyleBackColor = true;
			this.checkBoxIsArray.CheckedChanged += new System.EventHandler(this.checkBoxIsArray_CheckedChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(188, 129);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 14;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(378, 150);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(75, 23);
			this.buttonCopy.TabIndex = 22;
			this.buttonCopy.Text = "buffer";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// Form_Create_Variable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 211);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkBoxIsArray);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.labelArraySize);
			this.Controls.Add(this.textBoxArraySize);
			this.Controls.Add(this.labelValue);
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelTypeData);
			this.Controls.Add(this.comboBoxTypeData);
			this.Controls.Add(this.labelAccessModifier);
			this.Controls.Add(this.comboBoxAccessModifier);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Create_Variable";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Create_Variable";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxAccessModifier;
		private System.Windows.Forms.Label labelAccessModifier;
		private System.Windows.Forms.Label labelTypeData;
		private System.Windows.Forms.ComboBox comboBoxTypeData;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelValue;
		private System.Windows.Forms.TextBox textBoxValue;
		private System.Windows.Forms.Label labelArraySize;
		private System.Windows.Forms.TextBox textBoxArraySize;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.CheckBox checkBoxIsArray;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCopy;
	}
}