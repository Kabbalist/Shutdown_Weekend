using System;
using System.Diagnostics;
using System.Timers;

namespace Shutdown_Weekend
{
    class Program
    {
        static void Shutdown(object source, ElapsedEventArgs e)
        {
            Process shutdown = new Process();
            shutdown.StartInfo.FileName = "cmd.exe";
            shutdown.StartInfo.Arguments = "/c shutdown -s -t 5";
            shutdown.Start();
        }
        static void Main()
        {
            DateTime dayOfWeek = DateTime.Now;
            int p = Convert.ToInt32(dayOfWeek.DayOfWeek);
            if (p == 6 || p == 0)
            {
                const int interval = 300000;
                Timer tmr = new Timer();
                tmr.Elapsed += new ElapsedEventHandler(Shutdown);
                tmr.Interval = interval;
                tmr.Enabled = true;
                Console.WriteLine("Нажмите Enter для выхода");
                Console.ReadKey();
            }
        }
    }
}
