using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;

namespace MTSocket
{
    static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();
        [DllImport("kernel32", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string mode = args.Length > 0 ? args[0] : "gui";//Argüman boş ise mode gui yapılıyor.

            if (mode.ToLower() == "gui")
            {
                ModeGui();
            }
            else if (mode.ToLower() == "console")
            {
                IntPtr ptr = GetForegroundWindow();
                int u;
                GetWindowThreadProcessId(ptr, out u);
                Process process = Process.GetProcessById(u);

                if (process.ProcessName == "cmd")    //console modunda uygulama cmd ekranında mı çalıştırıldı?
                {
                    AttachConsole(process.Id);

                    ModeConsole();
                }
                else
                {
                    //Yeni console oluşturuluyor...
                    AllocConsole();

                    ModeConsole();
                }
                FreeConsole();
            }
        }

        static void ModeGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());

        }
        static void ModeConsole()
        {
            new ConsoleMode();
        }
    }
}
