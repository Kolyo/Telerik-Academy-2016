using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main()
        {
            var point = new Point3D(-7, 4, 3);
            var point2 = new Point3D(17, 6, 2.5);
            Console.WriteLine(point.ToString());
            Console.WriteLine(Point3D.O);

            Console.WriteLine(Calculate.Distance(point, point2));
        }
    }
}
