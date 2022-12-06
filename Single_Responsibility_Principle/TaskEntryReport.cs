namespace Single_Responsibility_Principle
{
    //1. Start with a simple model class:
    public class TaskEntryReport
    {
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public int SpentHours { get; set; }
    }
}
