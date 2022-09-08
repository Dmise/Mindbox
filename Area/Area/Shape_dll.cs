namespace ShapeDll
{
    public interface Shape // реализуя интерфес, пользователь может добавялть новые фигуры.
    {
        public double Area
        {
            get;
        }
    }
    public class Triangle : Shape
    {
        private double A;
        private double B;
        private double C;

        public bool IsRightTriangle
        {
            get
            {
                if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
                    return true;
                else if (Math.Pow(C, 2) + Math.Pow(A, 2) == Math.Pow(B, 2))
                    return true;
                else if (Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2))
                    return true;
                return false;
                
            }
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Area
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }

    public class Circle : Shape
    {
        private double R;
        public Circle(double r)
        {
            R = r;
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }
    }

}