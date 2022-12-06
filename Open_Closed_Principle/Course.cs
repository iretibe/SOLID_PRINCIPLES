namespace Open_Closed_Principle
{
    //Thus, OCP using inheritance makes it "Open for extension and closed for modification".
    //To apply OCP to our Course class, abstract class-based inheritance is more suitable.We can create an abstract class
    //as a base class and then create a new class for each type of course and implement the Subscribe() method in each class which will do all the necessary subscription steps, as shown below
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student student);
    }
}
