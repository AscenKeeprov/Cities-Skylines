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
			this.Button_Start = new System.Windows.Forms.Button();
			this.RadioButton_OperationCreate = new System.Windows.Forms.RadioButton();
			this.GroupBox_ActionRadioButtons = new System.Windows.Forms.GroupBox();
			this.RadioButton_OperationEdit = new System.Windows.Forms.RadioButton();
			this.ComboBox_Language = new System.Windows.Forms.ComboBox();
			this.Label_LanguageComboBox = new System.Windows.Forms.Label();
			this.CheckBox_CompareToEN = new System.Windows.Forms.CheckBox();
			this.GroupBox_ActionRadioButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextBox_InstallPath
			// 
			this.TextBox_InstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
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
			this.Button_InstallPathBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
			this.Button_InstallPathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_InstallPathBrowse.Location = new System.Drawing.Point(400, 48);
			this.Button_InstallPathBrowse.Margin = new System.Windows.Forms.Padding(4);
			this.Button_InstallPathBrowse.Name = "Button_InstallPathBrowse";
			this.Button_InstallPathBrowse.Size = new System.Drawing.Size(80, 25);
			this.Button_InstallPathBrowse.TabIndex = 2;
			this.Button_InstallPathBrowse.Text = "Browse...";
			this.Button_InstallPathBrowse.UseVisualStyleBackColor = false;
			this.Button_InstallPathBrowse.Click += new System.EventHandler(this.Button_InstallPathBrowse_Click);
			this.Button_InstallPathBrowse.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
			this.Button_InstallPathBrowse.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
			this.Button_InstallPathBrowse.MouseHover += new System.EventHandler(this.Button_MouseHover);
			// 
			// Button_Start
			// 
			this.Button_Start.Enabled = false;
			this.Button_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
			this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Start.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Button_Start.Location = new System.Drawing.Point(216, 272);
			this.Button_Start.Margin = new System.Windows.Forms.Padding(4);
			this.Button_Start.Name = "Button_Start";
			this.Button_Start.Size = new System.Drawing.Size(80, 30);
			this.Button_Start.TabIndex = 9;
			this.Button_Start.Text = "Start";
			this.Button_Start.UseVisualStyleBackColor = false;
			this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
			this.Button_Start.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
			this.Button_Start.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
			this.Button_Start.MouseHover += new System.EventHandler(this.Button_MouseHover);
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
			this.GroupBox_ActionRadioButtons.Margin = new System.Windows.Forms.Padding(4);
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
			this.RadioButton_OperationEdit.Tag = "Edit";
			this.RadioButton_OperationEdit.Text = "Edit an existing translation";
			this.RadioButton_OperationEdit.UseVisualStyleBackColor = true;
			this.RadioButton_OperationEdit.CheckedChanged += new System.EventHandler(this.RadioButton_Operation_CheckedChanged);
			// 
			// ComboBox_Language
			// 
			this.ComboBox_Language.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ComboBox_Language.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ComboBox_Language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
			this.ComboBox_Language.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ComboBox_Language.DropDownHeight = 100;
			this.ComboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_Language.Enabled = false;
			this.ComboBox_Language.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ComboBox_Language.FormattingEnabled = true;
			this.ComboBox_Language.IntegralHeight = false;
			this.ComboBox_Language.Location = new System.Drawing.Point(128, 188);
			this.ComboBox_Language.Margin = new System.Windows.Forms.Padding(4);
			this.ComboBox_Language.MaxDropDownItems = 6;
			this.ComboBox_Language.Name = "ComboBox_Language";
			this.ComboBox_Language.Size = new System.Drawing.Size(176, 25);
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
			// CheckBox_CompareToEN
			// 
			this.CheckBox_CompareToEN.AutoSize = true;
			this.CheckBox_CompareToEN.Checked = true;
			this.CheckBox_CompareToEN.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox_CompareToEN.Enabled = false;
			this.CheckBox_CompareToEN.Location = new System.Drawing.Point(24, 240);
			this.CheckBox_CompareToEN.Margin = new System.Windows.Forms.Padding(4);
			this.CheckBox_CompareToEN.Name = "CheckBox_CompareToEN";
			this.CheckBox_CompareToEN.Size = new System.Drawing.Size(212, 21);
			this.CheckBox_CompareToEN.TabIndex = 8;
			this.CheckBox_CompareToEN.Text = "Compare with English translation";
			this.CheckBox_CompareToEN.UseVisualStyleBackColor = true;
			// 
			// Form_Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(496, 313);
			this.Controls.Add(this.CheckBox_CompareToEN);
			this.Controls.Add(this.Label_LanguageComboBox);
			this.Controls.Add(this.ComboBox_Language);
			this.Controls.Add(this.GroupBox_ActionRadioButtons);
			this.Controls.Add(this.Button_Start);
			this.Controls.Add(this.Button_InstallPathBrowse);
			this.Controls.Add(this.Label_InstallPathTextBox);
			this.Controls.Add(this.TextBox_InstallPath);
			this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(512, 352);
			this.MinimumSize = new System.Drawing.Size(512, 352);
			this.Name = "Form_Setup";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
		private System.Windows.Forms.Button Button_Start;
		private System.Windows.Forms.RadioButton RadioButton_OperationCreate;
		private System.Windows.Forms.GroupBox GroupBox_ActionRadioButtons;
		private System.Windows.Forms.RadioButton RadioButton_OperationEdit;
		private System.Windows.Forms.ComboBox ComboBox_Language;
		private System.Windows.Forms.Label Label_LanguageComboBox;
		private System.Windows.Forms.CheckBox CheckBox_CompareToEN;
	}
}

