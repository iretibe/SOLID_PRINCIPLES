namespace Liskov_Substitution_Principle
{
    /*
    Mathematically, a square is the same as a rectangle that has four equal sides. We can use inheritance "is-a" relationship here. 
    A square is a rectangle. The Square class can inherit the Rectangle class with equal height and width, as shown below. 
    */
    internal class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Height 
        {
            get 
            {
                return _height;
            }

            set 
            {
                _height = value;
                _width = value;
            }
        }

        public override int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
