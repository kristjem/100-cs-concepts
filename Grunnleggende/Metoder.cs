// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Metoder
{
    // public = metoden kan kalles fra andre klasser
    // static = metoden tilhører klassen, ikke et objekt av klassen
    // void = metoden returnerer ingenting
    public static void siHei(string navn)
    {
        Console.WriteLine($"Hei, {navn}!");
    }

    public static int leggSammen(int a, int b)
    {
        return a + b;
    }
}

public static class Scopes
{
    public static void eksempel1()
    {
        Console.WriteLine("Beste praksis er å la variabler være i det minste scope mulig");
        int x = 10;
        if (x > 5)
        {
            int y = 20;
            Console.WriteLine($"Inne i if-blokken: x = {x}, y = {y}");
        }
        // Console.WriteLine(y); // Dette vil gi en feil fordi y er utenfor scope
        Console.WriteLine($"Utenfor if-blokken: x = {x}, y er ikke tilgjengelig her");
    }

    public static void eksempel2()
    {
        if (true)
        {
            // Block scope
            int blockCount = 5;
            Console.WriteLine($"Inne i blokken: blockCount = {blockCount}");
        }
        // Console.WriteLine(blockCount); // Dette vil gi en feil fordi blockCount er utenfor scope
        Console.WriteLine($"Utenfor blokken: blockCount er ikke tilgjengelig her");
    }

}