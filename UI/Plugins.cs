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
using static ETS2Launcher.Utils.Plugins;

namespace ETS2Launcher
{
    public partial class Main : MaterialForm
    {
/*        public static List<Plugin> plugins;
        private void SetupInstalledMods(bool force=false)
        {
            if (mods == null || force) {
                mods = GetMods();
                mods.OrderBy(x => x.Name);
                CheckForUpdates(mods);
            }
                
            lst_mods_installed.Clear();
            mods = mods.OrderBy(o=>o.Name).ToList();
            foreach (var mod in mods)
            {
                var item = new ListViewItem();
                item.Tag = mod;
                // ImageList imageList = new ImageList();
                // imageList.Images.Add(Properties.Resources.vrctoolspng);
                if(!mod.Enabled) item.ForeColor = Color.Gray;
                lst_mods_installed.Items.Add(item);
            }
        }

        private void List_mods_installed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
        private void Btn_plugins_reload_Click(object sender, EventArgs e)
        {

        }
    }
}
