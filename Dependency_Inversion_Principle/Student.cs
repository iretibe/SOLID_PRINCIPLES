using System.Collections;

namespace Dependency_Inversion_Principle
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        //Tight coupling
        private IStudentRepository _studentRepository;

        public Student(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Save()
        {
            _studentRepository.AddStudent(this);
        }
    }

    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void DeleteStudent(Student student);
        void EditStudent(Student student);
        IList GetAllStudents();
    }

    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student student)
        {
            //Put code here...
        }

        public void DeleteStudent(Student student)
        {
            //Put code here...
        }

        public void EditStudent(Student student)
        {
            //Put code here...
        }

        public IList GetAllStudents()
        {
            //Put code here...
            return new List<Student>();
        }
    }
}
