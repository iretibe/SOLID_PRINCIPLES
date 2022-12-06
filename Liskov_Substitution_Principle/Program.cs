namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        //Now, the following returns the wrong results: 
        //Example: LSP Violation
        //LSP says that the derived class should correctly implement the base class methods. Here, the square class is not a subtype of the rectangle class because it has equal sides.
        //So, only one property is needed instead of two properties, height, and width. It creates confusion for the users of the class and might give the wrong result. 
        static void Main(string[] args)
        {
            Rectangle sqrt1 = new Square();
            sqrt1.Height = 6;
            sqrt1.Width = 8;

            Console.WriteLine(AreaCalculator.CalculateArea(sqrt1));  //Returns 64

            Rectangle sqrt2 = new Square();
            sqrt2.Height = 8;
            sqrt2.Width = 5;

            Console.WriteLine(AreaCalculator.CalculateArea(sqrt2));  //Returns 36
        }
    }
}