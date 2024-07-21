using System;
using System.Windows.Forms;

namespace AITips
{
	public partial class SettingsForm : Form
	{
		private MainForm mainForm;

		public SettingsForm(MainForm form)
		{
			InitializeComponent();
			mainForm = form;
			LoadSettings();
		}

		private void LoadSettings()
		{
			txtApiKey.Text = mainForm.ApiKey;
			txtPrompt.Text = mainForm.Prompt;
			numInterval.Value = mainForm.IntervalMinutes;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			mainForm.ApiKey = txtApiKey.Text;
			mainForm.Prompt = txtPrompt.Text;
			mainForm.IntervalMinutes = (int)numInterval.Value;
			mainForm.SaveSettings();
			this.Close();
		}
	}
}
