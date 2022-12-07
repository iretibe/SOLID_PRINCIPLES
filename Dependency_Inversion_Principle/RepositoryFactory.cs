namespace Dependency_Inversion_Principle
{
    public class RepositoryFactory
    {
        public static IStudentRepository GetStudentRepository()
        {
            return new StudentRepository();
        }

        public static IStudentRepository GetTestStudentRepository()
        {
            return new TestStudentRepository();
        }
    }
}
