using System;

class Program
{
    static void Main(string[] args)
    {
        List<Vector2> AllPoint = new List<Vector2>();
        while (true)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                break;
            }
            else
            {
                AllPoint.Add(new Vector2(x, y));
            }
        }
        Vector2 CheckPoint = new Vector2(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

        if (Vector2.IsPointInsidePolygon(AllPoint, CheckPoint))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }

}