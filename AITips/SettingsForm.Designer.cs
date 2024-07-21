namespace AITips
{
	partial class SettingsForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblApiKey;
		private System.Windows.Forms.TextBox txtApiKey;
		private System.Windows.Forms.Label lblPrompt;
		private System.Windows.Forms.TextBox txtPrompt;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.NumericUpDown numInterval;
		private System.Windows.Forms.Button btnSave;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.lblApiKey = new System.Windows.Forms.Label();
			this.txtApiKey = new System.Windows.Forms.TextBox();
			this.lblPrompt = new System.Windows.Forms.Label();
			this.txtPrompt = new System.Windows.Forms.TextBox();
			this.lblInterval = new System.Windows.Forms.Label();
			this.numInterval = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// lblApiKey
			// 
			this.lblApiKey.AutoSize = true;
			this.lblApiKey.Location = new System.Drawing.Point(32, 21);
			this.lblApiKey.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lblApiKey.Name = "lblApiKey";
			this.lblApiKey.Size = new System.Drawing.Size(116, 32);
			this.lblApiKey.TabIndex = 0;
			this.lblApiKey.Text = "API Key";
			// 
			// txtApiKey
			// 
			this.txtApiKey.Location = new System.Drawing.Point(32, 79);
			this.txtApiKey.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.txtApiKey.Name = "txtApiKey";
			this.txtApiKey.Size = new System.Drawing.Size(1060, 38);
			this.txtApiKey.TabIndex = 1;
			// 
			// lblPrompt
			// 
			this.lblPrompt.AutoSize = true;
			this.lblPrompt.Location = new System.Drawing.Point(32, 164);
			this.lblPrompt.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lblPrompt.Name = "lblPrompt";
			this.lblPrompt.Size = new System.Drawing.Size(106, 32);
			this.lblPrompt.TabIndex = 2;
			this.lblPrompt.Text = "Prompt";
			// 
			// txtPrompt
			// 
			this.txtPrompt.Location = new System.Drawing.Point(32, 226);
			this.txtPrompt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.txtPrompt.Multiline = true;
			this.txtPrompt.Name = "txtPrompt";
			this.txtPrompt.Size = new System.Drawing.Size(1060, 185);
			this.txtPrompt.TabIndex = 3;
			// 
			// lblInterval
			// 
			this.lblInterval.AutoSize = true;
			this.lblInterval.Location = new System.Drawing.Point(32, 456);
			this.lblInterval.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(263, 32);
			this.lblInterval.TabIndex = 4;
			this.lblInterval.Text = "Interval (in minutes)";
			// 
			// numInterval
			// 
			this.numInterval.Location = new System.Drawing.Point(32, 516);
			this.numInterval.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.numInterval.Name = "numInterval";
			this.numInterval.Size = new System.Drawing.Size(1067, 38);
			this.numInterval.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(32, 621);
			this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(1067, 95);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 754);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.numInterval);
			this.Controls.Add(this.lblInterval);
			this.Controls.Add(this.txtPrompt);
			this.Controls.Add(this.lblPrompt);
			this.Controls.Add(this.txtApiKey);
			this.Controls.Add(this.lblApiKey);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
