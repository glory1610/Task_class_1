using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyrobnycha_class
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            a = 1.0; b = 1.0; c = 1.0;
        }
        public Triangle(double _a, double _b, double _c)
        {
            a = _a; b = _b; c = _c;
        }
        public override string ToString()
        {
            return $"a = {a}  b = {b}  c = {c}";
        }
        public double Perimeter()
        {
            return this.a + this.b + this.c;
        }
        public double Half_Perimeter()
        {
            return this.Perimeter() / 2.0;
        }
        public double Area()
        {
            return Math.Sqrt(this.Half_Perimeter() * (this.Half_Perimeter() - this.a) * (this.Half_Perimeter() - this.b) * (this.Half_Perimeter() - this.c));
        }
        public static bool operator>(Triangle left, Triangle right)
        {
            return left.Area() > right.Area();
        }
        public static bool operator<(Triangle left, Triangle right)
        {
            return left.Area() < right.Area();
        }
        public static Triangle operator*(Triangle left, double n)
        {
            return new Triangle(left.a * n, left.b * n, left.c * n);
        }
    }
}
