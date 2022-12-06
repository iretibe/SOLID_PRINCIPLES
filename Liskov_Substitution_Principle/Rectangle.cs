namespace Liskov_Substitution_Principle
{
    // Let's understand what is the meaning of "A derived class should correctly implement methods of a base class".
    //Consider the following Rectangle class
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
