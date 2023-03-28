using System;

namespace CircleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // รับค่าพิกัดจากผู้ใช้
            Console.WriteLine("Enter the coordinates of the first point:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the third point:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            // คำนวณหาพิกัดของจุดศูนย์กลาง
            double a = x1 - x2;
            double b = y1 - y2;
            double c = x1 - x3;
            double d = y1 - y3;
            double e = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2)) / 2;
            double f = ((x1 * x1 - x3 * x3) + (y1 * y1 - y3 * y3)) / 2;
            double x = (d * e - b * f) / (a * d - b * c);
            double y = (a * f - c * e) / (a * d - b * c);

            // คำนวณหารัศมี
            double radius = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));

            // แสดงผลลัพธ์
            Console.WriteLine("The center of the circle is ({0}, {1}) and the radius is {2}", x, y, radius);
        }
    }
}