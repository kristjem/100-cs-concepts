// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Variables
{
    public static void Kjor()
    {
        int age = 25;
        Console.WriteLine($"Age: {age}");
    }
}