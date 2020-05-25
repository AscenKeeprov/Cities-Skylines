namespace Localizer.Forms
{
	partial class Form_Translate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Translate));
			this.DataGridView_Translation = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_Translation)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridView_Translation
			// 
			this.DataGridView_Translation.AllowUserToAddRows = false;
			this.DataGridView_Translation.AllowUserToDeleteRows = false;
			this.DataGridView_Translation.AllowUserToOrderColumns = true;
			this.DataGridView_Translation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView_Translation.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView_Translation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView_Translation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataGridView_Translation.GridColor = System.Drawing.SystemColors.Control;
			this.DataGridView_Translation.Location = new System.Drawing.Point(0, 0);
			this.DataGridView_Translation.Margin = new System.Windows.Forms.Padding(0);
			this.DataGridView_Translation.MinimumSize = new System.Drawing.Size(512, 0);
			this.DataGridView_Translation.Name = "DataGridView_Translation";
			this.DataGridView_Translation.Size = new System.Drawing.Size(1008, 473);
			this.DataGridView_Translation.TabIndex = 0;
			// 
			// Form_Translate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1008, 473);
			this.Controls.Add(this.DataGridView_Translation);
			this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(254)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form_Translate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cities Skylines Localizer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Translate_FormClosed);
			this.Load += new System.EventHandler(this.Form_Translate_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_Translation)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView DataGridView_Translation;
	}
}