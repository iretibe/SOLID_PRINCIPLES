namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tasks = new TaskReport();
            tasks.AddEntry(new TaskEntryReport { TaskCode = "2310", TaskName = "TaskOne", SpentHours = 4 });
            tasks.AddEntry(new TaskEntryReport { TaskCode = "491D", TaskName = "TaskTwo", SpentHours = 5 });

            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });

            Console.WriteLine(tasks.ToString());
            Console.WriteLine(scheduler.ToString());

            var saver = new FileSaver();

            saver.SaveToFile(@"Reports", "TaskReport.txt", tasks);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }
    }
}