namespace Open_Closed_Principle
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public void Save()
        {
            Console.WriteLine("Starting Save()..");

            //Use EF to save to database

            Console.WriteLine("End Save()...");
        }

        public void Delete()
        {
            Console.WriteLine("Starting Delete()..");

            //Check if already subscribed courses then don't delete

            Console.WriteLine("End Delete()...");
        }
    }
}
