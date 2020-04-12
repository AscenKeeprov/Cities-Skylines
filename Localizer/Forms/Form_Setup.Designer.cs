namespace Localizer
{
	partial class Form_Setup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setup));
			this.TextBox_InstallPath = new System.Windows.Forms.TextBox();
			this.Label_InstallPathTextBox = new System.Windows.Forms.Label();
			this.Button_InstallPathBrowse = new System.Windows.Forms.Button();
			this.Button_InstallPathNext = new System.Windows.Forms.Button();
			this.RadioButton_OperationCreate = new System.Windows.Forms.RadioButton();
			this.GroupBox_ActionRadioButtons = new System.Windows.Forms.GroupBox();
			this.RadioButton_OperationEdit = new System.Windows.Forms.RadioButton();
			this.ComboBox_Language = new System.Windows.Forms.ComboBox();
			this.Label_LanguageComboBox = new System.Windows.Forms.Label();
			this.GroupBox_ActionRadioButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextBox_InstallPath
			// 
			this.TextBox_InstallPath.BackColor = System.Drawing.Color.Ivory;
			this.TextBox_InstallPath.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBox_InstallPath.Location = new System.Drawing.Point(16, 48);
			this.TextBox_InstallPath.Margin = new System.Windows.Forms.Padding(4);
			this.TextBox_InstallPath.MaxLength = 260;
			this.TextBox_InstallPath.Name = "TextBox_InstallPath";
			this.TextBox_InstallPath.ReadOnly = true;
			this.TextBox_InstallPath.Size = new System.Drawing.Size(375, 25);
			this.TextBox_InstallPath.TabIndex = 1;
			this.TextBox_InstallPath.WordWrap = false;
			this.TextBox_InstallPath.TextChanged += new System.EventHandler(this.TextBox_InstallPath_TextChanged);
			// 
			// Label_InstallPathTextBox
			// 
			this.Label_InstallPathTextBox.AutoSize = true;
			this.Label_InstallPathTextBox.Location = new System.Drawing.Point(16, 24);
			this.Label_InstallPathTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Label_InstallPathTextBox.Name = "Label_InstallPathTextBox";
			this.Label_InstallPathTextBox.Size = new System.Drawing.Size(287, 17);
			this.Label_InstallPathTextBox.TabIndex = 0;
			this.Label_InstallPathTextBox.Text = "Select the folder where Cities: Skylines is installed:";
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
			this.Button_InstallPathNext.Location = new System.Drawing.Point(412, 432);
			this.Button_InstallPathNext.Margin = new System.Windows.Forms.Padding(4);
			this.Button_InstallPathNext.Name = "Button_InstallPathNext";
			this.Button_InstallPathNext.Size = new System.Drawing.Size(64, 24);
			this.Button_InstallPathNext.TabIndex = 13;
			this.Button_InstallPathNext.Text = "Next >";
			this.Button_InstallPathNext.UseVisualStyleBackColor = true;
			this.Button_InstallPathNext.Click += new System.EventHandler(this.Button_InstallPathNext_Click);
			// 
			// RadioButton_OperationCreate
			// 
			this.RadioButton_OperationCreate.AutoSize = true;
			this.RadioButton_OperationCreate.CausesValidation = false;
			this.RadioButton_OperationCreate.Location = new System.Drawing.Point(16, 24);
			this.RadioButton_OperationCreate.Margin = new System.Windows.Forms.Padding(4);
			this.RadioButton_OperationCreate.Name = "RadioButton_OperationCreate";
			this.RadioButton_OperationCreate.Size = new System.Drawing.Size(165, 21);
			this.RadioButton_OperationCreate.TabIndex = 4;
			this.RadioButton_OperationCreate.TabStop = true;
			this.RadioButton_OperationCreate.Tag = "Create";
			this.RadioButton_OperationCreate.Text = "Create a new translation";
			this.RadioButton_OperationCreate.UseVisualStyleBackColor = true;
			this.RadioButton_OperationCreate.CheckedChanged += new System.EventHandler(this.RadioButton_Operation_CheckedChanged);
			// 
			// GroupBox_ActionRadioButtons
			// 
			this.GroupBox_ActionRadioButtons.Controls.Add(this.RadioButton_OperationEdit);
			this.GroupBox_ActionRadioButtons.Controls.Add(this.RadioButton_OperationCreate);
			this.GroupBox_ActionRadioButtons.Enabled = false;
			this.GroupBox_ActionRadioButtons.Location = new System.Drawing.Point(16, 92);
			this.GroupBox_ActionRadioButtons.Name = "GroupBox_ActionRadioButtons";
			this.GroupBox_ActionRadioButtons.Size = new System.Drawing.Size(464, 80);
			this.GroupBox_ActionRadioButtons.TabIndex = 3;
			this.GroupBox_ActionRadioButtons.TabStop = false;
			this.GroupBox_ActionRadioButtons.Text = "What do you want to do?";
			// 
			// RadioButton_OperationEdit
			// 
			this.RadioButton_OperationEdit.AutoSize = true;
			this.RadioButton_OperationEdit.CausesValidation = false;
			this.RadioButton_OperationEdit.Location = new System.Drawing.Point(16, 48);
			this.RadioButton_OperationEdit.Margin = new System.Windows.Forms.Padding(4);
			this.RadioButton_OperationEdit.Name = "RadioButton_OperationEdit";
			this.RadioButton_OperationEdit.Size = new System.Drawing.Size(175, 21);
			this.RadioButton_OperationEdit.TabIndex = 5;
			this.RadioButton_OperationEdit.TabStop = true;
			this.RadioButton_OperationEdit.Tag = "Edit";
			this.RadioButton_OperationEdit.Text = "Edit an existing translation";
			this.RadioButton_OperationEdit.UseVisualStyleBackColor = true;
			this.RadioButton_OperationEdit.CheckedChanged += new System.EventHandler(this.RadioButton_Operation_CheckedChanged);
			// 
			// ComboBox_Language
			// 
			this.ComboBox_Language.Enabled = false;
			this.ComboBox_Language.FormattingEnabled = true;
			this.ComboBox_Language.Location = new System.Drawing.Point(128, 188);
			this.ComboBox_Language.Margin = new System.Windows.Forms.Padding(4);
			this.ComboBox_Language.Name = "ComboBox_Language";
			this.ComboBox_Language.Size = new System.Drawing.Size(128, 25);
			this.ComboBox_Language.TabIndex = 7;
			// 
			// Label_LanguageComboBox
			// 
			this.Label_LanguageComboBox.AutoSize = true;
			this.Label_LanguageComboBox.Location = new System.Drawing.Point(16, 192);
			this.Label_LanguageComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Label_LanguageComboBox.Name = "Label_LanguageComboBox";
			this.Label_LanguageComboBox.Size = new System.Drawing.Size(107, 17);
			this.Label_LanguageComboBox.TabIndex = 6;
			this.Label_LanguageComboBox.Text = "Choose language:";
			// 
			// Form_Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(496, 473);
			this.Controls.Add(this.Label_LanguageComboBox);
			this.Controls.Add(this.ComboBox_Language);
			this.Controls.Add(this.GroupBox_ActionRadioButtons);
			this.Controls.Add(this.Button_InstallPathNext);
			this.Controls.Add(this.Button_InstallPathBrowse);
			this.Controls.Add(this.Label_InstallPathTextBox);
			this.Controls.Add(this.TextBox_InstallPath);
			this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_Setup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cities Skylines Localizer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Setup_FormClosed);
			this.Load += new System.EventHandler(this.Form_Setup_Load);
			this.GroupBox_ActionRadioButtons.ResumeLayout(false);
			this.GroupBox_ActionRadioButtons.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox_InstallPath;
		private System.Windows.Forms.Label Label_InstallPathTextBox;
		private System.Windows.Forms.Button Button_InstallPathBrowse;
		private System.Windows.Forms.Button Button_InstallPathNext;
		private System.Windows.Forms.RadioButton RadioButton_OperationCreate;
		private System.Windows.Forms.GroupBox GroupBox_ActionRadioButtons;
		private System.Windows.Forms.RadioButton RadioButton_OperationEdit;
		private System.Windows.Forms.ComboBox ComboBox_Language;
		private System.Windows.Forms.Label Label_LanguageComboBox;
	}
}

