namespace AITips
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnCopyToClipboard;
		private System.Windows.Forms.Button btnSaveToFile;
		private System.Windows.Forms.TextBox txtTip;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtTip = new System.Windows.Forms.TextBox();
			this.btnCopyToClipboard = new System.Windows.Forms.Button();
			this.btnSaveToFile = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.txtTip, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCopyToClipboard, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnSaveToFile, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 872);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtTip
			// 
			this.txtTip.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.SetColumnSpan(this.txtTip, 2);
			this.txtTip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.txtTip.Location = new System.Drawing.Point(3, 3);
			this.txtTip.Multiline = true;
			this.txtTip.Name = "txtTip";
			this.txtTip.ReadOnly = true;
			this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTip.Size = new System.Drawing.Size(1594, 778);
			this.txtTip.TabIndex = 0;
			// 
			// btnCopyToClipboard
			// 
			this.btnCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCopyToClipboard.Location = new System.Drawing.Point(3, 787);
			this.btnCopyToClipboard.Name = "btnCopyToClipboard";
			this.btnCopyToClipboard.Size = new System.Drawing.Size(794, 82);
			this.btnCopyToClipboard.TabIndex = 1;
			this.btnCopyToClipboard.Text = "Copy to Clipboard";
			this.btnCopyToClipboard.UseVisualStyleBackColor = false;
			this.btnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
			// 
			// btnSaveToFile
			// 
			this.btnSaveToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSaveToFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSaveToFile.Location = new System.Drawing.Point(803, 787);
			this.btnSaveToFile.Name = "btnSaveToFile";
			this.btnSaveToFile.Size = new System.Drawing.Size(794, 82);
			this.btnSaveToFile.TabIndex = 2;
			this.btnSaveToFile.Text = "Save to File";
			this.btnSaveToFile.UseVisualStyleBackColor = false;
			this.btnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 872);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AI-Tips";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
	}
}