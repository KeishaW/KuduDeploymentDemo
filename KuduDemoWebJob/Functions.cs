using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace KuduDemoWebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([TimerTrigger("00:00:10", RunOnStartup = true)] TimerInfo timerInfo)
        {
            Console.WriteLine("Just doing my job!");
        }
    }
}
