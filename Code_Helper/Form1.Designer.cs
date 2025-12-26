namespace Code_Helper
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonCC = new System.Windows.Forms.Button();
			this.buttonCM = new System.Windows.Forms.Button();
			this.buttonCV = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Code_Helper.Properties.Resources.e9d40d26810225_5635acac91f14;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(484, 249);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonCC
			// 
			this.buttonCC.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCC.Location = new System.Drawing.Point(12, 268);
			this.buttonCC.Name = "buttonCC";
			this.buttonCC.Size = new System.Drawing.Size(460, 23);
			this.buttonCC.TabIndex = 1;
			this.buttonCC.Text = "Create Class";
			this.buttonCC.UseVisualStyleBackColor = true;
			this.buttonCC.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonCM
			// 
			this.buttonCM.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCM.Location = new System.Drawing.Point(12, 297);
			this.buttonCM.Name = "buttonCM";
			this.buttonCM.Size = new System.Drawing.Size(460, 23);
			this.buttonCM.TabIndex = 2;
			this.buttonCM.Text = "Create Method";
			this.buttonCM.UseVisualStyleBackColor = true;
			this.buttonCM.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonCV
			// 
			this.buttonCV.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCV.Location = new System.Drawing.Point(12, 326);
			this.buttonCV.Name = "buttonCV";
			this.buttonCV.Size = new System.Drawing.Size(460, 23);
			this.buttonCV.TabIndex = 3;
			this.buttonCV.Text = "Create Variable";
			this.buttonCV.UseVisualStyleBackColor = true;
			this.buttonCV.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.buttonCV);
			this.Controls.Add(this.buttonCM);
			this.Controls.Add(this.buttonCC);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.75D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CodeHelper";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonCC;
		private System.Windows.Forms.Button buttonCM;
		private System.Windows.Forms.Button buttonCV;
	}
}

