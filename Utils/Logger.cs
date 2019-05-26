using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ETS2Launcher.Utils
{
    class Logger
    {
        enum LogLevel {
            Trace, Debug, Info, Warn, Error, Fatal
        }
        private static FileInfo getLogFile(string fileName = "Launcher.log") {
            return new FileInfo(Path.Combine(Utils.getOwnPath().DirectoryName, fileName));
        }
        public static void Init() {
            try { Console.Title = "ETS2 Launcher Log"; } catch { }
            var args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            args = args.Select(s => s.ToLowerInvariant()).ToArray();
            if (args.Contains("--launcher.console")) { ExternalConsole.InitConsole(); }
        }
        public static void ClearLog() {
            var log = getLogFile();
            if (log.Exists && log.Length > 0) try { File.WriteAllText(log.FullName, string.Empty); } catch { }
            }
        private static Tuple<Color, ConsoleColor> ColorFromLogLevel(LogLevel logLevel) {
            switch (logLevel) {
                case LogLevel.Trace:
                    return new Tuple<Color, ConsoleColor>(Color.Gray, ConsoleColor.Gray);
                case LogLevel.Debug:
                    return new Tuple<Color, ConsoleColor>(Color.Cyan, ConsoleColor.Cyan);
                case LogLevel.Warn:
                    return new Tuple<Color, ConsoleColor>(Color.Orange, ConsoleColor.DarkYellow);
                case LogLevel.Error:
                    return new Tuple<Color, ConsoleColor>(Color.Red, ConsoleColor.Red);
                case LogLevel.Fatal:
                    return new Tuple<Color, ConsoleColor>(Color.DarkRed, ConsoleColor.DarkRed);
                default:
                    return new Tuple<Color, ConsoleColor>(Color.White, ConsoleColor.White);
            }
        }
        public static void Trace(params object[] msg) => log(LogLevel.Trace, msgs: msg);
        public static void Debug(params object[] msg) => log(LogLevel.Debug, msgs: msg);
        public static void Log(params object[] msg) => log(LogLevel.Info, msgs: msg);
        public static void LogLines(params object[] msg) => log(LogLevel.Info, lines: true, msgs: msg);
        public static void Warn(params object[] msg) => log(LogLevel.Warn, msgs: msg);
        public static void Error(params object[] msg) => log(LogLevel.Error, msgs: msg);
        public static void Fatal(params object[] msg) => log(LogLevel.Fatal, msgs: msg);
        private static void log(LogLevel logLevel, bool lines = false, params object[] msgs) // [CallerMemberName] string cName = "Unknown.Unknown", 
        {
            string timestamp = DateTime.UtcNow.ToString("HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            StackFrame frame = new StackFrame(1); var method = frame.GetMethod(); var cName = method.DeclaringType.Name; var mName = method.Name;
            var oldColor = Console.ForegroundColor;
            var newColor = ColorFromLogLevel(logLevel);
            var item = new System.Windows.Forms.ListViewItem();
            item.ForeColor = newColor.Item1;
            var str = "";
            var seperator = lines ? Environment.NewLine : " ";
            foreach(var msg in msgs) {
                try { str += seperator + (string)msg;
                } catch (Exception ex) {
                    // Console.WriteLine($"Error {ex.ToString()}");
                    str += seperator + msg.ToString();
                }
            }
            var line = $"[{timestamp}] {logLevel} - {cName}.{mName}: {str}";
            /*if (Main.selflog != null) {
                item.Text = line;
                Main.selflog.Items.Add(item);
            }*/
            if (Program.mainWindow.txt_status != null && logLevel > LogLevel.Debug) {
                Program.mainWindow.txt_status.Text = line;
                Program.mainWindow.txt_status.ForeColor = newColor.Item1;
            }
            getLogFile().AppendLine(line);
            if (logLevel > LogLevel.Trace /* || Main.args.Contains("--vrclauncher.verbose") */ ) {
                try {
                    Console.ForegroundColor = newColor.Item2;
                    Console.WriteLine(line);
                    Console.ForegroundColor = oldColor;
                } catch { }
            }
        }
    }
}
