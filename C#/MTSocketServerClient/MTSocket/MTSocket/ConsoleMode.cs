using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSocket
{
    public class ConsoleMode
    {
        public ConsoleMode()
        {
            DebugConsole.Debugger.WriteConsole("1", "2", "3");
            DebugConsole.Debugger.ShowConsole();
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
