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
        private void SetupInstalledMods(bool force=false)
        {

        }

        private void List_mods_installed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_mods_reload_Click(object sender, EventArgs e)
        {
            SetupInstalledMods(true);
        }
    }
}
