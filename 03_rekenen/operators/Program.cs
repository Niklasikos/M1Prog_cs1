namespace operators;

class Program
{
    static void Main(string[] args)
    {
        int plus = 9;
        Console.WriteLine($"plus start op {plus}");
        plus++;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine($"voorbeeld1 is nu 30, zie: {voorbeeld1}");

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine($"voorbeeld2 is nu 20, zie: {voorbeeld2}, wie is wel 30?");

        int voorbeeld3 = 20;
        int result2 = voorbeeld3 += 10;
        Console.WriteLine($"voorbeeld3 is nu 30, zie: {voorbeeld3}, result2 ook: {result2}");

        int zelfopdracht = 5;
        zelfopdracht -= 2;
        Console.WriteLine($"{zelfopdracht}");

        double zelfopdracht1 = 10;
        zelfopdracht1 *= 3;
        Console.WriteLine($"{zelfopdracht1}");

        float zelfopdracht2 = 15;
        zelfopdracht2 /= 3;
        Console.WriteLine($"{zelfopdracht2}");
    }
}
