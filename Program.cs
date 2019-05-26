using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS2Launcher.Utils;

namespace ETS2Launcher
{
    static class Program
    {
        public static Main mainWindow;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Logger.Init();
            Logger.Trace("START");
            Logger.ClearLog();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            if (args.Length > 0) Logger.Warn("Catched command line arguments:");
            for (int i = 0; i < args.Length; i++)
            {
                Logger.Warn($"[{i}]", args[i]);
            }
            var keep_open = args.Contains("--launcher.keep");
            if (keep_open) {
                var firstAfter = args.SkipWhile(p => p != "--launcher.keep").ElementAt(1);
                Logger.Warn("firstAfter", firstAfter);
            }
            var launcher_running = Utils.Utils.IsLauncherAlreadyRunning();
            Logger.Log("Launcher already running:", launcher_running.ToString());
            var game_running = Game.IsGameAlreadyRunning();
            Logger.Log("Game already running:", game_running.ToString());
            mainWindow = new Main(args);
            Application.Run(mainWindow);
            Logger.Trace("END");
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Logger.Log("Exiting...");
            // LogReader.Dispose();
            // IPC.Launcher.Dispose();
        }
    }
}
