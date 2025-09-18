namespace variableopdracht2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //fiets:
        Console.WriteLine("fiets:");
        string fietsMerk = "Stevens";
        int fietsVersnellingen = 7;
        double framemaat = 54.5;
        bool heeftbel = true;

        Console.WriteLine("Fiets Merk: " + fietsMerk);
        Console.WriteLine("Fiets Versnellingen: " + fietsVersnellingen);
        Console.WriteLine("Framemaat: " + framemaat);
        Console.WriteLine("Heeft Bel: " + heeftbel);

        //Video Game Character:
        Console.WriteLine("Video Game Character:");
        int level = 5;
        string characterNaam = "Master Chief";
        bool iskillable = false;
        float healthPoints = 99.5f;

        Console.WriteLine("Level: " + level);
        Console.WriteLine("Character Naam: " + characterNaam);
        Console.WriteLine("Is Killable: " + iskillable);
        Console.WriteLine("Health Points: " + healthPoints);
    }
}
