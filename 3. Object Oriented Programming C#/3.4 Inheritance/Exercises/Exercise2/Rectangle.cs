namespace Exercise2
{
    public class Rectangle : Shape
    {
        protected readonly double _width;
        protected readonly double _height;

        private const string Name = "Rectangle";

        public double Width => _width;
        public double Height => _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public virtual double GetArea()
        {
            return _width * _height;
        }

        public override string GetInfo()
        {
            return $"{Name} with width: {_width} and height: {_height}";
        }
    }
}
