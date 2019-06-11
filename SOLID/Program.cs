using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.SingleResponsibility;
using SOLID.SingleResponsibility.Common;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void RunSingleResponsibilitySample(bool runScheduler = false)
        {
            //FileSaver saver = new FileSaver();
            //FileSaverBetter betterSaver = new FileSaverBetter();
            //WorkReportDo report = new WorkReportDo();
            //Scheduler scheduler = null;

            //report.AddEntry(new WorkReportEntry
            //{
            //    ProjectCode = "123Ds",
            //    ProjectName = "SingleResponsibilityDo",
            //    SpentHours = 3
            //});

            //report.AddEntry(new WorkReportEntry
            //{
            //    ProjectCode = "987Fc",
            //    ProjectName = "SingleResponsibilityDont",
            //    SpentHours = 5
            //});

            //Console.WriteLine(report.ToString());

            //if (runScheduler == true)
            //{
            //    scheduler = new Scheduler();

            //    scheduler.AddEntry(new ScheduledTask
            //    {
            //        TaskId = 1,
            //        Content = "Do task 1 stuff...",
            //        ExecuteOn = DateTime.Now.AddDays(5)
            //    });

            //    scheduler.AddEntry(new ScheduledTask
            //    {
            //        TaskId = 2,
            //        Content = "Do task 2 stuff...",
            //        ExecuteOn = DateTime.Now.AddDays(2)
            //    });

            //    Console.WriteLine(scheduler.ToString());

            //    betterSaver.SaveToFile(@"Reports", "WorkReport.txt", report);
            //    betterSaver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
            //}
            //else
            //{
            //    saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            //}
        }
    }
}
