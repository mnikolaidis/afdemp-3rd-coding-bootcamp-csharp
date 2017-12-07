namespace Exercise2
{
    public abstract class Shape
    {
        protected ShapeColor _color;

        public ShapeColor Color
        {
            get { return _color; }
        }

        public void SetColor(ShapeColor color)
        {
            _color = color;
        }

        public abstract string GetInfo();
    }
}
