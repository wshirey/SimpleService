using System;
using System.ServiceProcess;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace SimpleService
{
    class Program
    {
        private const string ListeningOn = "http://localhost:8088/";

        static void Main(string[] args)
        {
            var appHost = new AppHost();

            Console.WriteLine("Running WinServiceAppHost in Console mode");
            try
            {
                appHost.Init();
                appHost.Start(ListeningOn);
                Process.Start(ListeningOn);
                Console.WriteLine("Press <CTRL>+C to stop.");
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}: {1}", ex.GetType().Name, ex.Message);
                throw;
            }
            finally
            {
                appHost.Stop();
            }

            Console.WriteLine("WinServiceAppHost has finished");

            Console.ReadLine();
        }
    }
}
