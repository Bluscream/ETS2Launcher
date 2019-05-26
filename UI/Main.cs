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

namespace ETS2Launcher
{
    public partial class Main : MaterialForm
    {
        private static MaterialSkinManager materialSkinManager;
        public TextBox statusBar;
        public Main(string[] args)
        {
            InitializeComponent();
            statusBar = txt_status;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            tabs_main.SelectedIndex = 2; // Todo: Remove
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
                list_mods_installed.BackColor = Color.FromArgb(255, 40, 40, 40);
                list_mods_installed.ForeColor = Color.WhiteSmoke;
                // textBoxDirectory.BackColor = Color.FromArgb(255, 40, 40, 40);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                list_mods_installed.BackColor = Color.White;
                list_mods_installed.ForeColor = Color.Black;
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
    }
}
