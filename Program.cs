using System;

namespace vyrobnycha_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] triangles = new Triangle[5];
            triangles[0] = new Triangle(2.0, 3.0, 4.0);
            triangles[1] = triangles[0] * 2.0;
            triangles[2] = new Triangle();
            triangles[3] = new Triangle(1.5, 2.3, 1.2);
            triangles[4] = new Triangle(2.6, 3.3, 4.5);

            Console.WriteLine("New triangle\n");
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = double.Parse(Console.ReadLine());
            Array.Resize(ref triangles, triangles.Length + 1);
            triangles[triangles.Length - 1] = new Triangle(a, b, c);

            Console.WriteLine("All triangles:");
            Console.WriteLine("------------------------");
            foreach (var i in triangles)
            {
                Console.WriteLine(" {0}\n P = {1}\n S = {2}", i, i.Perimeter(), i.Area());
                Console.WriteLine("------------------------");
            }

            double maxElement = triangles[0].Area();
            for (int i = 1; i < triangles.Length; ++i)
            {
                if (triangles[i].Area() > maxElement)
                {
                    maxElement = triangles[i].Area();
                }
            }
            Console.WriteLine($"The largest area S = {maxElement}");
        }
    }
}
