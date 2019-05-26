using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS2Launcher.Utils
{
    class Game
    {
        internal const string gameBinary = "eurotrucks2.exe";
        static Dictionary<string, FileInfo> gamePaths;
        public static Process StartGame(bool steam = false, params string[] args)
        {
            // var ownPath = Path.GetDirectoryName(Application.ExecutablePath);
            // proc.WorkingDirectory = ownPath;
            return Utils.StartProcess(getOptimalBinary(), args);
        }
        public static bool IsGameAlreadyRunning()
        {
            Process[] pname = Process.GetProcessesByName(gameBinary.Split('.')[0]);
            if (pname.Length == 0) return false;
            return true;
        }
        public static bool CheckForGame()
        {
            // Logger.Trace("Start");
            Logger.Debug("Checking if game directory exists...");
            var gamePaths = getBinaryPaths();
            Logger.Trace("gamePaths: ", gamePaths.ToJson());
            if (gamePaths.Count < 1) return false;
            return getOptimalBinary().Exists; 
        }
        public static DirectoryInfo getDirectory()
        {
            return getBinaryPaths().First().Value.Directory.Parent.Parent;
        }
        public static FileInfo getOptimalBinary() {
            OperatingSystem currentOs = Environment.OSVersion;
            var sb = new StringBuilder();
            switch (currentOs.Platform)
            {
                case PlatformID.Win32NT:
                    sb.Append("win");
                    break;
                default:
                    throw new Exception("OS not supported!");
            }
            sb.Append("_");
            if (Environment.Is64BitOperatingSystem) sb.Append("x64");
            else sb.Append("x86");
            var binPaths = getBinaryPaths();
            var str = sb.ToString();
            if (binPaths.ContainsKey(str)) throw new Exception($"Optimal game path not found\n{binPaths.ToJson()}");
            return binPaths[str];
        }
        public static Dictionary<string, FileInfo> getBinaryPaths(bool force=false)
        {
            if (gamePaths == null || force) {
                var ownPath = Utils.getOwnPath();
                gamePaths = new Dictionary<string, FileInfo>();
                var binMainDir = ownPath.Directory.Combine("bin");
                if (!binMainDir.Exists) return gamePaths;
                var binPaths = Directory.GetDirectories(binMainDir.FullName);
                foreach (var binPath in binPaths)
                {
                    var binDir = new DirectoryInfo(binPath);
                    if (!binDir.Exists) continue;
                    gamePaths[binDir.Name] = new FileInfo(Path.Combine(binDir.FullName, "eurotrucks2.exe"));
                }
            }
            return gamePaths;
        }
    }
}
