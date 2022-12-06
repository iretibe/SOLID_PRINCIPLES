namespace Single_Responsibility_Principle
{
    public class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
        
        //public void SaveToFile(string directoryPath, string fileName, TaskReport report)
        //{
        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }

        //    File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        //}
    }
}
