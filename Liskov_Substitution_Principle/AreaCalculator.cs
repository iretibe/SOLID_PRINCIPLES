namespace Liskov_Substitution_Principle
{
    //The following calculates the area of a rectangle: 
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }
}
