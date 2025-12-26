namespace Code_Helper
{
	partial class Form_Create_CLass
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Create_CLass));
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.buttonAddField = new System.Windows.Forms.Button();
			this.buttonAddMethod = new System.Windows.Forms.Button();
			this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
			this.checkBoxDefaultConstructor = new System.Windows.Forms.CheckBox();
			this.checkBoxConstructor = new System.Windows.Forms.CheckBox();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.checkBoxAddCPP = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(159, 42);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 13;
			this.labelName.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(162, 58);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(117, 20);
			this.textBoxName.TabIndex = 12;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			// 
			// buttonAddField
			// 
			this.buttonAddField.Location = new System.Drawing.Point(12, 56);
			this.buttonAddField.Name = "buttonAddField";
			this.buttonAddField.Size = new System.Drawing.Size(82, 23);
			this.buttonAddField.TabIndex = 16;
			this.buttonAddField.Text = "AddField";
			this.buttonAddField.UseVisualStyleBackColor = true;
			this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
			// 
			// buttonAddMethod
			// 
			this.buttonAddMethod.Location = new System.Drawing.Point(390, 56);
			this.buttonAddMethod.Name = "buttonAddMethod";
			this.buttonAddMethod.Size = new System.Drawing.Size(82, 23);
			this.buttonAddMethod.TabIndex = 17;
			this.buttonAddMethod.Text = "AddMethod";
			this.buttonAddMethod.UseVisualStyleBackColor = true;
			this.buttonAddMethod.Click += new System.EventHandler(this.buttonAddMethod_Click);
			// 
			// richTextBoxResult
			// 
			this.richTextBoxResult.Location = new System.Drawing.Point(12, 85);
			this.richTextBoxResult.Name = "richTextBoxResult";
			this.richTextBoxResult.Size = new System.Drawing.Size(460, 364);
			this.richTextBoxResult.TabIndex = 18;
			this.richTextBoxResult.Text = "";
			// 
			// checkBoxDefaultConstructor
			// 
			this.checkBoxDefaultConstructor.AutoSize = true;
			this.checkBoxDefaultConstructor.Location = new System.Drawing.Point(13, 13);
			this.checkBoxDefaultConstructor.Name = "checkBoxDefaultConstructor";
			this.checkBoxDefaultConstructor.Size = new System.Drawing.Size(114, 17);
			this.checkBoxDefaultConstructor.TabIndex = 19;
			this.checkBoxDefaultConstructor.Text = "DefaultConstructor";
			this.checkBoxDefaultConstructor.UseVisualStyleBackColor = true;
			this.checkBoxDefaultConstructor.CheckedChanged += new System.EventHandler(this.checkBoxDefaultConstructor_CheckedChanged);
			// 
			// checkBoxConstructor
			// 
			this.checkBoxConstructor.AutoSize = true;
			this.checkBoxConstructor.Location = new System.Drawing.Point(133, 12);
			this.checkBoxConstructor.Name = "checkBoxConstructor";
			this.checkBoxConstructor.Size = new System.Drawing.Size(80, 17);
			this.checkBoxConstructor.TabIndex = 20;
			this.checkBoxConstructor.Text = "Constructor";
			this.checkBoxConstructor.UseVisualStyleBackColor = true;
			this.checkBoxConstructor.CheckedChanged += new System.EventHandler(this.checkBoxConstructor_CheckedChanged);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(397, 455);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(75, 23);
			this.buttonCopy.TabIndex = 21;
			this.buttonCopy.Text = "buffer";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBoxAddCPP
			// 
			this.checkBoxAddCPP.AutoSize = true;
			this.checkBoxAddCPP.Location = new System.Drawing.Point(219, 12);
			this.checkBoxAddCPP.Name = "checkBoxAddCPP";
			this.checkBoxAddCPP.Size = new System.Drawing.Size(139, 17);
			this.checkBoxAddCPP.TabIndex = 22;
			this.checkBoxAddCPP.Text = "Add cpp implementation";
			this.checkBoxAddCPP.UseVisualStyleBackColor = true;
			this.checkBoxAddCPP.CheckedChanged += new System.EventHandler(this.checkBoxAddCPP_CheckedChanged);
			// 
			// Form_Create_CLass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 484);
			this.Controls.Add(this.checkBoxAddCPP);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.checkBoxConstructor);
			this.Controls.Add(this.checkBoxDefaultConstructor);
			this.Controls.Add(this.richTextBoxResult);
			this.Controls.Add(this.buttonAddMethod);
			this.Controls.Add(this.buttonAddField);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Create_CLass";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Create_CLass";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonAddField;
		private System.Windows.Forms.Button buttonAddMethod;
		private System.Windows.Forms.RichTextBox richTextBoxResult;
		private System.Windows.Forms.CheckBox checkBoxDefaultConstructor;
		private System.Windows.Forms.CheckBox checkBoxConstructor;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.CheckBox checkBoxAddCPP;
	}
}