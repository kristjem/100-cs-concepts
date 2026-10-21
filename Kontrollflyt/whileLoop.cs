// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Kontrollflyt;

public static class Loops
{
    public static void WhileLoop()
    {
        int count = 1;
        Console.WriteLine("While Loop (count <= 5) with count starting at 1:");
        while (count <= 5)
        {
            Console.WriteLine($"Iterasjon: {count}");
            count++;
        }
    }

    /// <summary>
    /// Do-while løkken kjører minst en gang, selv om betingelsen er usann. Den sjekker betingelsen etter at koden i løkken har kjørt.
    /// </summary>
    public static void DoWhileLoop()
    {
        int count = 7;
        Console.WriteLine("Do-While Loop (count <= 5) with count starting at 7:");
        do
        {
            Console.WriteLine($"Iterasjon: {count}");
            count++;
        } while (count <= 5);
    }
}