using Enzo;
using FAST_MEMORY;
using Gma.System.MouseKeyHook;
using Guna.UI2.WinForms;
using KeyAuth;
using Nazmulscope;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PhantomXiters
{
    public partial class Form1 : Form
    {
        // ==================== KEYAUTH ====================
        public static api KeyAuthApp = new api(
            name: "Vishnutam2011's Application",
            ownerid: "Smzcr2taZM",
            secret: "0bce89088f4f5f88d45fdbde441c6d1f270a9a91ab00b8fd31900cfbb25baaf7",
            version: "1.0"
        );

        // ==================== MEMORY CLASSES ====================
        private nazmulexe nazmulscope = new nazmulexe();
        private FastMemory hackMem = new FastMemory();
        private EnzoMem Memory = new EnzoMem();

        // ==================== AIMBOT ====================
        private string[] TaskName = new string[] { "HD-Player" };
        private string AimbotPattern = "FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 A5 43";
        private long ReadOffset = 0xB8;
        private long WriteOffset = 0xB4;

        private readonly Dictionary<long, byte[]> OriginalValue1 = new Dictionary<long, byte[]>();
        private readonly Dictionary<long, byte[]> OriginalValue2 = new Dictionary<long, byte[]>();
        private readonly Dictionary<long, byte[]> ReplacedValue1 = new Dictionary<long, byte[]>();
        private readonly Dictionary<long, byte[]> ReplacedValue2 = new Dictionary<long, byte[]>();
        private bool AimbotToggle = false;

        // ==================== SNIPER SCOPE ====================
        private bool sniperLoaded = false;
        private bool sniperKeySet = false;
        private Keys scopeKey = Keys.None;
        private IKeyboardMouseEvents scopeHook;
        private int ScopeDelay = 85;
        private List<long> sniperAddresses = new List<long>();
        private string sniperSearch = "FF FF FF FF 08 00 00 00 00 00 60 40 CD CC 8C 3F 8F C2 F5 3C CD CC CC 3D 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F 33 33 13 40";
        private string sniperReplace = "FF FF FF FF 08 00 00 00 00 00 60 40 CD CC 8C 3F 8F C2 F5 3C CD CC CC 3D 06 00 00 00 00 00 00 3E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 33 33 13 40";
        private FastMemory sniperMem = new FastMemory();

        // ==================== SNIPER SWITCH ====================
        private List<long> switchAddresses = new List<long>();
        private string switchSearch = "3F 00 00 80 3E 00 00 00 00 04 00 00 00 00 00 80 3F 00 00 20 41 00 00 34 42 01 00 00 00 01 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F";
        private string switchReplace = "1A 00 00 80 1A 00 00 00 00 04 00 00 00 00 00 80 3F 00 00 20 41 00 00 34 42 01 00 00 00 01 00 00 00 00 00 00 00 00 00 00 00 00 00 80 3F";

        // ==================== GLITCH FIRE ====================
        private List<long> glitchAddresses = new List<long>();
        private string glitchSearch = "C0 41 00 00 10 C1 00 00 90 C1 00 00 70 41 01 00 00 00 00 00 C0 3F 00 00 00 3F 00 00 80 3F 00 00 80 3F";
        private string glitchReplace = "C0 41 00 00 10 C1 00 00 90 C1 00 00 70 41 01 00 00 00 00 00 C0 00 00 00 00 3C 00 00 80 3F 00 00 80 3F";

        // ==================== GUEST RESET ====================
        private List<long> guestAddresses = new List<long>();
        private string guestSearch = "10 40 2D E9 D0 40 9F E5 04 40 8F E0 00 00 D4 E5 00 00 50 E3 04 00 00 1A C0 00 9F E5 00 00 9F E7 A9 36 A9 EB";
        private string guestReplace = "01 00 A0 E3 1E FF 2F E1 04 40 8F E0 00 00 D4 E5 00 00 50 E3 04 00 00 1A C0 00 9F E5 00 00 9F E7 A9 36 A9 EB";

        // ==================== VISION HACK ====================
        private List<long> visionAddresses = new List<long>();
        private string visionSearch = "B4 43 DB 0F 49 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE 14 10 80 E5 00 2A 30 EE 00 10 00 E3 41 3A 30 EE";
        private string visionReplace = "B4 43 DB 0F 78 40 10 2A 00 EE 00 10 80 E5 10 3A 01 EE 14 10 80 E5 00 2A 30 EE 00 10 00 E3 41 3A 30 EE";

        // ==================== CHAMS DLL INJECTION ====================
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        private const uint PROCESS_CREATE_THREAD = 0x2;
        private const uint PROCESS_QUERY_INFORMATION = 0x400;
        private const uint PROCESS_VM_OPERATION = 0x8;
        private const uint PROCESS_VM_WRITE = 0x20;
        private const uint PROCESS_VM_READ = 0x10;
        private const uint MEM_COMMIT = 0x1000;
        private const uint PAGE_READWRITE = 0x4;
        private const string DLL_RESOURCE_NAME = "PhantomXiters.IrfanXiters.dll";
        private const string DLL_NAME = "VXCorporation.dll";
        private bool isChamsInjected = false;

        // ==================== STATE VARIABLES ====================
        private bool waitPressKey = false;
        public static bool Streaming;
        private Timer mouseCheckTimer;
        private bool isChamsActive = false;

        public Form1()
        {
            InitializeComponent();

            SoundPlayer player = new SoundPlayer(Properties.Resources.RegisterSuccess);
            player.Play();

            System.Diagnostics.Process.Start("https://discord.gg/kRNRYkwbuq");

            sniperKeySet = false;

            LoginPnl.Show();
            AimBotMenu.Hide();
            EspPanel.Hide();
            SettingsPanel.Hide();

            Memory.Initialize();
        }

        // ==================== FORM LOAD ====================
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPnl.Show();
            AimBotMenu.Hide();
            EspPanel.Hide();
            SettingsPanel.Hide();
        }

        // ==================== LOGIN BUTTON ====================
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
                {
                    S.Text = "⚠️ Enter Username & Password!";
                    return;
                }

                S.Text = "⏳ Connecting...";
                guna2Button1.Enabled = false;
                guna2Button1.Text = "⏳ WAIT...";

                KeyAuthApp.init();
                KeyAuthApp.login(username.Text, password.Text);

                if (KeyAuthApp.response.success)
                {
                    S.Text = "✅ LOGIN SUCCESS!";

                    LoginPnl.Hide();
                    guna2Button1.Enabled = true;
                    guna2Button1.Text = "LOGIN";

                    AimBotMenu.Show();
                    EspPanel.Hide();
                    SettingsPanel.Hide();

                    await Task.Delay(100);

                    SoundPlayer player = new SoundPlayer(Properties.Resources.Startup);
                    player.Play();
                }
                else
                {
                    S.Text = "❌ Login failed: " + KeyAuthApp.response.message;
                    guna2Button1.Enabled = true;
                    guna2Button1.Text = "LOGIN";
                    MessageBox.Show("Login failed: " + KeyAuthApp.response.message);
                }
            }
            catch (Exception ex)
            {
                S.Text = "❌ Error: " + ex.Message;
                guna2Button1.Enabled = true;
                guna2Button1.Text = "LOGIN";
                MessageBox.Show("Error during initialization or login: " + ex.Message);
            }
        }

        // ==================== PANEL NAVIGATION ====================
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AimBotMenu.Show();
            EspPanel.Hide();
            SettingsPanel.Hide();
            AimBotMenu.Location = new Point(126, 53);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AimBotMenu.Hide();
            EspPanel.Show();
            SettingsPanel.Hide();
            EspPanel.Location = new Point(126, 53);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AimBotMenu.Hide();
            EspPanel.Hide();
            SettingsPanel.Show();
            SettingsPanel.Location = new Point(126, 53);
        }

        // ==================== CLOSE / MINIMIZE ====================
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ==================== STREAMER MODE ====================
        private void guna2CustomCheckBox9_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox9.Checked)
            {
                this.ShowInTaskbar = false;
                Streaming = true;
                SetWindowDisplayAffinity(this.Handle, 17U);
                S.Text = "🎥 Streamer Mode ON";
            }
            else
            {
                this.ShowInTaskbar = true;
                Streaming = false;
                SetWindowDisplayAffinity(this.Handle, 0U);
                S.Text = "🎥 Streamer Mode OFF";
            }
        }

        // ==================== PIN ON TOP ====================
        private async void guna2CustomCheckBox7_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    this.TopMost = guna2CustomCheckBox7.Checked;
                    S.Text = guna2CustomCheckBox7.Checked ? "📌 Pinned ON TOP" : "📌 Pinned OFF";
                }));
            });
        }

        // ==================== KEYBIND SETUP ====================
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            waitPressKey = true;
            guna2Button6.Text = "⌨";
            S.Text = "⏳ Press any key...";
        }

        // ==================== SNIPER SCOPE KEYBIND ====================
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn == null) return;

            btn.Text = "...";
            S.Text = "Press key for Scope... (ESC to cancel)";
            S.ForeColor = Color.Yellow;

            scopeHook?.Dispose();
            var tempHook = Hook.GlobalEvents();
            tempHook.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Escape)
                {
                    btn.Text = scopeKey == Keys.None ? "-" : scopeKey.ToString().Replace("D", "");
                    S.Text = "Cancelled";
                    S.ForeColor = Color.Gray;
                    tempHook.Dispose();
                    return;
                }

                if (ev.KeyCode != Keys.ShiftKey && ev.KeyCode != Keys.ControlKey && ev.KeyCode != Keys.Menu)
                {
                    scopeKey = ev.KeyCode;
                    sniperKeySet = true;
                    btn.Text = scopeKey.ToString().Replace("D", "");
                    S.Text = $"✅ Scope Key: {scopeKey}";
                    S.ForeColor = Color.Lime;
                    tempHook.Dispose();

                    guna2CustomCheckBox2.Enabled = true;

                    scopeHook?.Dispose();
                    scopeHook = Hook.GlobalEvents();
                    scopeHook.KeyDown += async (s2, ev2) =>
                    {
                        if (ev2.KeyCode == scopeKey && sniperLoaded && sniperAddresses.Count > 0)
                        {
                            byte[] replaceBytes = ParseHexToBytes(sniperReplace);
                            foreach (var addr in sniperAddresses)
                                sniperMem.WriteBytes(addr, replaceBytes);

                            S.Text = $"🔭 Scope ON ({ScopeDelay}ms)";
                            S.ForeColor = Color.Cyan;

                            await Task.Delay(ScopeDelay);

                            byte[] originalBytes = ParseHexToBytes(sniperSearch);
                            foreach (var addr in sniperAddresses)
                                sniperMem.WriteBytes(addr, originalBytes);

                            S.Text = "⚡ Scope OFF - Ready";
                            S.ForeColor = Color.Gray;
                        }
                    };
                }
            };
        }

        // ==================== SNIPER SCOPE CHECKBOX ====================
        private async void guna2CustomCheckBox2_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox2.Checked)
            {
                if (!sniperKeySet || scopeKey == Keys.None)
                {
                    S.Text = "⚠️ Set a keybind first!";
                    S.ForeColor = Color.Orange;
                    guna2CustomCheckBox2.Checked = false;
                    return;
                }

                if (!sniperMem.OpenProcess("HD-Player"))
                {
                    S.Text = "❌ Emulator Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox2.Checked = false;
                    return;
                }

                S.Text = "⏳ Scanning...";
                S.ForeColor = Color.Yellow;

                var result = await sniperMem.ScanPattern(sniperSearch);
                sniperAddresses = result.ToList();

                if (sniperAddresses.Count > 0)
                {
                    sniperLoaded = true;
                    byte[] rep = ParseHexToBytes(sniperReplace);
                    foreach (var addr in sniperAddresses)
                        sniperMem.WriteBytes(addr, rep);

                    S.Text = $"✅ Sniper Scope ON — Press {scopeKey} to use";
                    S.ForeColor = Color.Lime;
                }
                else
                {
                    S.Text = "❌ Pattern Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox2.Checked = false;
                }
            }
            else
            {
                byte[] originalBytes = ParseHexToBytes(sniperSearch);
                foreach (var addr in sniperAddresses)
                    sniperMem.WriteBytes(addr, originalBytes);

                sniperAddresses.Clear();
                sniperLoaded = false;
                S.Text = "🔴 Sniper Scope OFF";
                S.ForeColor = Color.Gray;
            }
        }

        // ==================== SNIPER SWITCH ====================
        private async void guna2CustomCheckBox3_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox3.Checked)
            {
                if (!nazmulscope.SetProcess(new string[] { "HD-Player", "aow_exe", "MsiPlayer" }))
                {
                    S.Text = "❌ Emulator Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox3.Checked = false;
                    return;
                }

                S.Text = "⏳ Scanning...";
                S.ForeColor = Color.Yellow;

                var result = await nazmulscope.AoBScan(switchSearch);
                switchAddresses = result.Distinct().ToList();

                if (switchAddresses.Count > 0)
                {
                    foreach (var addr in switchAddresses)
                        nazmulscope.AobReplace(addr, switchReplace);

                    S.Text = "✅ Sniper Switch ON";
                    S.ForeColor = Color.Lime;
                }
                else
                {
                    S.Text = "❌ Pattern Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox3.Checked = false;
                }
            }
            else
            {
                foreach (var addr in switchAddresses)
                    nazmulscope.AobReplace(addr, switchSearch);

                switchAddresses.Clear();
                S.Text = "🔴 Sniper Switch OFF";
                S.ForeColor = Color.Gray;
            }
        }

        // ==================== GLITCH FIRE ====================
        private async void guna2CustomCheckBox4_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox4.Checked)
            {
                if (!hackMem.OpenProcess("HD-Player"))
                {
                    S.Text = "❌ Emulator Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox4.Checked = false;
                    return;
                }

                S.Text = "⏳ Scanning...";
                S.ForeColor = Color.Yellow;

                var result = await hackMem.ScanAndReplace(glitchSearch, glitchReplace);
                glitchAddresses = result.addresses;

                if (glitchAddresses.Count > 0)
                {
                    S.Text = "✅ Glitch Fire ON";
                    S.ForeColor = Color.Lime;
                }
                else
                {
                    S.Text = "❌ Pattern Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox4.Checked = false;
                }
            }
            else
            {
                byte[] originalBytes = ParseHexToBytes(glitchSearch);
                foreach (var addr in glitchAddresses)
                    hackMem.WriteBytes(addr, originalBytes);

                glitchAddresses.Clear();
                S.Text = "🔴 Glitch Fire OFF";
                S.ForeColor = Color.Gray;
            }
        }

        // ==================== GUEST RESET ====================
        private async void guna2CustomCheckBox8_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox8.Checked)
            {
                if (!hackMem.OpenProcess("HD-Player"))
                {
                    S.Text = "❌ Emulator Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox8.Checked = false;
                    return;
                }

                S.Text = "⏳ Scanning...";
                S.ForeColor = Color.Yellow;

                var result = await hackMem.ScanAndReplace(guestSearch, guestReplace);
                guestAddresses = result.addresses;

                if (guestAddresses.Count > 0)
                {
                    S.Text = "✅ Guest Reset Done";
                    S.ForeColor = Color.Lime;
                }
                else
                {
                    S.Text = "❌ Pattern Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox8.Checked = false;
                }
            }
            else
            {
                byte[] originalBytes = ParseHexToBytes(guestSearch);
                foreach (var addr in guestAddresses)
                    hackMem.WriteBytes(addr, originalBytes);

                guestAddresses.Clear();
                S.Text = "🔴 Guest Reset OFF";
                S.ForeColor = Color.Gray;
            }
        }

        // ==================== VISION HACK CHECKBOX ====================
        private async void guna2CustomCheckBox5_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox5.Checked)
            {
                if (!hackMem.OpenProcess("HD-Player"))
                {
                    S.Text = "❌ Emulator Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox5.Checked = false;
                    return;
                }

                S.Text = "⏳ Scanning...";
                S.ForeColor = Color.Yellow;

                var result = await hackMem.ScanAndReplace(visionSearch, visionReplace);
                visionAddresses = result.addresses;

                if (visionAddresses.Count > 0)
                {
                    S.Text = "✅ Vision Hack ON";
                    S.ForeColor = Color.Magenta;
                }
                else
                {
                    S.Text = "❌ Pattern Not Found!";
                    S.ForeColor = Color.Red;
                    guna2CustomCheckBox5.Checked = false;
                }
            }
            else
            {
                byte[] originalBytes = ParseHexToBytes(visionSearch);
                foreach (var addr in visionAddresses)
                    hackMem.WriteBytes(addr, originalBytes);

                visionAddresses.Clear();
                S.Text = "🔴 Vision Hack OFF";
                S.ForeColor = Color.Gray;
            }
        }

        // ==================== UPDATE LABEL ====================
        private void UpdateLabel(string text, Color? color = null)
        {
            if (S.InvokeRequired)
            {
                S.Invoke(new Action(() => UpdateLabel(text, color)));
            }
            else
            {
                S.Text = text;
                if (color.HasValue)
                {
                    S.ForeColor = color.Value;
                }
            }
        }

        // ==================== RESTORE VALUES ====================
        private void RestoreValues(Dictionary<long, byte[]> dictionary)
        {
            foreach (var entry in dictionary)
            {
                int value = BitConverter.ToInt32(entry.Value, 0);
                Memory.WriteInt(entry.Key, value);
            }
        }

        // ==================== AIMBOT ON ====================
        public void AimbotON()
        {
            if (ReplacedValue1.Count == 0 && ReplacedValue2.Count == 0)
            {
                UpdateLabel("⚠️ Scan first!", Color.Orange);
                return;
            }

            RestoreValues(ReplacedValue1);
            RestoreValues(ReplacedValue2);
            UpdateLabel("✅ AIMBOT ENABLED", Color.Lime);
        }

        // ==================== AIMBOT OFF ====================
        public void AimbotOFF()
        {
            if (OriginalValue1.Count == 0 && OriginalValue2.Count == 0)
            {
                UpdateLabel("⚠️ Scan first!", Color.Orange);
                return;
            }

            RestoreValues(OriginalValue1);
            RestoreValues(OriginalValue2);
            UpdateLabel("🔴 AIMBOT DISABLED", Color.Gray);
        }

        // ==================== AIMBOT SCAN ====================
        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!Memory.SetProcess(TaskName))
            {
                MessageBox.Show("Process not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UpdateLabel("⏳ Scanning...", Color.Orange);
                Stopwatch sw = Stopwatch.StartNew();

                OriginalValue1.Clear();
                OriginalValue2.Clear();
                ReplacedValue1.Clear();
                ReplacedValue2.Clear();
                Memory.ClearScanCache();

                var addresses = await Memory.AoBScan(AimbotPattern);

                if (addresses == null || !addresses.Any())
                {
                    UpdateLabel("❌ Pattern Not Found!", Color.Red);
                    return;
                }

                foreach (long addr in addresses)
                {
                    long readAddr = addr + ReadOffset;
                    long writeAddr = addr + WriteOffset;

                    byte[] readBytes = Memory.ReadMemory(readAddr, 4);
                    byte[] writeBytes = Memory.ReadMemory(writeAddr, 4);

                    if (readBytes == null || writeBytes == null) continue;

                    int readValue = BitConverter.ToInt32(readBytes, 0);
                    int writeValue = BitConverter.ToInt32(writeBytes, 0);

                    OriginalValue1[writeAddr] = writeBytes;
                    OriginalValue2[readAddr] = readBytes;
                    ReplacedValue1[writeAddr] = BitConverter.GetBytes(readValue);
                    ReplacedValue2[readAddr] = BitConverter.GetBytes(writeValue);
                }

                sw.Stop();
                UpdateLabel($"✅ Aimbot Loaded! Toggle checkbox to enable.", Color.Green);
                AimbotToggle = false;
                guna2CustomCheckBox1.Enabled = true;
                guna2CustomCheckBox1.Checked = false;
                Console.Beep(2000, 400);
            }
            catch (Exception ex)
            {
                UpdateLabel($"❌ Error: {ex.Message}", Color.Red);
            }
        }

        // ==================== AIMBOT TOGGLE ====================
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                if (ReplacedValue1.Count == 0 && ReplacedValue2.Count == 0)
                {
                    UpdateLabel("⚠️ Scan first!", Color.Orange);
                    guna2CustomCheckBox1.Checked = false;
                    return;
                }

                RestoreValues(ReplacedValue1);
                RestoreValues(ReplacedValue2);
                AimbotToggle = true;
                UpdateLabel("✅ AIMBOT ENABLED", Color.Lime);
                Console.Beep(800, 200);
            }
            else
            {
                if (OriginalValue1.Count == 0 && OriginalValue2.Count == 0)
                {
                    UpdateLabel("⚠️ Scan first!", Color.Orange);
                    guna2CustomCheckBox1.Checked = true;
                    return;
                }

                RestoreValues(OriginalValue1);
                RestoreValues(OriginalValue2);
                AimbotToggle = false;
                UpdateLabel("🔴 AIMBOT DISABLED", Color.Gray);
                Console.Beep(400, 200);
            }
        }

        // ==================== CHAMS DLL INJECTION ====================
        private void ExtractEmbeddedResource(string resourceName, string outputPath)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            using (Stream resourceStream = executingAssembly.GetManifestResourceStream(resourceName))
            {
                if (resourceStream == null)
                    throw new ArgumentException($"Resource '{resourceName}' not found.");

                using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
                {
                    byte[] buffer = new byte[resourceStream.Length];
                    resourceStream.Read(buffer, 0, buffer.Length);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private bool InjectChamsDLL()
        {
            try
            {
                string tempDllPath = Path.Combine(Path.GetTempPath(), DLL_NAME);
                ExtractEmbeddedResource(DLL_RESOURCE_NAME, tempDllPath);

                Process[] targetProcesses = Process.GetProcessesByName("HD-Player");
                if (targetProcesses.Length == 0)
                {
                    UpdateLabel("⚠️ HD-Player not running!", Color.Orange);
                    return false;
                }

                Process targetProcess = targetProcesses[0];
                IntPtr hProcess = OpenProcess(
                    PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ,
                    false,
                    targetProcess.Id);

                if (hProcess == IntPtr.Zero)
                {
                    UpdateLabel("❌ Failed to open process! Run as Admin.", Color.Red);
                    return false;
                }

                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                if (loadLibraryAddr == IntPtr.Zero)
                {
                    UpdateLabel("❌ LoadLibraryA not found!", Color.Red);
                    return false;
                }

                IntPtr allocMemAddress = VirtualAllocEx(hProcess, IntPtr.Zero, (IntPtr)tempDllPath.Length + 1, MEM_COMMIT, PAGE_READWRITE);
                if (allocMemAddress == IntPtr.Zero)
                {
                    UpdateLabel("❌ Failed to allocate memory!", Color.Red);
                    return false;
                }

                byte[] dllPathBytes = Encoding.ASCII.GetBytes(tempDllPath + "\0");
                IntPtr bytesWritten;
                if (!WriteProcessMemory(hProcess, allocMemAddress, dllPathBytes, (uint)tempDllPath.Length + 1, out bytesWritten) || bytesWritten == IntPtr.Zero)
                {
                    UpdateLabel("❌ Failed to write DLL path!", Color.Red);
                    return false;
                }

                IntPtr hThread = CreateRemoteThread(hProcess, IntPtr.Zero, IntPtr.Zero, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
                if (hThread == IntPtr.Zero)
                {
                    UpdateLabel("❌ Failed to create remote thread!", Color.Red);
                    return false;
                }

                UpdateLabel("✅ VXCorporation.dll Injected!", Color.Lime);
                Console.Beep(240, 300);
                return true;
            }
            catch (Exception ex)
            {
                UpdateLabel($"❌ Chams Error: {ex.Message}", Color.Red);
                return false;
            }
        }

        // ==================== CHAMS MENU ====================
        private void guna2CustomCheckBox6_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox6.Checked)
            {
                if (!isChamsInjected)
                {
                    if (InjectChamsDLL())
                    {
                        isChamsInjected = true;
                        isChamsActive = true;
                        UpdateLabel("✅ Chams Activated!", Color.Lime);
                    }
                    else
                    {
                        guna2CustomCheckBox6.Checked = false;
                    }
                }
                else
                {
                    UpdateLabel("🔷 Chams already injected!", Color.Orange);
                }
            }
            else
            {
                UpdateLabel("🔷 Cannot be disabled (Inject only)", Color.Orange);
                guna2CustomCheckBox6.Checked = true;
            }
        }

        // ==================== MOUSE KEYBIND ====================
        private void MouseBtn_Click(object sender, EventArgs e)
        {
            if (MouseBtn.Checked)
            {
                if (mouseCheckTimer == null)
                {
                    mouseCheckTimer = new Timer();
                    mouseCheckTimer.Interval = 100;
                    mouseCheckTimer.Tick += (s, ev) => { };
                }
                mouseCheckTimer.Start();
                UpdateLabel("🖱️ Mouse Keybind ON", Color.Cyan);
            }
            else
            {
                mouseCheckTimer?.Stop();
                UpdateLabel("🖱️ Mouse Keybind OFF", Color.Gray);
            }
        }

        // ==================== HELPERS ====================
        private void UpdateStatus(string text, Color? color = null)
        {
            UpdateLabel(text, color);
        }

        private byte[] ParseHexToBytes(string hexString)
        {
            var parts = hexString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = new byte[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == "??" || parts[i] == "?")
                    bytes[i] = 0x00;
                else
                    bytes[i] = Convert.ToByte(parts[i], 16);
            }
            return bytes;
        }

        private byte[] ParseHex(string hex)
        {
            return ParseHexToBytes(hex);
        }

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        // ==================== EMPTY EVENTS ====================
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void SniperPanel_Paint(object sender, PaintEventArgs e) { }

        // ==================== FORM CLOSING ====================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            scopeHook?.Dispose();
            mouseCheckTimer?.Stop();

            // Restore Sniper Scope
            if (sniperAddresses.Count > 0)
            {
                byte[] originalBytes = ParseHexToBytes(sniperSearch);
                foreach (var addr in sniperAddresses)
                    sniperMem.WriteBytes(addr, originalBytes);
                sniperAddresses.Clear();
            }

            // Restore Sniper Switch
            if (switchAddresses.Count > 0)
            {
                foreach (var addr in switchAddresses)
                    nazmulscope.AobReplace(addr, switchSearch);
                switchAddresses.Clear();
            }

            // Restore Glitch Fire
            if (glitchAddresses.Count > 0)
            {
                byte[] originalBytes = ParseHexToBytes(glitchSearch);
                foreach (var addr in glitchAddresses)
                    hackMem.WriteBytes(addr, originalBytes);
                glitchAddresses.Clear();
            }

            // Restore Guest Reset
            if (guestAddresses.Count > 0)
            {
                byte[] originalBytes = ParseHexToBytes(guestSearch);
                foreach (var addr in guestAddresses)
                    hackMem.WriteBytes(addr, originalBytes);
                guestAddresses.Clear();
            }

            // Restore Vision Hack
            if (visionAddresses.Count > 0)
            {
                byte[] originalBytes = ParseHexToBytes(visionSearch);
                foreach (var addr in visionAddresses)
                    hackMem.WriteBytes(addr, originalBytes);
                visionAddresses.Clear();
            }

            // Restore Aimbot if active
            if (AimbotToggle)
            {
                RestoreValues(OriginalValue1);
                RestoreValues(OriginalValue2);
            }

            base.OnFormClosing(e);
        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}