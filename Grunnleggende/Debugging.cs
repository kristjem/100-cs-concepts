// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Debugging
{
    public static void Kjor()
    {
        Console.WriteLine("Grunnleggende debugging med breakpoints");
        Console.WriteLine($"Sett en breakpoint på randomTall for å inspisere variabelen");
        int randomTall = new Random().Next(1, 101); // Genererer et tilfeldig tall mellom 1 og 100
        Console.WriteLine($"Tilfeldig tall generert: {randomTall}");
    }
}