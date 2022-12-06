namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                FirstName = "Abdul Jalal",
                LastName = "Yessoufou"
            };

            Course _course = new OnlineCourse()
            {
                Title = "Software Engineering"
            };

            _course.Subscribe(student);
        }
    }
}