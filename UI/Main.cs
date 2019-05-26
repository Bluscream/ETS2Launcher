using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using ETS2Launcher.Utils;
using IniParser.Model;
using System.Net;
using System.IO;

namespace ETS2Launcher
{
    public partial class Main : MaterialForm
    {
        public IniData config;
        public static WebClient webClient;
        private static MaterialSkinManager materialSkinManager;
        public TextBox statusBar;
        public Main() {
            Logger.Trace("START");
            config = Config.Load();

            var gameInSameDir = Setup.Game.CheckForGame();
            if (!gameInSameDir) SetupGame();
            Setup.URIResponse regKeyCorrect = Setup.URI.CheckURIRegistryKey();
            Logger.Trace("match=", regKeyCorrect.match.ToString());
            // if(regKeyCorrect.match != Setup.URIResponse.URIEnum.INSTALLED) SetupURI(regKeyCorrect.expected, regKeyCorrect.key);
            // richTextBox1.Text = "match: "+ regKeyCorrect.match.ToString() + "\n\nexpected: " + regKeyCorrect.expected + "\n\nkey: " + regKeyCorrect.key + "\n\n";
            webClient = new WebClient();
            
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            statusBar = txt_status;

            Logger.Trace("END");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // new Thread(LoadNews).Start();
            var state = config["Window"]["State"];var loc = config["Window"]["Location"].Split(':');var size = config["Window"]["Size"].Split(':');
            Logger.Debug("Was", config["Window"]["State"], "Location:", loc.ToJson(false), "Size:", size.ToJson(false));
            switch (state) {
                case "Maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                default:
                    Location = new System.Drawing.Point(int.Parse(loc[0]), int.Parse(loc[1]));
                    Size = new System.Drawing.Size(int.Parse(size[1]), int.Parse(size[0]));
                    break;
            }
            // new Thread(updateUsers).Start();
            // new Thread(sendHeartBeat).Start();
            // Task.Run(() => LogReader.ReadLogs());

            tabs_main.SelectedIndex = 2; // Todo: Remove
            
            // Steamworks.Core.SteamApi.Init();
            Logger.Trace("MainForm fully loaded");
        }

        public void SetupURI(string newVal, string oldVal) {
            Logger.Warn("URI Protocol not installed, installation required!", Environment.NewLine, newVal);
            var confirmResult = MessageBox.Show($"We detected that the vrchat:// protocol is not ready for use with this launcher.\n\nHowever it is required to be modified in order to have this launcher catch vrchat:// URLs\n\nKey:\n{Setup.URI.key}\n\nOld Value:\n{oldVal}\n\nNew Value:\n{newVal}\n\nPress OK to install it now!", "URI not installed!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Cancel) return;
            bool success = Setup.URI.InstallURI(newVal);
            if (!success) {
                confirmResult = MessageBox.Show("Failed to install vrchat:// protocol handler. Do you want to restart the launcher as Admin to fix this?", "Error while installing URI protocol handler", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (confirmResult) {
                    case DialogResult.Cancel:
                        Application.Exit(); break;
                    case DialogResult.Yes:
                        Utils.Utils.RestartAsAdmin(); break;
                    default:
                        break;
                }
            }
        }

        public void SetupGame()
        {
            Logger.Warn("Game not found, setup required!");
            var confirmResult = MessageBox.Show("Game was not found in the same directory as this launcher.\n\nHowever it needs to be in the same folder to work properly, please select your game to move this launcher next to it and restart.", "Game not found!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Cancel) Application.Exit();
            var gameSelector = new OpenFileDialog();
            gameSelector.Title = "Select the " + Utils.Game.gameBinary + " file";
            gameSelector.InitialDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Euro Truck Simulator 2";
            gameSelector.Filter = "ETS 2 Executable|" + Utils.Game.gameBinary + "|All Executables|*.exe";
            if (gameSelector.ShowDialog() == DialogResult.OK)
            {
                var Game = new FileInfo(gameSelector.FileName);
                var Launcher = Utils.Utils.getOwnPath();
                var newPath = new FileInfo(Path.Combine(Game.DirectoryName, Launcher.Name));
                Launcher.CopyTo(newPath.FullName);
                Utils.Utils.StartProcess(newPath, "--vrclauncher.keep", Launcher.FullName.Quote());
            }
            Utils.Utils.Exit();
        }

        private void Tabs_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabs_main.SelectedIndex)
            {
                case 2:
                    SetupInstalledMods(); break;
                default:
                    tabs_main.SelectedIndex = 2; break;
            }
        }
        #region themeing
        private static bool darkTheme = false;
        private static int activeThemeID = 0;
        private void SetUITheme(int themeID, bool darkMode)
        {
            darkTheme = darkMode;
            activeThemeID = themeID;

            if (darkMode)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                lst_mods_installed.BackColor = Color.FromArgb(255, 40, 40, 40);
                lst_mods_installed.ForeColor = Color.WhiteSmoke;
                // textBoxDirectory.BackColor = Color.FromArgb(255, 40, 40, 40);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                lst_mods_installed.BackColor = Color.White;
                lst_mods_installed.ForeColor = Color.Black;
                // textBoxDirectory.BackColor = Color.WhiteSmoke;
            }

            switch (themeID)
            {
                case 0:
                    // Blue Grey
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    // Green
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
                    break;
                case 2:
                    // Orange
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.DeepOrange500, Accent.Orange200, TextShade.WHITE);
                    break;
                case 3:
                    // Blue
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                    break;
                case 4:
                    // Red
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
                    break;
                default:
                    // Default - Blue Grey
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
            }
            // Properties.Settings.Default.DarkTheme = darkMode;
            // Properties.Settings.Default.Theme = themeID;
            // Properties.Settings.Default.Save();
            // ReRenderListView();
        }
        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Debug("called");
            if(WindowState == FormWindowState.Normal) {
                config["Window"]["Location"] = Location.X.ToString() + ":" + Location.Y.ToString();
                config["Window"]["Size"] = RestoreBounds.Size.Height.ToString() + ":" + RestoreBounds.Size.Width.ToString();
            }
            config["Window"]["State"] = WindowState.ToString();
            Config.Save(config);
        }
    }
}
