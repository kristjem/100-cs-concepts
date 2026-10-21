// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Kontrollflyt;

public static class ForLoop
{
    public static void Kjor()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iterasjon: {i}");
        }
    }
}