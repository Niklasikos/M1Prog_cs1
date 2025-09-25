namespace CalcExtra;

class Program
{
    static void Main(string[] args)
    {
        float x1 = 50;
        float y1 = 50;
        float x2 = 60;
        float y2 = 50;

        float rad1 = 5;
        float rad2 = 5;

        float dx = x2 - x1;
        float dy = y2 - y1;

        float testLengh = 5;

        double length = Math.Sqrt((dx * dx) + (dy * dy));

        bool collide = length <= testLengh;

        Console.WriteLine(collide);
    }
}
