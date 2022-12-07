using System.Collections;

namespace Dependency_Inversion_Principle
{
    internal class TestStudentRepository : IStudentRepository
    {
        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public IList GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}