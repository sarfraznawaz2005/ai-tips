namespace AITips
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Timer timeInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCopyToClipboard;

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
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.txtTip = new System.Windows.Forms.TextBox();
        	this.timeInterval = new System.Windows.Forms.Timer(this.components);
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.btnCopyToClipboard = new System.Windows.Forms.Button();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// txtTip
        	// 
        	this.txtTip.BackColor = System.Drawing.Color.Ivory;
        	this.txtTip.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.txtTip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtTip.Location = new System.Drawing.Point(8, 8);
        	this.txtTip.Margin = new System.Windows.Forms.Padding(8);
        	this.txtTip.Multiline = true;
        	this.txtTip.Name = "txtTip";
        	this.txtTip.ReadOnly = true;
        	this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.txtTip.Size = new System.Drawing.Size(1584, 768);
        	this.txtTip.TabIndex = 0;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1600F));
        	this.tableLayoutPanel1.Controls.Add(this.txtTip, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.btnCopyToClipboard, 0, 1);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 872);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// btnCopyToClipboard
        	// 
        	this.btnCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.btnCopyToClipboard.Location = new System.Drawing.Point(6, 790);
        	this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(6);
        	this.btnCopyToClipboard.Name = "btnCopyToClipboard";
        	this.btnCopyToClipboard.Size = new System.Drawing.Size(1588, 76);
        	this.btnCopyToClipboard.TabIndex = 1;
        	this.btnCopyToClipboard.Text = "Copy to Clipboard";
        	this.btnCopyToClipboard.UseVisualStyleBackColor = true;
        	this.btnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
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
        	this.Text = "AITips";
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel1.PerformLayout();
        	this.ResumeLayout(false);
        }

        private void BtnCopyToClipboard_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.txtTip.Text);
        }
    }
}