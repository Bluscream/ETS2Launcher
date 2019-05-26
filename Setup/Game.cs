using System.IO;
using System.Windows.Forms;
using ETS2Launcher.Utils;

namespace VRChatLauncher.Setup
{
    class Game
    {
        public static bool CheckForGame()
        {
            // Logger.Trace("Start");
            var gamePath = Utils.Utils.getGamePath();
            Logger.Debug("Checking if", gamePath.FullName, "exists...");
            return gamePath.Exists;
        }
    }
}
