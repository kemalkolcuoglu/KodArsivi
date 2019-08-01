using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugConsole
{
    public class Debugger
    {
        private static bool GUIMode = false;

        public static bool isGUIMode { get { return GUIMode; } set { GUIMode = value; } }

        private static Forms.DebugConsole db = new Forms.DebugConsole();
        public static void WriteConsole(string Data, string Type, string Direction)
        {
            if (GUIMode)
            {
                db.WriteConsole(Data, Type, Direction);
            }
            else
            {
                Console.WriteLine("Type :{0}\tDirection :{1}\r\n{2}", Type, Direction, Data);
            }
        }
        public static void ShowConsole()
        {
            if (GUIMode)
                db.Show();
        }
    }
}
