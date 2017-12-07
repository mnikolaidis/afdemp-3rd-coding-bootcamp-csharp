using System.Globalization;

namespace Exercise2
{
    public sealed class Square : Rectangle
    {
        private const string Name = "Square";

        public Square(double a) : base(a, a)
        {

        }

        public override string GetInfo()
        {
            return $"{Name} with size: {_width}";
        }
    }
}
