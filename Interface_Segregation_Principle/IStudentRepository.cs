namespace Interface_Segregation_Principle
{
    //Let's use the following interface to learn ISP in detail: 
    //Example: Fat Interface
    //Before ISP Implementation
    //public interface IStudentRepository
    //{
    //    void AddStudent(Student student);
    //    void EditStudent(Student student);
    //    void DeleteStudent(Student student);

    //    void AddCourse(Course course);
    //    void EditCourse(Course course);
    //    void DeleteCourset(Course course);

    //    bool SubscribeCourse(Course course);
    //    bool UnsubscribeCourse(Course course);
    //    IList<Student> GetAllStudents();
    //    IList<Student> GetAllStudents(Course course);

    //    IList<Course> GetAllCourse();
    //    IList<Course> GetAllCourses(Student student);
    //}

    //After ISP Implementation
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void EditStudent(Student student);
        void DeleteStudent(Student student);

        bool SubscribeCourse(Course course);
        bool UnsubscribeCourse(Course course);
        IList<Student> GetAllStudents();
        IList<Student> GetAllStudents(Course course);
    }

    public interface ICourseRepository
    {
        void AddCourse(Course course);
        void EditCourse(Course course);
        void DeleteCourset(Course course);

        IList<Course> GetAllCourse();
        IList<Course> GetAllCourses(Student student);
    }

    public class StudentRepository : IStudentRepository
    {
        public StudentRepository()
        {

        }

        public void AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourset(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void EditCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAllCourse()
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAllCourses(Student student)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAllStudents(Course course)
        {
            throw new NotImplementedException();
        }

        public bool SubscribeCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public bool UnsubscribeCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
