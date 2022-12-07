namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Production
            Student student1 = new Student(RepositoryFactory.GetStudentRepository());

            //For Unit testing
            Student student2 = new Student(RepositoryFactory.GetTestStudentRepository());

            Console.WriteLine("Hello, World!");
        }
    }
}