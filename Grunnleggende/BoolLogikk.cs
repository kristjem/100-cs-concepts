// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class BoolLogikk
{
    public static void Sammenlign(int a, int b)
    {
        int tallA = a;
        int tallB = b;
        Console.WriteLine($"Er {tallA} lik {tallB}? {tallA == tallB}");
        Console.WriteLine($"Er {tallA} større enn {tallB}? {tallA > tallB}");
        Console.WriteLine($"Er {tallA} mindre enn {tallB}? {tallA < tallB}");
        Console.WriteLine($"Er {tallA} ulik {tallB}? {tallA != tallB}");
        Console.WriteLine($"Er {tallA} større eller lik {tallB}? {tallA >= tallB}");
        Console.WriteLine($"Er {tallA} mindre eller lik {tallB}? {tallA <= tallB}");
    }

    public static void LogiskOg(int a, int b)
    {
        int tallA = a;
        int tallB = b;
        Console.WriteLine($"Er {tallA} større enn 0 OG {tallB} større enn 0? {tallA > 0 && tallB > 0}");
    }

    public static void LogiskEller(int a, int b)
    {
        int tallA = a;
        int tallB = b;
        Console.WriteLine($"Er {tallA} større enn 0 ELLER {tallB} større enn 0? {tallA > 0 || tallB > 0}");
    }
}