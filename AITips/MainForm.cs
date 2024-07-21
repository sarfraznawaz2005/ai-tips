using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using Microsoft.Win32;

/* TODO:
Something...
 */

namespace AITips
{
	public partial class MainForm : Form
	{
		private Timer tipTimer;
		private string apiKey;
		private string prompt;
		private int intervalMinutes;
		private NotifyIcon notifyIcon;

		public MainForm()
		{
			InitializeComponent();

			// Calculate 70% of the screen's width and height
			var screenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 0.7;
			var screenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 0.7;

			// Set the MainForm size
			this.Size = new System.Drawing.Size((int)screenWidth, (int)screenHeight);
			
			InitializeTrayIcon();
			LoadSettings();
			InitializeTimer();

			if (apiKey == "your_api_key_here")
			{
				var settingsForm = new SettingsForm(this);
				settingsForm.ShowDialog();
				LoadSettings(); // Reload settings after closing the settings form
			}
		}

		private void InitializeTrayIcon()
		{
			notifyIcon = new NotifyIcon
			{
				Visible = true,
				ContextMenu = new ContextMenu(new MenuItem[]
				                              {
				                              	new MenuItem("Show", ShowMainForm),
				                              	new MenuItem("Settings", ShowSettingsForm),
				                              	new MenuItem("Quit", QuitApplication)
				                              })
			};

			notifyIcon.Icon = new Icon("icon.ico");

			// Subscribe to the BalloonTipClicked event
			notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;

			// Subscribe to the MouseDoubleClick event
			notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
			notifyIcon.MouseClick += NotifyIcon_MouseClick;
		}

		private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			// Show the MainForm when the balloon tip is clicked
			this.Show();
			this.WindowState = FormWindowState.Normal; // Ensure the window is not minimized
		}

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			// Show the MainForm when the system tray icon is double-clicked
			this.Show();
			this.WindowState = FormWindowState.Normal; // Ensure the window is not minimized
		}

		private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			// Show the MainForm when the system tray icon is double-clicked
			this.Show();
			this.WindowState = FormWindowState.Normal; // Ensure the window is not minimized
		}

		private void InitializeTimer()
		{
			tipTimer = new Timer
			{
				Interval = intervalMinutes * 60 * 1000 // Convert minutes to milliseconds
			};

			tipTimer.Tick += async (s, e) => await FetchAndDisplayTip();
			tipTimer.Start();
		}
		
		private void DisplayTip(string tip)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(DisplayTip), tip);
				return;
			}
			
			// Replace \n with \r\n for proper new line display in Windows Forms
			tip = tip.Replace("\n", "\r\n");
			
			txtTip.Text = tip;
			
			notifyIcon.ShowBalloonTip(5000, "AI Tip", tip, ToolTipIcon.Info);
		}

		private async Task FetchAndDisplayTip()
		{
			try
			{
				string apiUrl = "https://generativelanguage.googleapis.com/v1/models/gemini-1.5-flash:generateContent?key=" + apiKey;

				prompt = prompt + "\n\n Please answer without using any markdown or HTML syntax, your answer must be pure text albeit you can use new lines and spaces to nicely format your answer. Make sure your answer is as detailed as possible.";

				var requestBody = new
				{
					contents = new[]
					{
						new { role = "user", parts = new[] { new { text = prompt } } }
					}
				};

				using (var client = new HttpClient())
				{
					client.DefaultRequestHeaders.Add("key", apiKey);
					
					var jsonContent = JsonConvert.SerializeObject(requestBody);
					var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
					var response = await client.PostAsync(apiUrl, content);
					var responseContent = await response.Content.ReadAsStringAsync();

					//DisplayTip(responseContent.ToString());
					
					var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseContent);

					if (apiResponse.candidates != null && apiResponse.candidates.Count > 0)
					{
						string tip = "";

						foreach (var part in apiResponse.candidates[0].content.parts)
						{
							tip += part.text;
						}

						DisplayTip(tip);
					}
				}
			}
			catch (Exception ex)
			{
				DisplayTip("Error fetching tip: " + ex.Message);
			}
		}

		private string ExtractTipFromResponse(ApiResponse response)
		{
			if (response.candidates != null && response.candidates.Count > 0)
			{
				var candidate = response.candidates[0];
				
				if (candidate.content != null && candidate.content.parts != null && candidate.content.parts.Count > 0)
				{
					string tip = "";

					foreach (var part in candidate.content.parts)
					{
						tip += part.text;
					}

					return tip;
				}
			}
			
			return "No tip available.";
		}

		

		private void LoadSettings()
		{
			// Load settings from the registry
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AITips");

			if (key != null)
			{
				apiKey = key.GetValue("ApiKey") as string ?? "your_api_key_here";
				prompt = key.GetValue("Prompt") as string ?? "your_prompt_here";
				intervalMinutes = Convert.ToInt32(key.GetValue("IntervalMinutes") ?? 60);
				key.Close();
			}
			else
			{
				apiKey = "your_api_key_here";
				prompt = "your_prompt_here";
				intervalMinutes = 60;
			}
		}

		public void SaveSettings()
		{
			// Save settings to the registry
			RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AITips");
			key.SetValue("ApiKey", apiKey);
			key.SetValue("Prompt", prompt);
			key.SetValue("IntervalMinutes", intervalMinutes);
			key.Close();
		}

		private void ShowMainForm(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void ShowSettingsForm(object sender, EventArgs e)
		{
			var settingsForm = new SettingsForm(this);
			settingsForm.ShowDialog();
			LoadSettings(); // Reload settings after closing the settings form
		}

		private void QuitApplication(object sender, EventArgs e)
		{
			SaveSettings(); // Save settings before quitting
			Application.Exit();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.Hide();
			}
			base.OnFormClosing(e);
		}

		public string ApiKey
		{
			get { return apiKey; }
			set { apiKey = value; }
		}

		public string Prompt
		{
			get { return prompt; }
			set { prompt = value; }
		}

		public int IntervalMinutes
		{
			get { return intervalMinutes; }
			set { intervalMinutes = value; }
		}
	}

	// Define the response structure according to the Gemini API response
	public class ApiResponse
	{
		public List<Candidate> candidates { get; set; }
	}

	public class Candidate
	{
		public Content content { get; set; }
	}

	public class Content
	{
		public List<Part> parts { get; set; }
	}

	public class Part
	{
		public string text { get; set; }
	}


}
