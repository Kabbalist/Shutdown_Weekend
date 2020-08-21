using System;
using System.Diagnostics;

namespace Shutdown_Weekend
{
    class Program
    {
        static void Main()
        {
            DateTime dayOfWeek = DateTime.Now;
            int p = Convert.ToInt32(dayOfWeek.DayOfWeek);
            if (p == 6 || p == 0)
            {
                Process shutdown = new Process();
                shutdown.StartInfo.FileName = "cmd.exe";
                shutdown.StartInfo.Arguments = "/c shutdown -s -t 60";
                shutdown.Start();
            }
        }
    }
}
