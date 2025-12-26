namespace Code_Helper
{
	partial class CPP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPP));
			this.buttonCopy = new System.Windows.Forms.Button();
			this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(397, 382);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(75, 23);
			this.buttonCopy.TabIndex = 23;
			this.buttonCopy.Text = "buffer";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// richTextBoxResult
			// 
			this.richTextBoxResult.Location = new System.Drawing.Point(12, 12);
			this.richTextBoxResult.Name = "richTextBoxResult";
			this.richTextBoxResult.Size = new System.Drawing.Size(460, 364);
			this.richTextBoxResult.TabIndex = 22;
			this.richTextBoxResult.Text = "";
			// 
			// CPP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 412);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.richTextBoxResult);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CPP";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CPP";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.RichTextBox richTextBoxResult;
	}
}