namespace Localizer
{
	partial class Form_InstallPathSelect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InstallPathSelect));
			this.TextBox_InstallPath = new System.Windows.Forms.TextBox();
			this.Label_InstallPathTextBox = new System.Windows.Forms.Label();
			this.Button_InstallPathBrowse = new System.Windows.Forms.Button();
			this.Button_InstallPathNext = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBox_InstallPath
			// 
			this.TextBox_InstallPath.BackColor = System.Drawing.Color.Ivory;
			this.TextBox_InstallPath.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBox_InstallPath.Location = new System.Drawing.Point(16, 48);
			this.TextBox_InstallPath.Margin = new System.Windows.Forms.Padding(4);
			this.TextBox_InstallPath.Name = "TextBox_InstallPath";
			this.TextBox_InstallPath.ReadOnly = true;
			this.TextBox_InstallPath.Size = new System.Drawing.Size(368, 25);
			this.TextBox_InstallPath.TabIndex = 1;
			this.TextBox_InstallPath.WordWrap = false;
			this.TextBox_InstallPath.TextChanged += new System.EventHandler(this.TextBox_InstallPath_TextChanged);
			// 
			// Label_InstallPathTextBox
			// 
			this.Label_InstallPathTextBox.AutoSize = true;
			this.Label_InstallPathTextBox.Location = new System.Drawing.Point(16, 16);
			this.Label_InstallPathTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Label_InstallPathTextBox.Name = "Label_InstallPathTextBox";
			this.Label_InstallPathTextBox.Size = new System.Drawing.Size(325, 17);
			this.Label_InstallPathTextBox.TabIndex = 0;
			this.Label_InstallPathTextBox.Text = "Please select the folder where Cities: Skylines is installed:";
			// 
			// Button_InstallPathBrowse
			// 
			this.Button_InstallPathBrowse.Location = new System.Drawing.Point(400, 48);
			this.Button_InstallPathBrowse.Margin = new System.Windows.Forms.Padding(4);
			this.Button_InstallPathBrowse.Name = "Button_InstallPathBrowse";
			this.Button_InstallPathBrowse.Size = new System.Drawing.Size(80, 24);
			this.Button_InstallPathBrowse.TabIndex = 2;
			this.Button_InstallPathBrowse.Text = "Browse...";
			this.Button_InstallPathBrowse.UseVisualStyleBackColor = true;
			this.Button_InstallPathBrowse.Click += new System.EventHandler(this.Button_InstallPathBrowse_Click);
			// 
			// Button_InstallPathNext
			// 
			this.Button_InstallPathNext.Enabled = false;
			this.Button_InstallPathNext.Location = new System.Drawing.Point(412, 176);
			this.Button_InstallPathNext.Margin = new System.Windows.Forms.Padding(4);
			this.Button_InstallPathNext.Name = "Button_InstallPathNext";
			this.Button_InstallPathNext.Size = new System.Drawing.Size(64, 24);
			this.Button_InstallPathNext.TabIndex = 3;
			this.Button_InstallPathNext.Text = "Next >";
			this.Button_InstallPathNext.UseVisualStyleBackColor = true;
			this.Button_InstallPathNext.Click += new System.EventHandler(this.Button_InstallPathNext_Click);
			// 
			// Form_InstallPathSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(496, 217);
			this.Controls.Add(this.Button_InstallPathNext);
			this.Controls.Add(this.Button_InstallPathBrowse);
			this.Controls.Add(this.Label_InstallPathTextBox);
			this.Controls.Add(this.TextBox_InstallPath);
			this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_InstallPathSelect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cities Skylines Localizer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_InstallPathSelect_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_InstallPathSelect_FormClosed);
			this.Load += new System.EventHandler(this.Form_InstallPathSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox_InstallPath;
		private System.Windows.Forms.Label Label_InstallPathTextBox;
		private System.Windows.Forms.Button Button_InstallPathBrowse;
		private System.Windows.Forms.Button Button_InstallPathNext;
	}
}

