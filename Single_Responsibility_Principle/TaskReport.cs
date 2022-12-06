namespace Single_Responsibility_Principle
{
    //2. The next step is to create a TaskReport class which will handle all the required features for our project:
    public class TaskReport : IEntryManager<TaskEntryReport>
    {
        private readonly List<TaskEntryReport> _entries;

        public TaskReport()
        {
            _entries = new List<TaskEntryReport>();
        }

        public void AddEntry(TaskEntryReport entry) => _entries.Add(entry);
        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);
        public override string ToString() 
            => string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.TaskCode}, Name: { x.TaskName }, Hours: { x.SpentHours }"));
    }
    

    //public class TaskReport
    //{
    //    private readonly List<TaskEntryReport> _entries;

    //    public TaskReport()
    //    {
    //        _entries = new List<TaskEntryReport>();
    //    }

    //    public void AddEntry(TaskEntryReport entry) => _entries.Add(entry);
    //    public void RemoveEntryAt(int index) => _entries.RemoveAt(index);
    //    public override string ToString() 
    //        => string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.TaskCode}, Name: { x.TaskName }, Hours: { x.SpentHours }"));
    //}
}
