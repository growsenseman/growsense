using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Memory;
using MetroSuite;
using Microsoft.Win32;

namespace TrainerBase
{
	public partial class TrainerBase : Form
	{
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

		public TrainerBase()
		{
			this.InitializeComponent();
			int UniqueHotkeyId = 1;
			int HotKeyCode = 112;
			bool F1Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId, 0, HotKeyCode);
			int UniqueHotkeyId2 = 2;
			int HotKeyCode2 = 113;
			bool F2Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId2, 0, HotKeyCode2);
			int UniqueHotkeyId3 = 3;
			int HotKeyCode3 = 114;
			bool F3Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId3, 0, HotKeyCode3);
			int UniqueHotkeyId4 = 4;
			int HotKeyCode4 = 115;
			bool F4Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId4, 0, HotKeyCode4);
			int UniqueHotkeyId5 = 5;
			int HotKeyCode5 = 116;
			bool F5Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId5, 0, HotKeyCode5);
			int UniqueHotkeyId6 = 6;
			int HotKeyCode6 = 117;
			bool F6Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId6, 0, HotKeyCode6);
			int UniqueHotkeyId7 = 7;
			int HotKeyCode7 = 118;
			bool F7Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId7, 0, HotKeyCode7);
			int UniqueHotkeyId8 = 8;
			int HotKeyCode8 = 119;
			bool F8Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId8, 0, HotKeyCode8);
			int UniqueHotkeyId9 = 9;
			int HotKeyCode9 = 120;
			bool F9Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId9, 0, HotKeyCode9);
			int UniqueHotkeyId10 = 10;
			int HotKeyCode10 = 121;
			bool F10Registered = TrainerBase.RegisterHotKey(base.Handle, UniqueHotkeyId10, 0, HotKeyCode10);
		}

		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg == 786;
			if (flag)
			{
				int id = m.WParam.ToInt32();
				bool flag2 = id == 1;
				if (flag2)
				{
					bool @checked = this.checkBox6.Checked;
					if (@checked)
					{
						this.checkBox6.Checked = false;
						this.label7.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox6.Checked = true;
						this.label7.ForeColor = Color.ForestGreen;
					}
				}
				bool flag3 = id == 2;
				if (flag3)
				{
					bool checked2 = this.checkBox4.Checked;
					if (checked2)
					{
						this.checkBox4.Checked = false;
						this.label25.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox4.Checked = true;
						this.label25.ForeColor = Color.ForestGreen;
					}
				}
				bool flag4 = id == 3;
				if (flag4)
				{
					bool checked3 = this.checkBox2.Checked;
					if (checked3)
					{
						this.checkBox2.Checked = false;
						this.label24.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox2.Checked = true;
						this.label24.ForeColor = Color.ForestGreen;
					}
				}
				bool flag5 = id == 4;
				if (flag5)
				{
					bool checked4 = this.checkBox3.Checked;
					if (checked4)
					{
						this.checkBox3.Checked = false;
						this.label23.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox3.Checked = true;
						this.label23.ForeColor = Color.ForestGreen;
					}
				}
				bool flag6 = id == 5;
				if (flag6)
				{
					bool checked5 = this.checkBox1.Checked;
					if (checked5)
					{
						this.checkBox1.Checked = false;
						this.label22.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox1.Checked = true;
						this.label22.ForeColor = Color.ForestGreen;
					}
				}
				bool flag7 = id == 6;
				if (flag7)
				{
					bool checked6 = this.checkBox31.Checked;
					if (checked6)
					{
						this.checkBox31.Checked = false;
						this.label21.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox31.Checked = true;
						this.label21.ForeColor = Color.ForestGreen;
					}
				}
				bool flag8 = id == 7;
				if (flag8)
				{
					bool checked7 = this.checkBox44.Checked;
					if (checked7)
					{
						this.checkBox44.Checked = false;
						this.label20.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox44.Checked = true;
						this.label20.ForeColor = Color.ForestGreen;
					}
				}
				bool flag9 = id == 8;
				if (flag9)
				{
					bool checked8 = this.checkBox5.Checked;
					if (checked8)
					{
						this.checkBox5.Checked = false;
						this.label19.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox5.Checked = true;
						this.label19.ForeColor = Color.ForestGreen;
					}
				}
				bool flag10 = id == 9;
				if (flag10)
				{
					bool checked9 = this.checkBox8.Checked;
					if (checked9)
					{
						this.checkBox8.Checked = false;
						this.label18.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox8.Checked = true;
						this.label18.ForeColor = Color.ForestGreen;
					}
				}
				bool flag11 = id == 10;
				if (flag11)
				{
					bool checked10 = this.checkBox15.Checked;
					if (checked10)
					{
						this.checkBox15.Checked = false;
						this.label17.ForeColor = Color.Gainsboro;
					}
					else
					{
						this.checkBox15.Checked = true;
						this.label17.ForeColor = Color.ForestGreen;
					}
				}
			}
			base.WndProc(ref m);
		}

		[DllImport("user32.dll", SetLastError = true)]
		private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		public async void LoadSets()
		{
			await Task.Delay(0);
			this.sets.Items.Clear();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path += "\\growsense";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			path += "\\sets\\";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string[] files = Directory.GetFiles(path);
			foreach (string file in files)
			{
				this.sets.Items.Add(Path.GetFileName(file));
				file = null;
			}
			string[] array = null;
		}

		public async void LoadConfigs()
		{
			await Task.Delay(0);
			this.configsbox.Items.Clear();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path += "\\growsense";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			path += "\\configs\\";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string[] files = Directory.GetFiles(path);
			foreach (string file in files)
			{
				this.configsbox.Items.Add(Path.GetFileName(file));
				file = null;
			}
			string[] array = null;
		}

		private void ProcessLabel_Click(object sender, EventArgs e)
		{
		}

		public static string GetHWID()
		{
			bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
			RegistryKey registryKey;
			if (is64BitOperatingSystem)
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			}
			else
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
			}
			return registryKey.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductId").ToString();
		}

		private void TrainerBase_Load(object sender, EventArgs e)
		{
			Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Desktop/growsense/resources");
			bool flag = !File.Exists("C:/Users/" + Environment.UserName + "/Desktop/growsense/resources/dummy.exe");
			if (flag)
			{
				WebClient wb = new WebClient();
				Uri dummy = new Uri("https://www105.zippyshare.com/d/D3MtjKe1/9358/dummy.exe");
				wb.DownloadFileAsync(dummy, "C:/Users/" + Environment.UserName + "/Desktop/growsense/resources/dummy.exe");
			}
			this.gtpath.Text = "C:/Users/" + Environment.UserName + "/Appdata/Local/Growtopia/Growtopia.exe";
			Process[] gt = Process.GetProcessesByName("Growtopia");
			int x = gt.Length;
			this.openedgrowtopias.Text = x.ToString();
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag2 = !sucess;
			if (flag2)
			{
				this.hackloader.Stop();
			}
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			path2 += "\\growsense\\resources";
			path2 += "\\GtPath.txt";
			bool flag3 = File.Exists(path2);
			if (flag3)
			{
				this.gtpath.Text = File.ReadAllText(path2);
			}
			this.computername.Text = this.pcname;
			this.username.Text = this.pcuser;
			this.hardwareid.Text = this.hwid;
			this.subscription.Text = "Premium";
			string fontName = "Century Gothic";
			float fontSize = 12f;
			using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
			{
				bool flag4 = fontTester.Name == fontName;
				if (flag4)
				{
					int pIDD = this.m.getProcIDFromName("Growtopia");
					bool sucesss = this.m.OpenProcess(pIDD);
					bool flag5 = !sucesss;
					if (flag5)
					{
						this.hackloader.Stop();
					}
					else
					{
						this.hackloader.Start();
					}
					this.bunifuDragControl10.Horizontal = false;
					this.bunifuDragControl10.Vertical = false;
					this.bunifuDragControl9.Vertical = false;
					this.bunifuDragControl9.Horizontal = false;
					this.address.Show();
					this.visuals.Hide();
					this.configs.Hide();
					this.changers.Hide();
					this.exploits.Hide();
					this.settings.Hide();
					this.address2.Hide();
					this.multiboxing.Hide();
				}
			}
		}

		private void panel28_Click(object sender, EventArgs e)
		{
			this.address.Show();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.configs.Hide();
			this.exploits.Hide();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			this.address.Show();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.configs.Hide();
			this.exploits.Hide();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004700 File Offset: 0x00002900
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Show();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Hide();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004770 File Offset: 0x00002970
		private void panel29_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Show();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Hide();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000047E0 File Offset: 0x000029E0
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			bool @checked = this.helpmsgbox.Checked;
			if (@checked)
			{
				this.address.Hide();
				this.visuals.Hide();
				this.configs.Show();
				this.changers.Hide();
				this.exploits.Hide();
				this.settings.Hide();
				this.address2.Hide();
				this.multiboxing.Hide();
				this.LoadSets();
				this.LoadConfigs();
				MessageBox.Show("YOU CAN DISABLE THIS MESSAGE IN MISC\n\nSaving Configs\n\nYou can create new config by typing the name you want in the 'config name' textbox.\n\nEditing Config\n\nYou can edit configs by editing them and clicking the Create/save config button again.\n\nLoading Configs\n\nYou can load configs, by selecting the config you want to load from the 'Saved set configs'\n\nDeleting Configs\n\nJust click delete and the config will disappear.\n\nIMPORTANT\n\nWhen you save main config it will also save the set changer values. If you want to make custom set only, then create config with 'Advanced set configs'.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.address.Hide();
				this.visuals.Hide();
				this.configs.Show();
				this.changers.Hide();
				this.exploits.Hide();
				this.settings.Hide();
				this.address2.Hide();
				this.multiboxing.Hide();
				this.LoadSets();
				this.LoadConfigs();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000048F8 File Offset: 0x00002AF8
		private void panel114_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Show();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004968 File Offset: 0x00002B68
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Hide();
			this.settings.Show();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000049D8 File Offset: 0x00002BD8
		private void panel116_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Hide();
			this.settings.Show();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004A48 File Offset: 0x00002C48
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.exploits.Hide();
			this.changers.Hide();
			this.settings.Hide();
			this.changers.Show();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004AC4 File Offset: 0x00002CC4
		private void panel117_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.exploits.Hide();
			this.changers.Hide();
			this.settings.Hide();
			this.changers.Show();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004B40 File Offset: 0x00002D40
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Show();
			this.settings.Hide();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020F0 File Offset: 0x000002F0
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004BB0 File Offset: 0x00002DB0
		private async void metroButton17_Click(object sender, EventArgs e)
		{
			bool flag = this.configname.Text == "";
			if (flag)
			{
				MessageBox.Show("You can't create config without a name.\nor\nPlease select config from the list to save.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				await Task.Delay(0);
				StringBuilder configbuilder = new StringBuilder();
				configbuilder.AppendLine("checkbox44=" + ((int)this.cfgform.cbox44.Value).ToString());
				configbuilder.AppendLine("checkbox33=" + ((int)this.cfgform.cbox33.Value).ToString());
				configbuilder.AppendLine("checkbox32=" + ((int)this.cfgform.cbox32.Value).ToString());
				configbuilder.AppendLine("checkbox31=" + ((int)this.cfgform.cbox31.Value).ToString());
				configbuilder.AppendLine("checkbox30=" + ((int)this.cfgform.cbox30.Value).ToString());
				configbuilder.AppendLine("checkbox29=" + ((int)this.cfgform.cbox29.Value).ToString());
				configbuilder.AppendLine("checkbox26=" + ((int)this.cfgform.cbox26.Value).ToString());
				configbuilder.AppendLine("checkbox25=" + ((int)this.cfgform.cbox25.Value).ToString());
				configbuilder.AppendLine("checkbox24=" + ((int)this.cfgform.cbox24.Value).ToString());
				configbuilder.AppendLine("checkbox23=" + ((int)this.cfgform.cbox23.Value).ToString());
				configbuilder.AppendLine("checkbox22=" + ((int)this.cfgform.cbox22.Value).ToString());
				configbuilder.AppendLine("checkbox21=" + ((int)this.cfgform.cbox21.Value).ToString());
				configbuilder.AppendLine("checkbox20=" + ((int)this.cfgform.cbox20.Value).ToString());
				configbuilder.AppendLine("checkbox15=" + ((int)this.cfgform.cbox15.Value).ToString());
				configbuilder.AppendLine("checkbox8=" + ((int)this.cfgform.cbox8.Value).ToString());
				configbuilder.AppendLine("checkbox7=" + ((int)this.cfgform.cbox7.Value).ToString());
				configbuilder.AppendLine("checkbox6=" + ((int)this.cfgform.cbox6.Value).ToString());
				configbuilder.AppendLine("checkbox5=" + ((int)this.cfgform.cbox5.Value).ToString());
				configbuilder.AppendLine("checkbox4=" + ((int)this.cfgform.cbox4.Value).ToString());
				configbuilder.AppendLine("checkbox3=" + ((int)this.cfgform.cbox3.Value).ToString());
				configbuilder.AppendLine("checkbox2=" + ((int)this.cfgform.cbox2.Value).ToString());
				configbuilder.AppendLine("checkbox1=" + ((int)this.cfgform.cbox1.Value).ToString());
				configbuilder.AppendLine("topmost=" + ((int)this.cfgform.topmost.Value).ToString());
				configbuilder.AppendLine("rainbowtop=" + ((int)this.cfgform.rainbowtop.Value).ToString());
				configbuilder.AppendLine("helpmsg=" + ((int)this.cfgform.helpmsg.Value).ToString());
				configbuilder.AppendLine("dragbox=" + ((int)this.cfgform.dragbox2.Value).ToString());
				configbuilder.AppendLine("savebox=" + ((int)this.cfgform.savebox2.Value).ToString());
				configbuilder.AppendLine("face=" + ((int)this.hatID.Value).ToString());
				configbuilder.AppendLine("shirt=" + ((int)this.shirtID.Value).ToString());
				configbuilder.AppendLine("pants=" + ((int)this.pantsID.Value).ToString());
				configbuilder.AppendLine("feet=" + ((int)this.bootsID.Value).ToString());
				configbuilder.AppendLine("hand=" + ((int)this.handID.Value).ToString());
				configbuilder.AppendLine("back=" + ((int)this.wingID.Value).ToString());
				configbuilder.AppendLine("head=" + ((int)this.hairID.Value).ToString());
				configbuilder.AppendLine("neck=" + ((int)this.neckID.Value).ToString());
				configbuilder.AppendLine("face=" + ((int)this.hatID.Value).ToString());
				configbuilder.AppendLine("puncheffect=" + ((int)this.punchID.Value).ToString());
				configbuilder.AppendLine("skincolor=" + ((int)this.eyeID.Value).ToString());
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				path += "\\growsense";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				path += "\\configs\\";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				this.LoadConfigs();
				path += this.configname.Text;
				if (File.Exists(path))
				{
					DialogResult res = MessageBox.Show("Config exists, override?", "growsense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (res == DialogResult.Yes)
					{
						File.WriteAllText(path, configbuilder.ToString());
						await Task.Delay(100);
						this.LoadConfigs();
					}
				}
				else
				{
					File.WriteAllText(path, configbuilder.ToString());
					await Task.Delay(100);
					this.LoadConfigs();
				}
				configbuilder = null;
				path = null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004BFC File Offset: 0x00002DFC
		private async void metroButton16_Click(object sender, EventArgs e)
		{
			await Task.Delay(0);
			if (this.configsbox.SelectedIndex == -1)
			{
				MessageBox.Show("Select config that you want to load.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				path += "\\growsense";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				path += "\\configs\\";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string cfg = path + this.configsbox.SelectedItem.ToString();
				this.LoadConfigs();
				if (!File.Exists(cfg))
				{
					MessageBox.Show("The config doesn't exist, maybe an error occurred?", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					string[] lines = File.ReadAllLines(cfg);
					MessageBox.Show("Config successfully loaded.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					string[] array = lines;
					int i = 0;
					while (i < array.Length)
					{
						string line = array[i];
						string item = line.Split(new char[]
						{
							'='
						})[0];
						string value = line.Split(new char[]
						{
							'='
						})[1];
						string text = item;
						if (text != null)
						{
							string text2 = text;
							uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
							if (num <= 1370635983U)
							{
								if (num <= 176014077U)
								{
									if (num <= 108756506U)
									{
										if (num <= 58570744U)
										{
											if (num != 41793125U)
											{
												if (num == 58570744U)
												{
													if (text2 == "checkbox26")
													{
														this.cfgform.cbox26.Value = int.Parse(value);
													}
												}
											}
											else if (text2 == "checkbox29")
											{
												this.cfgform.cbox29.Value = int.Parse(value);
											}
										}
										else if (num != 92125982U)
										{
											if (num == 108756506U)
											{
												if (text2 == "checkbox15")
												{
													this.cfgform.cbox15.Value = int.Parse(value);
												}
											}
										}
										else if (text2 == "checkbox24")
										{
											this.cfgform.cbox24.Value = int.Parse(value);
										}
									}
									else if (num <= 125681220U)
									{
										if (num != 108903601U)
										{
											if (num == 125681220U)
											{
												if (text2 == "checkbox22")
												{
													this.cfgform.cbox22.Value = int.Parse(value);
												}
											}
										}
										else if (text2 == "checkbox25")
										{
											this.cfgform.cbox25.Value = int.Parse(value);
										}
									}
									else if (num != 142458839U)
									{
										if (num != 159236458U)
										{
											if (num == 176014077U)
											{
												if (text2 == "checkbox21")
												{
													this.cfgform.cbox21.Value = int.Parse(value);
												}
											}
										}
										else if (text2 == "checkbox20")
										{
											this.cfgform.cbox20.Value = int.Parse(value);
										}
									}
									else if (text2 == "checkbox23")
									{
										this.cfgform.cbox23.Value = int.Parse(value);
									}
								}
								else if (num <= 864148047U)
								{
									if (num <= 402572659U)
									{
										if (num != 292255708U)
										{
											if (num == 402572659U)
											{
												if (text2 == "topmost")
												{
													this.cfgform.topmost.Value = int.Parse(value);
												}
											}
										}
										else if (text2 == "face")
										{
											this.hatID.Value = int.Parse(value);
										}
									}
									else if (num != 845761475U)
									{
										if (num == 864148047U)
										{
											if (text2 == "helpmsg")
											{
												this.cfgform.helpmsg.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "head")
									{
										this.hairID.Value = int.Parse(value);
									}
								}
								else if (num <= 1138976003U)
								{
									if (num != 889511044U)
									{
										if (num == 1138976003U)
										{
											if (text2 == "shirt")
											{
												this.shirtID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "dragbox")
									{
										this.cfgform.dragbox2.Value = int.Parse(value);
									}
								}
								else if (num != 1150980865U)
								{
									if (num != 1274632466U)
									{
										if (num == 1370635983U)
										{
											if (text2 == "skincolor")
											{
												this.eyeID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "neck")
									{
										this.neckID.Value = int.Parse(value);
									}
								}
								else if (text2 == "savebox")
								{
									this.cfgform.savebox2.Value = int.Parse(value);
								}
							}
							else if (num <= 4001355136U)
							{
								if (num <= 3140845397U)
								{
									if (num <= 1764363960U)
									{
										if (num != 1538531746U)
										{
											if (num == 1764363960U)
											{
												if (text2 == "rainbowtop")
												{
													this.cfgform.rainbowtop.Value = int.Parse(value);
												}
											}
										}
										else if (text2 == "back")
										{
											this.wingID.Value = int.Parse(value);
										}
									}
									else if (num != 1904403024U)
									{
										if (num == 3140845397U)
										{
											if (text2 == "feet")
											{
												this.bootsID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "checkbox44")
									{
										this.cfgform.cbox44.Value = int.Parse(value);
									}
								}
								else if (num <= 3493503270U)
								{
									if (num != 3300536096U)
									{
										if (num == 3493503270U)
										{
											if (text2 == "puncheffect")
											{
												this.punchID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "hand")
									{
										this.handID.Value = int.Parse(value);
									}
								}
								else if (num != 3726850017U)
								{
									if (num != 3944493920U)
									{
										if (num == 4001355136U)
										{
											if (text2 == "checkbox31")
											{
												this.cfgform.cbox31.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "checkbox8")
									{
										this.cfgform.cbox8.Value = int.Parse(value);
									}
								}
								else if (text2 == "pants")
								{
									this.pantsID.Value = int.Parse(value);
								}
							}
							else if (num <= 4112270110U)
							{
								if (num <= 4034910374U)
								{
									if (num != 4018132755U)
									{
										if (num == 4034910374U)
										{
											if (text2 == "checkbox33")
											{
												this.cfgform.cbox33.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "checkbox30")
									{
										this.cfgform.cbox30.Value = int.Parse(value);
									}
								}
								else if (num != 4051687993U)
								{
									if (num != 4095492491U)
									{
										if (num == 4112270110U)
										{
											if (text2 == "checkbox2")
											{
												this.cfgform.cbox2.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "checkbox1")
									{
										this.cfgform.cbox1.Value = int.Parse(value);
									}
								}
								else if (text2 == "checkbox32")
								{
									this.cfgform.cbox32.Value = int.Parse(value);
								}
							}
							else if (num <= 4145825348U)
							{
								if (num != 4129047729U)
								{
									if (num == 4145825348U)
									{
										if (text2 == "checkbox4")
										{
											this.cfgform.cbox4.Value = int.Parse(value);
										}
									}
								}
								else if (text2 == "checkbox3")
								{
									this.cfgform.cbox3.Value = int.Parse(value);
								}
							}
							else if (num != 4162602967U)
							{
								if (num != 4179380586U)
								{
									if (num == 4196158205U)
									{
										if (text2 == "checkbox7")
										{
											this.cfgform.cbox7.Value = int.Parse(value);
										}
									}
								}
								else if (text2 == "checkbox6")
								{
									this.cfgform.cbox6.Value = int.Parse(value);
								}
							}
							else if (text2 == "checkbox5")
							{
								this.cfgform.cbox5.Value = int.Parse(value);
							}
						}
						IL_E2B:
						text = null;
						item = null;
						value = null;
						line = null;
						i++;
						continue;
						goto IL_E2B;
					}
					array = null;
					await Task.Delay(100);
					path = null;
					cfg = null;
					lines = null;
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004C48 File Offset: 0x00002E48
		private void metroButton15_Click(object sender, EventArgs e)
		{
			bool flag = this.configsbox.SelectedIndex == -1;
			if (flag)
			{
				MessageBox.Show("Select config that you want to delete.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = this.configsbox.SelectedIndex != -1;
				if (flag2)
				{
					DialogResult res = MessageBox.Show("Are you sure you wan't to delete?", "growsense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					bool flag3 = res == DialogResult.Yes;
					if (flag3)
					{
						string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
						path += "\\growsense";
						bool flag4 = !Directory.Exists(path);
						if (flag4)
						{
							Directory.CreateDirectory(path);
						}
						path += "\\configs\\";
						bool flag5 = !Directory.Exists(path);
						if (flag5)
						{
							Directory.CreateDirectory(path);
						}
						string cfg = path + this.configsbox.SelectedItem.ToString();
						bool flag6 = File.Exists(cfg);
						if (flag6)
						{
							File.Delete(cfg);
						}
						this.LoadConfigs();
					}
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004D48 File Offset: 0x00002F48
		private async void metroButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.settname.Text == "";
			if (flag)
			{
				MessageBox.Show("You can't create config without a name.\nor\nPlease select config from the list to save.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				await Task.Delay(0);
				StringBuilder configbuilder2 = new StringBuilder();
				configbuilder2.AppendLine("face=" + ((int)this.hatID.Value).ToString());
				configbuilder2.AppendLine("shirt=" + ((int)this.shirtID.Value).ToString());
				configbuilder2.AppendLine("pants=" + ((int)this.pantsID.Value).ToString());
				configbuilder2.AppendLine("feet=" + ((int)this.bootsID.Value).ToString());
				configbuilder2.AppendLine("hand=" + ((int)this.handID.Value).ToString());
				configbuilder2.AppendLine("back=" + ((int)this.wingID.Value).ToString());
				configbuilder2.AppendLine("head=" + ((int)this.hairID.Value).ToString());
				configbuilder2.AppendLine("neck=" + ((int)this.neckID.Value).ToString());
				configbuilder2.AppendLine("face=" + ((int)this.hatID.Value).ToString());
				configbuilder2.AppendLine("savebox=" + ((int)this.cfgform.savebox2.Value).ToString());
				configbuilder2.AppendLine("puncheffect=" + ((int)this.punchID.Value).ToString());
				configbuilder2.AppendLine("skincolor=" + ((int)this.eyeID.Value).ToString());
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				path += "\\growsense";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				path += "\\sets\\";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				path += this.settname.Text;
				if (File.Exists(path))
				{
					DialogResult res = MessageBox.Show("Set exists, override?", "growsense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (res == DialogResult.Yes)
					{
						File.WriteAllText(path, configbuilder2.ToString());
						await Task.Delay(100);
					}
				}
				else
				{
					File.WriteAllText(path, configbuilder2.ToString());
					await Task.Delay(100);
				}
				this.LoadSets();
				configbuilder2 = null;
				path = null;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004D94 File Offset: 0x00002F94
		private async void metroButton2_Click(object sender, EventArgs e)
		{
			await Task.Delay(0);
			if (this.sets.SelectedIndex == -1)
			{
				MessageBox.Show("Select config that you want to load.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				path += "\\growsense";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				path += "\\sets\\";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string cfg = path + this.sets.SelectedItem.ToString();
				if (!File.Exists(cfg))
				{
					MessageBox.Show("The set doesn't exist, maybe an error occurred?", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					string[] lines = File.ReadAllLines(cfg);
					MessageBox.Show("Config successfully loaded.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					string[] array = lines;
					int i = 0;
					while (i < array.Length)
					{
						string line = array[i];
						string item = line.Split(new char[]
						{
							'='
						})[0];
						string value = line.Split(new char[]
						{
							'='
						})[1];
						string text = item;
						if (text != null)
						{
							string text2 = text;
							uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
							if (num <= 1274632466U)
							{
								if (num <= 845761475U)
								{
									if (num != 292255708U)
									{
										if (num == 845761475U)
										{
											if (text2 == "head")
											{
												this.hairID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "face")
									{
										this.hatID.Value = int.Parse(value);
									}
								}
								else if (num != 1138976003U)
								{
									if (num != 1150980865U)
									{
										if (num == 1274632466U)
										{
											if (text2 == "neck")
											{
												this.neckID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "savebox")
									{
										this.cfgform.savebox2.Value = int.Parse(value);
									}
								}
								else if (text2 == "shirt")
								{
									this.shirtID.Value = int.Parse(value);
								}
							}
							else if (num <= 3140845397U)
							{
								if (num != 1370635983U)
								{
									if (num != 1538531746U)
									{
										if (num == 3140845397U)
										{
											if (text2 == "feet")
											{
												this.bootsID.Value = int.Parse(value);
											}
										}
									}
									else if (text2 == "back")
									{
										this.wingID.Value = int.Parse(value);
									}
								}
								else if (text2 == "skincolor")
								{
									this.eyeID.Value = int.Parse(value);
								}
							}
							else if (num != 3300536096U)
							{
								if (num != 3493503270U)
								{
									if (num == 3726850017U)
									{
										if (text2 == "pants")
										{
											this.pantsID.Value = int.Parse(value);
										}
									}
								}
								else if (text2 == "puncheffect")
								{
									this.punchID.Value = int.Parse(value);
								}
							}
							else if (text2 == "hand")
							{
								this.handID.Value = int.Parse(value);
							}
						}
						IL_577:
						text = null;
						item = null;
						value = null;
						line = null;
						i++;
						continue;
						goto IL_577;
					}
					array = null;
					await Task.Delay(100);
					path = null;
					cfg = null;
					lines = null;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004DE0 File Offset: 0x00002FE0
		private void metroButton14_Click(object sender, EventArgs e)
		{
			bool flag = this.sets.SelectedIndex == -1;
			if (flag)
			{
				MessageBox.Show("Select config that you want to delete.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = this.sets.SelectedIndex != -1;
				if (flag2)
				{
					DialogResult res = MessageBox.Show("Are you sure you wan't to delete?", "growsense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					bool flag3 = res == DialogResult.Yes;
					if (flag3)
					{
						string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
						path += "\\growsense";
						bool flag4 = !Directory.Exists(path);
						if (flag4)
						{
							Directory.CreateDirectory(path);
						}
						path += "\\sets\\";
						bool flag5 = !Directory.Exists(path);
						if (flag5)
						{
							Directory.CreateDirectory(path);
						}
						string cfg = path + this.sets.SelectedItem.ToString();
						bool flag6 = File.Exists(cfg);
						if (flag6)
						{
							File.Delete(cfg);
						}
						this.LoadSets();
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004EE0 File Offset: 0x000030E0
		private void checkBox41_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.topmostbox.Checked;
			if (@checked)
			{
				base.TopMost = true;
				this.cfgform.topmost.Value = 1m;
			}
			else
			{
				base.TopMost = false;
				this.cfgform.topmost.Value = 0m;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004F40 File Offset: 0x00003140
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rainbowtopbox.Checked;
			if (@checked)
			{
				this.rainbowtop.Show();
				this.cfgform.rainbowtop.Value = 1m;
			}
			else
			{
				this.rainbowtop.Hide();
				this.cfgform.rainbowtop.Value = 0m;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004FA8 File Offset: 0x000031A8
		private async void metroTrackbar1_Scroll(object sender, MetroTrackbar.TrackbarEventArgs e)
		{
			await Task.Delay(0);
			base.Opacity = (double)this.metroTrackbar1.Value / 100.0;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004FF4 File Offset: 0x000031F4
		private void checkBox22_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox22.Checked;
			if (@checked)
			{
				this.cfgform.cbox22.Value = 1m;
			}
			else
			{
				this.cfgform.cbox22.Value = 0m;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005044 File Offset: 0x00003244
		private void checkBox23_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox23.Checked;
			if (@checked)
			{
				this.cfgform.cbox23.Value = 1m;
			}
			else
			{
				this.cfgform.cbox23.Value = 0m;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005094 File Offset: 0x00003294
		private void checkBox24_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox24.Checked;
			if (@checked)
			{
				this.cfgform.cbox24.Value = 1m;
			}
			else
			{
				this.cfgform.cbox24.Value = 0m;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000050E4 File Offset: 0x000032E4
		private void checkBox25_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox25.Checked;
			if (@checked)
			{
				this.cfgform.cbox25.Value = 1m;
			}
			else
			{
				this.cfgform.cbox25.Value = 0m;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005134 File Offset: 0x00003334
		private void checkBox26_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox26.Checked;
			if (@checked)
			{
				this.cfgform.cbox26.Value = 1m;
			}
			else
			{
				this.cfgform.cbox26.Value = 0m;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005184 File Offset: 0x00003384
		private void checkBox30_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox30.Checked;
			if (@checked)
			{
				this.cfgform.cbox30.Value = 1m;
			}
			else
			{
				this.cfgform.cbox30.Value = 0m;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000051D4 File Offset: 0x000033D4
		private void checkBox31_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox31.Checked;
			if (@checked)
			{
				this.cfgform.cbox31.Value = 1m;
			}
			else
			{
				this.cfgform.cbox31.Value = 0m;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005224 File Offset: 0x00003424
		private void checkBox32_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox32.Checked;
			if (@checked)
			{
				this.cfgform.cbox32.Value = 1m;
			}
			else
			{
				this.cfgform.cbox32.Value = 0m;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005274 File Offset: 0x00003474
		private void checkBox33_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox33.Checked;
			if (@checked)
			{
				this.cfgform.cbox33.Value = 1m;
			}
			else
			{
				this.cfgform.cbox33.Value = 0m;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000052C4 File Offset: 0x000034C4
		private void checkBox21_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox21.Checked;
			if (@checked)
			{
				this.cfgform.cbox21.Value = 1m;
			}
			else
			{
				this.cfgform.cbox21.Value = 0m;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005314 File Offset: 0x00003514
		private void checkBox20_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox20.Checked;
			if (@checked)
			{
				this.cfgform.cbox20.Value = 1m;
			}
			else
			{
				this.cfgform.cbox20.Value = 0m;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005364 File Offset: 0x00003564
		private void configtimer_Tick(object sender, EventArgs e)
		{
			bool flag = this.cfgform.cbox29.Value == 1m;
			if (flag)
			{
				this.checkBox29.Checked = true;
			}
			else
			{
				this.checkBox29.Checked = false;
			}
			bool flag2 = this.cfgform.cbox5.Value == 1m;
			if (flag2)
			{
				this.checkBox5.Checked = true;
			}
			else
			{
				this.checkBox5.Checked = false;
			}
			bool flag3 = this.cfgform.cbox1.Value == 1m;
			if (flag3)
			{
				this.checkBox1.Checked = true;
			}
			else
			{
				this.checkBox1.Checked = false;
			}
			bool flag4 = this.cfgform.cbox8.Value == 1m;
			if (flag4)
			{
				this.checkBox8.Checked = true;
			}
			else
			{
				this.checkBox8.Checked = false;
			}
			bool flag5 = this.cfgform.cbox3.Value == 1m;
			if (flag5)
			{
				this.checkBox3.Checked = true;
			}
			else
			{
				this.checkBox3.Checked = false;
			}
			bool flag6 = this.cfgform.cbox2.Value == 1m;
			if (flag6)
			{
				this.checkBox2.Checked = true;
			}
			else
			{
				this.checkBox2.Checked = false;
			}
			bool flag7 = this.cfgform.cbox15.Value == 1m;
			if (flag7)
			{
				this.checkBox15.Checked = true;
			}
			else
			{
				this.checkBox15.Checked = false;
			}
			bool flag8 = this.cfgform.cbox44.Value == 1m;
			if (flag8)
			{
				this.checkBox44.Checked = true;
			}
			else
			{
				this.checkBox44.Checked = false;
			}
			bool flag9 = this.cfgform.topmost.Value == 1m;
			if (flag9)
			{
				this.topmostbox.Checked = true;
			}
			else
			{
				this.topmostbox.Checked = false;
			}
			bool flag10 = this.cfgform.cbox4.Value == 1m;
			if (flag10)
			{
				this.checkBox4.Checked = true;
			}
			else
			{
				this.checkBox4.Checked = false;
			}
			bool flag11 = this.cfgform.cbox33.Value == 1m;
			if (flag11)
			{
				this.checkBox33.Checked = true;
			}
			else
			{
				this.checkBox33.Checked = false;
			}
			bool flag12 = this.cfgform.cbox32.Value == 1m;
			if (flag12)
			{
				this.checkBox32.Checked = true;
			}
			else
			{
				this.checkBox32.Checked = false;
			}
			bool flag13 = this.cfgform.cbox31.Value == 1m;
			if (flag13)
			{
				this.checkBox31.Checked = true;
			}
			else
			{
				this.checkBox31.Checked = false;
			}
			bool flag14 = this.cfgform.cbox30.Value == 1m;
			if (flag14)
			{
				this.checkBox30.Checked = true;
			}
			else
			{
				this.checkBox30.Checked = false;
			}
			bool flag15 = this.cfgform.cbox26.Value == 1m;
			if (flag15)
			{
				this.checkBox26.Checked = true;
			}
			else
			{
				this.checkBox26.Checked = false;
			}
			bool flag16 = this.cfgform.cbox25.Value == 1m;
			if (flag16)
			{
				this.checkBox25.Checked = true;
			}
			else
			{
				this.checkBox25.Checked = false;
			}
			bool flag17 = this.cfgform.cbox24.Value == 1m;
			if (flag17)
			{
				this.checkBox24.Checked = true;
			}
			else
			{
				this.checkBox24.Checked = false;
			}
			bool flag18 = this.cfgform.cbox23.Value == 1m;
			if (flag18)
			{
				this.checkBox23.Checked = true;
			}
			else
			{
				this.checkBox23.Checked = false;
			}
			bool flag19 = this.cfgform.cbox22.Value == 1m;
			if (flag19)
			{
				this.checkBox22.Checked = true;
			}
			else
			{
				this.checkBox22.Checked = false;
			}
			bool flag20 = this.cfgform.cbox21.Value == 1m;
			if (flag20)
			{
				this.checkBox21.Checked = true;
			}
			else
			{
				this.checkBox21.Checked = false;
			}
			bool flag21 = this.cfgform.cbox20.Value == 1m;
			if (flag21)
			{
				this.checkBox20.Checked = true;
			}
			else
			{
				this.checkBox20.Checked = false;
			}
			bool flag22 = this.cfgform.cbox6.Value == 1m;
			if (flag22)
			{
				this.checkBox6.Checked = true;
			}
			else
			{
				this.checkBox6.Checked = false;
			}
			bool flag23 = this.cfgform.cbox7.Value == 1m;
			if (flag23)
			{
				this.checkBox7.Checked = true;
			}
			else
			{
				this.checkBox7.Checked = false;
			}
			bool flag24 = this.cfgform.rainbowtop.Value == 1m;
			if (flag24)
			{
				this.rainbowtopbox.Checked = true;
			}
			else
			{
				this.rainbowtopbox.Checked = false;
			}
			bool flag25 = this.cfgform.helpmsg.Value == 1m;
			if (flag25)
			{
				this.helpmsgbox.Checked = true;
			}
			else
			{
				this.helpmsgbox.Checked = false;
			}
			bool flag26 = this.cfgform.dragbox2.Value == 1m;
			if (flag26)
			{
				this.dragbox.Checked = true;
			}
			else
			{
				this.dragbox.Checked = false;
			}
			bool flag27 = this.cfgform.savebox2.Value == 1m;
			if (flag27)
			{
				this.savebox.Checked = true;
			}
			else
			{
				this.savebox.Checked = false;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005A2C File Offset: 0x00003C2C
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.helpmsgbox.Checked;
			if (@checked)
			{
				this.cfgform.helpmsg.Value = 1m;
			}
			else
			{
				this.cfgform.helpmsg.Value = 0m;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005A7C File Offset: 0x00003C7C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.address.Hide();
			this.visuals.Hide();
			this.configs.Hide();
			this.changers.Hide();
			this.exploits.Hide();
			this.settings.Show();
			this.address2.Hide();
			this.multiboxing.Hide();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005AEC File Offset: 0x00003CEC
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.dragbox.Checked;
			if (@checked)
			{
				this.bunifuDragControl10.Horizontal = true;
				this.bunifuDragControl10.Vertical = true;
				this.bunifuDragControl9.Vertical = true;
				this.bunifuDragControl9.Horizontal = true;
				this.cfgform.dragbox2.Value = 1m;
			}
			else
			{
				this.bunifuDragControl10.Horizontal = false;
				this.bunifuDragControl10.Vertical = false;
				this.bunifuDragControl9.Vertical = false;
				this.bunifuDragControl9.Horizontal = false;
				this.cfgform.dragbox2.Value = 0m;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020F0 File Offset: 0x000002F0
		private void checkBox51_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005BA4 File Offset: 0x00003DA4
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox4.Checked;
			if (@checked)
			{
				this.cfgform.cbox4.Value = 1m;
			}
			else
			{
				this.cfgform.cbox4.Value = 0m;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005BF3 File Offset: 0x00003DF3
		private void label11_Click(object sender, EventArgs e)
		{
			this.modes.Show();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005C04 File Offset: 0x00003E04
		private void modev1_Click(object sender, EventArgs e)
		{
			bool flag = this.modev1.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode1.Checked = true;
			}
			bool flag2 = this.modev1.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode1.Checked = false;
			}
			bool @checked = this.checkmode1.Checked;
			if (@checked)
			{
				this.modev1.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode1.Checked = false;
				this.modelabel.Text = "Mode : v1";
			}
			else
			{
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode1.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005D29 File Offset: 0x00003F29
		private void label11_Click_1(object sender, EventArgs e)
		{
			this.modes.Hide();
			this.label10.Show();
			this.label11.Hide();
			this.panel102.Hide();
			this.panel100.Show();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005D68 File Offset: 0x00003F68
		private void modev2_Click(object sender, EventArgs e)
		{
			bool flag = this.modev2.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode2.Checked = true;
			}
			bool flag2 = this.modev2.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode2.Checked = false;
			}
			bool @checked = this.checkmode2.Checked;
			if (@checked)
			{
				this.modev2.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode2.Checked = false;
				this.modelabel.Text = "Mode : v2";
			}
			else
			{
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode2.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005E90 File Offset: 0x00004090
		private void modev3_Click(object sender, EventArgs e)
		{
			bool flag = this.modev3.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode3.Checked = true;
			}
			bool flag2 = this.modev3.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode3.Checked = false;
			}
			bool @checked = this.checkmode3.Checked;
			if (@checked)
			{
				this.modev3.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.checkmode3.Checked = false;
				this.modelabel.Text = "Mode : v3";
			}
			else
			{
				this.modev3.ForeColor = Color.Gainsboro;
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.checkmode3.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005FB5 File Offset: 0x000041B5
		private void label10_Click(object sender, EventArgs e)
		{
			this.modes.Show();
			this.label10.Hide();
			this.label11.Show();
			this.panel102.Show();
			this.panel100.Hide();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005FF4 File Offset: 0x000041F4
		private void metroButton10_Click(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x368", "int", this.wingID.Value.ToString(), "");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006030 File Offset: 0x00004230
		private void metroButton4_Click(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x26C", "int", this.punchID.Value.ToString(), "");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000606C File Offset: 0x0000426C
		private void metroButton5_Click(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				MessageBox.Show("Run growtopia before resizing it. Also use this on the start menu to not get bugs.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				IntPtr growtopiasize = Process.GetProcessesByName("Growtopia")[0].MainWindowHandle;
				TrainerBase.MoveWindow(growtopiasize, 0, 0, (int)this.gtWidth.Value, (int)this.gtHeight.Value, true);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000060F8 File Offset: 0x000042F8
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			bool @checked = this.savebox.Checked;
			if (@checked)
			{
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000611C File Offset: 0x0000431C
		private void panel75_Click(object sender, EventArgs e)
		{
			bool flag = this.modev2.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode2.Checked = true;
			}
			bool flag2 = this.modev2.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode2.Checked = false;
			}
			bool @checked = this.checkmode2.Checked;
			if (@checked)
			{
				this.modev2.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode2.Checked = false;
				this.modelabel.Text = "Mode : v2";
			}
			else
			{
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode2.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006244 File Offset: 0x00004444
		private void panel83_Click(object sender, EventArgs e)
		{
			bool flag = this.modev3.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode3.Checked = true;
			}
			bool flag2 = this.modev3.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode3.Checked = false;
			}
			bool @checked = this.checkmode3.Checked;
			if (@checked)
			{
				this.modev3.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.checkmode3.Checked = false;
				this.modelabel.Text = "Mode : v3";
			}
			else
			{
				this.modev3.ForeColor = Color.Gainsboro;
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.checkmode3.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006369 File Offset: 0x00004569
		private void panel100_Click(object sender, EventArgs e)
		{
			this.modes.Hide();
			this.label10.Show();
			this.label11.Hide();
			this.panel100.Hide();
			this.panel102.Show();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000063A8 File Offset: 0x000045A8
		private void panel102_Click(object sender, EventArgs e)
		{
			this.modes.Show();
			this.label10.Hide();
			this.label11.Show();
			this.panel102.Hide();
			this.panel100.Show();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel83_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000063E8 File Offset: 0x000045E8
		private void panel38_Click(object sender, EventArgs e)
		{
			bool flag = this.modev1.ForeColor == Color.Gainsboro;
			if (flag)
			{
				this.checkmode1.Checked = true;
			}
			bool flag2 = this.modev1.ForeColor == Color.FromArgb(0, 98, 163);
			if (flag2)
			{
				this.checkmode1.Checked = false;
			}
			bool @checked = this.checkmode1.Checked;
			if (@checked)
			{
				this.modev1.ForeColor = Color.FromArgb(0, 98, 163);
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode1.Checked = false;
				this.modelabel.Text = "Mode : v1";
			}
			else
			{
				this.modev1.ForeColor = Color.Gainsboro;
				this.modev2.ForeColor = Color.Gainsboro;
				this.modev3.ForeColor = Color.Gainsboro;
				this.checkmode1.Checked = true;
				this.modelabel.Text = "Mode :";
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006510 File Offset: 0x00004710
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox6.Checked;
			if (@checked)
			{
				this.cfgform.cbox6.Value = 1m;
			}
			else
			{
				this.cfgform.cbox6.Value = 0m;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006560 File Offset: 0x00004760
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox7.Checked;
			if (@checked)
			{
				this.cfgform.cbox7.Value = 1m;
			}
			else
			{
				this.cfgform.cbox7.Value = 0m;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroButton18_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000065B0 File Offset: 0x000047B0
		private void metroButton6_Click(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x35C", "int", this.hatID.Value.ToString(), "");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000065EC File Offset: 0x000047EC
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x30CD87", "bytes", "90 90 90 90 90 90", "");
				this.m.writeMemory("base+0x2B8C71", "bytes", "0F 85 F5 00 00 00", "");
				this.m.writeMemory("base+0x2BA297", "bytes", "90 90", "");
				this.m.writeMemory("base+0xCBBE1", "bytes", "90 90 90 90", "");
				this.m.writeMemory("base+0x2B08E4", "bytes", "90 90 90 90 90", "");
				this.m.writeMemory("base+0x2FBD85", "bytes", "90 90", "");
			}
			else
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x30CD87", "bytes", "0F 84 91 00 00 00", "");
				this.m.writeMemory("base+0x2B8C71", "bytes", "0F 84 F5 00 00 00", "");
				this.m.writeMemory("base+0x2BA297", "bytes", "74 7E", "");
				this.m.writeMemory("base+0xCBBE1", "bytes", "F3 0F 11 11", "");
				this.m.writeMemory("base+0x2B08E4", "bytes", "F3 0F 11 53 20", "");
				this.m.writeMemory("base+0x2FBD85", "bytes", "75 0B", "");
			}
			bool checked2 = this.checkBox4.Checked;
			if (checked2)
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x30D463", "bytes", "90 90", "");
				this.m.writeMemory("base+0x2C566B", "bytes", "0f 84", "");
				this.m.writeMemory("base+0x2B8527", "bytes", "0f 84", "");
				this.m.writeMemory("base+0x1EAC0F", "bytes", "0f 84", "");
				this.m.writeMemory("base+0xCBBE1", "bytes", "90 90 90 90", "");
				this.m.writeMemory("base+0x2B08E4", "bytes", "90 90 90 90 90", "");
				this.m.writeMemory("Growtopia.exe+0x005469C8,0xb68,0x188,0x200", "int", "2", "");
			}
			else
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x30D463", "bytes", "75 25", "");
				this.m.writeMemory("base+0x2C566B", "bytes", "0f 85", "");
				this.m.writeMemory("base+0x2B8527", "bytes", "0f 85", "");
				this.m.writeMemory("base+0x1EAC0F", "bytes", "0f 85", "");
				this.m.writeMemory("base+0xCBBE1", "bytes", "f3 0f 11 11", "");
				this.m.writeMemory("base+0x2B08E4", "bytes", "f3 0f 11 53 20", "");
				this.m.writeMemory("Growtopia.exe+0x005469C8,0xb68,0x188,0x200", "int", "0", "");
			}
			bool checked3 = this.checkBox29.Checked;
			if (checked3)
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x2BCCFB", "bytes", "90 90 90 90 90 90 90", "");
			}
			else
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("base+0x2BCCFB", "bytes", "48 8D 15 5E 24 1B 00", "");
			}
			bool checked4 = this.savebox.Checked;
			if (checked4)
			{
				this.m.writeMemory("base+0x1DF228", "bytes", "90 90", "");
				this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x35C", "int", this.hatID.Value.ToString(), "");
				this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x36C", "int", this.neckID.Value.ToString(), "");
				this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x364", "int", this.eyeID.Value.ToString(), "");
				this.m.writeMemory("Growtopia.exe+0x005469C8,0xB68,0x188,0x360", "int", this.pantsID.Value.ToString(), "");
				this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x368", "int", this.wingID.Value.ToString(), "");
				this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x26C", "int", this.punchID.Value.ToString(), "");
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label16_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006BE4 File Offset: 0x00004DE4
		private void savebox_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.savebox.Checked;
			if (@checked)
			{
				this.cfgform.savebox2.Value = 1m;
			}
			else
			{
				this.cfgform.savebox2.Value = 0m;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000020F0 File Offset: 0x000002F0
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel48_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel47_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel46_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel45_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroButton9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroButton8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006C34 File Offset: 0x00004E34
		private void metroButton7_Click(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x36C", "int", this.neckID.Value.ToString(), "");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroTextbox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel129_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel128_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel51_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel50_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel49_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroButton11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006C70 File Offset: 0x00004E70
		private void metroButton12_Click(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x005469C8,0xB68,0x188,0x360", "int", this.pantsID.Value.ToString(), "");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroButton13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000020F0 File Offset: 0x000002F0
		private void panel117_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000020F0 File Offset: 0x000002F0
		private void address_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006CAC File Offset: 0x00004EAC
		private void metroButton18_Click_1(object sender, EventArgs e)
		{
			this.m.writeMemory("Growtopia.exe+0x00545D28,0x538,0x188,0x364", "int", this.eyeID.Value.ToString(), "");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000020F0 File Offset: 0x000002F0
		private void checkmode1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006CE8 File Offset: 0x00004EE8
		private void puncheffect_Validated(object sender, EventArgs e)
		{
			bool flag = this.punchID.Text == "";
			if (flag)
			{
				this.punchID.Text = "0";
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006D24 File Offset: 0x00004F24
		private void backID_Validated(object sender, EventArgs e)
		{
			bool flag = this.wingID.Text == "";
			if (flag)
			{
				this.wingID.Text = "0";
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006D60 File Offset: 0x00004F60
		private void handID_Validated(object sender, EventArgs e)
		{
			bool flag = this.handID.Text == "";
			if (flag)
			{
				this.handID.Text = "0";
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006D9C File Offset: 0x00004F9C
		private void pantsID_Validated(object sender, EventArgs e)
		{
			bool flag = this.pantsID.Text == "";
			if (flag)
			{
				this.pantsID.Text = "0";
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006DD8 File Offset: 0x00004FD8
		private void bootsID_Validated(object sender, EventArgs e)
		{
			bool flag = this.bootsID.Text == "";
			if (flag)
			{
				this.bootsID.Text = "0";
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006E14 File Offset: 0x00005014
		private void FaceID_Validated(object sender, EventArgs e)
		{
			bool flag = this.hatID.Text == "";
			if (flag)
			{
				this.hatID.Text = "0";
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006E50 File Offset: 0x00005050
		private void neckID_Validated(object sender, EventArgs e)
		{
			bool flag = this.neckID.Text == "";
			if (flag)
			{
				this.neckID.Text = "0";
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006E8C File Offset: 0x0000508C
		private void headID_Validated(object sender, EventArgs e)
		{
			bool flag = this.hairID.Text == "";
			if (flag)
			{
				this.hairID.Text = "0";
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006EC8 File Offset: 0x000050C8
		private void shirtID_Validated(object sender, EventArgs e)
		{
			bool flag = this.shirtID.Text == "";
			if (flag)
			{
				this.shirtID.Text = "0";
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006F04 File Offset: 0x00005104
		private void skincolor_Validated(object sender, EventArgs e)
		{
			bool flag = this.eyeID.Text == "";
			if (flag)
			{
				this.eyeID.Text = "0";
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006F3E File Offset: 0x0000513E
		private void Toggle(CheckBox checkbox)
		{
			checkbox.Checked = !checkbox.Checked;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000020F0 File Offset: 0x000002F0
		private void TrainerBase_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000020F0 File Offset: 0x000002F0
		private void TrainerBase_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006F54 File Offset: 0x00005154
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.cfgform.cbox1.Value = 1m;
			}
			else
			{
				this.cfgform.cbox1.Value = 0m;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label2_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label26_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label28_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label36_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label37_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006FA4 File Offset: 0x000051A4
		private void metroButton25_Click(object sender, EventArgs e)
		{
			for (int gaybitch54353 = 0; gaybitch54353 < this.playerlist.Items.Count; gaybitch54353++)
			{
				this.playerlist.SetSelected(gaybitch54353, true);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00006FE4 File Offset: 0x000051E4
		private void metroButton20_Click_1(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				MessageBox.Show("Run growtopia before using the functions.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007034 File Offset: 0x00005234
		private void metroButton24_Click(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				MessageBox.Show("Run growtopia before using the functions.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007084 File Offset: 0x00005284
		private void metroButton21_Click_1(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				MessageBox.Show("Run growtopia before using the functions.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000070D4 File Offset: 0x000052D4
		private void metroButton22_Click(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				MessageBox.Show("Run growtopia before using the functions.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007123 File Offset: 0x00005323
		private void label52_Click(object sender, EventArgs e)
		{
			this.address.Show();
			this.address2.Hide();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000713E File Offset: 0x0000533E
		private void label51_Click(object sender, EventArgs e)
		{
			this.address2.Show();
			this.address.Hide();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label54_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000715C File Offset: 0x0000535C
		private void checkBox15_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox15.Checked;
			if (@checked)
			{
				this.cfgform.cbox15.Value = 1m;
			}
			else
			{
				this.cfgform.cbox15.Value = 0m;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000071AC File Offset: 0x000053AC
		private void checkBox44_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox44.Checked;
			if (@checked)
			{
				this.cfgform.cbox44.Value = 1m;
			}
			else
			{
				this.cfgform.cbox44.Value = 0m;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000071FC File Offset: 0x000053FC
		private void checkBox29_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox29.Checked;
			if (@checked)
			{
				this.cfgform.cbox29.Value = 1m;
			}
			else
			{
				this.cfgform.cbox29.Value = 0m;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000724C File Offset: 0x0000544C
		private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.checkBox2.Checked;
			if (@checked)
			{
				this.cfgform.cbox2.Value = 1m;
			}
			else
			{
				this.cfgform.cbox2.Value = 0m;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000729C File Offset: 0x0000549C
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox5.Checked;
			if (@checked)
			{
				this.cfgform.cbox5.Value = 1m;
			}
			else
			{
				this.cfgform.cbox5.Value = 0m;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000072EC File Offset: 0x000054EC
		private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				this.cfgform.cbox3.Value = 1m;
			}
			else
			{
				this.cfgform.cbox3.Value = 0m;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000733C File Offset: 0x0000553C
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox8.Checked;
			if (@checked)
			{
				this.cfgform.cbox8.Value = 1m;
			}
			else
			{
				this.cfgform.cbox8.Value = 0m;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000738C File Offset: 0x0000558C
		private void metroButton27_Click(object sender, EventArgs e)
		{
			bool flag = Directory.Exists(this.gtpath.Text);
			if (flag)
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				path += "\\growsense\\resources";
				bool flag2 = !Directory.Exists(path);
				if (flag2)
				{
					Directory.CreateDirectory(path);
				}
				path += "\\GtPath.txt";
				string shit = this.gtpath.Text;
				File.WriteAllText(path, shit);
			}
			else
			{
				MessageBox.Show("Directory doesn't exist.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000020F0 File Offset: 0x000002F0
		private void settings_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006BD7 File Offset: 0x00004DD7
		private void label58_Click(object sender, EventArgs e)
		{
			Environment.Exit(2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000020F0 File Offset: 0x000002F0
		private void metroTextbox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000020F0 File Offset: 0x000002F0
		private void label45_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000740E File Offset: 0x0000560E
		private void metroButton28_Click(object sender, EventArgs e)
		{
			this.multiboxing.Show();
			this.settings.Hide();
		}

		// Token: 0x06000092 RID: 146
		[DllImport("kernel32.dll")]
		public static extern int CloseHandle(IntPtr hObject);

		// Token: 0x06000093 RID: 147
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x06000094 RID: 148
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x06000095 RID: 149
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x06000096 RID: 150 RVA: 0x0000742C File Offset: 0x0000562C
		private void SuspendProcess(Process process)
		{
			foreach (object obj in process.Threads)
			{
				ProcessThread pT = (ProcessThread)obj;
				IntPtr pOpenThread = TrainerBase.OpenThread(2, false, (uint)pT.Id);
				bool flag = pOpenThread == IntPtr.Zero;
				if (!flag)
				{
					TrainerBase.SuspendThread(pOpenThread);
					TrainerBase.CloseHandle(pOpenThread);
				}
			}
			Console.WriteLine("SUSPENDED");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000074C0 File Offset: 0x000056C0
		private void ResumeProcess(Process process)
		{
			foreach (object obj in process.Threads)
			{
				ProcessThread pT = (ProcessThread)obj;
				IntPtr pOpenThread = TrainerBase.OpenThread(2, false, (uint)pT.Id);
				bool flag = pOpenThread == IntPtr.Zero;
				if (!flag)
				{
					int suspendCount;
					do
					{
						suspendCount = TrainerBase.ResumeThread(pOpenThread);
					}
					while (suspendCount > 0);
					TrainerBase.CloseHandle(pOpenThread);
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007558 File Offset: 0x00005758
		private void metroButton26_Click(object sender, EventArgs e)
		{
			bool flag = this.gtpath.Text == "";
			if (flag)
			{
				MessageBox.Show("Directory doesn't exist.", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				base.UseWaitCursor = true;
				Process[] gt = Process.GetProcessesByName("Growtopia");
				bool flag2 = gt.Length == 0;
				if (flag2)
				{
					Process.Start("C:/Users/" + Environment.UserName + "/Appdata/Local/Growtopia/Growtopia.exe");
				}
				else
				{
					bool flag3 = gt.Length >= 1;
					if (flag3)
					{
						for (int i = 0; i < gt.Length; i++)
						{
							TrainerBase.PID = gt[i].Id;
							Process.Start("C:/Users/" + Environment.UserName + "/Desktop/growsense/resources/dummy.exe", TrainerBase.PID.ToString());
							this.SuspendProcess(gt[i]);
						}
						for (int j = 0; j <= 10000000; j++)
						{
							int gigel = 0;
							foreach (Process p in Process.GetProcesses())
							{
								bool flag4 = p.ProcessName == "dummy";
								if (flag4)
								{
									gigel++;
								}
							}
							bool flag5 = gigel == 0;
							if (flag5)
							{
								break;
							}
							Thread.Sleep(200);
						}
						Thread.Sleep(200);
						Process.Start("C:/Users/" + Environment.UserName + "/Appdata/Local/Growtopia/Growtopia.exe");
						Thread.Sleep(2000);
						for (int k = 0; k < gt.Length; k++)
						{
							this.ResumeProcess(gt[k]);
						}
					}
				}
				base.UseWaitCursor = false;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000771C File Offset: 0x0000591C
		private async void hardwareid_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.hwid);
			this.hardwareid.Text = "Copied to clipboard.";
			await Task.Delay(800);
			this.hardwareid.Text = this.hwid;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007768 File Offset: 0x00005968
		private async void computername_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.pcname);
			this.computername.Text = "Copied to clipboard.";
			await Task.Delay(800);
			this.computername.Text = this.pcname;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000077B4 File Offset: 0x000059B4
		private void metroButton3_Click(object sender, EventArgs e)
		{
			Process[] gt = Process.GetProcessesByName("Growtopia");
			bool flag = gt.Length >= 1;
			if (flag)
			{
				for (int i = 0; i < gt.Length; i++)
				{
					gt[i].Kill();
				}
			}
			else
			{
				MessageBox.Show("No running growtopia's", "growsense", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007810 File Offset: 0x00005A10
		private void gtchecker_Tick(object sender, EventArgs e)
		{
			Process[] fdas65435345345 = Process.GetProcessesByName("Growtopia");
			int openedgts = fdas65435345345.Length;
			this.openedgrowtopias.Text = openedgts.ToString();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007840 File Offset: 0x00005A40
		private void processcheck_Tick(object sender, EventArgs e)
		{
			int pID = this.m.getProcIDFromName("Growtopia");
			bool sucess = this.m.OpenProcess(pID);
			bool flag = !sucess;
			if (flag)
			{
				this.hackloader.Stop();
			}
			else
			{
				this.hackloader.Start();
				this.processcheck.Stop();
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000078A0 File Offset: 0x00005AA0
		private void processcheck2_Tick(object sender, EventArgs e)
		{
			bool enabled = this.processcheck.Enabled;
			if (!enabled)
			{
				int pID = this.m.getProcIDFromName("Growtopia");
				bool sucess = this.m.OpenProcess(pID);
				bool flag = !sucess;
				if (flag)
				{
					this.processcheck.Start();
				}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007900 File Offset: 0x00005B00
		private void configsbox_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.configsbox.SelectedItem != null;
			if (flag)
			{
				this.configname.Text = this.configsbox.SelectedItem.ToString();
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007944 File Offset: 0x00005B44
		private void sets_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.sets.SelectedItem != null;
			if (flag)
			{
				this.settname.Text = this.sets.SelectedItem.ToString();
			}
		}

		// Token: 0x04000035 RID: 53
		private Form1 cfgform = new Form1();

		// Token: 0x04000036 RID: 54
		public const int GWL_EXSTYLE = -20;

		// Token: 0x04000037 RID: 55
		public const int WS_EX_LAYERED = 524288;

		// Token: 0x04000038 RID: 56
		public const int LWA_ALPHA = 2;

		// Token: 0x04000039 RID: 57
		public const int LWA_COLORKEY = 1;

		// Token: 0x0400003A RID: 58
		public Mem m = new Mem();

		// Token: 0x0400003B RID: 59
		private string pcname = SystemInformation.ComputerName;

		// Token: 0x0400003C RID: 60
		private string pcuser = SystemInformation.UserName.ToString();

		// Token: 0x0400003D RID: 61
		private string hwid = TrainerBase.GetHWID();

		// Token: 0x0400003E RID: 62
		public static int PID;

		// Token: 0x0400003F RID: 63
		public static int pid2;

		// Token: 0x0200000B RID: 11
		public enum fsModifiers
		{
			// Token: 0x040001BB RID: 443
			None,
			// Token: 0x040001BC RID: 444
			Alt,
			// Token: 0x040001BD RID: 445
			CTRL,
			// Token: 0x040001BE RID: 446
			Shift = 4,
			// Token: 0x040001BF RID: 447
			WinKey = 8
		}
	}
}
