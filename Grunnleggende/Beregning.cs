// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Beregning
{
    public static void Algebra()
    {
        // +
        int a = 5;
        int b = 3;
        Console.WriteLine($"For tallene a: {a} og b: {b}");

        int sum = a + b;
        Console.WriteLine($"a + b = {sum}");

        // -
        int difference = a - b;
        Console.WriteLine($"a - b (differanse/subtraksjon) = {difference}");

        // *
        int produkt = a * b;
        Console.WriteLine($"a * b (produkt/multiplikasjon) = {produkt}");

        // /
        int kvotient = a / b;
        Console.WriteLine($"a / b (kvotient/deling) = {kvotient}");

        // %
        int rest = a % b;
        Console.WriteLine($"a % b (rest/modulus) = {rest}");
    }

    public static void Deling()
    {
        Console.WriteLine("Når C# deler 5 med 2, får vi 2 fordi det er heltallsdeling");
        int resultat = 5 / 2;
        Console.WriteLine($"5 / 2 = {resultat}");
        Console.WriteLine("Hvis vi ønsker desimalresultat, kan vi bruke flyttall:");
        double desimalResultat = 5.0 / 2;
        Console.WriteLine($"5.0 / 2 = {desimalResultat}");
    }

    public static void systemMath()
    {
        Console.WriteLine("Eksempler på bruk av System.Math:");
        double tall = 4.7;
        Console.WriteLine($"Taket av {tall} = {Math.Ceiling(tall)}");
        Console.WriteLine($"Gulvet av {tall} = {Math.Floor(tall)}");
        Console.WriteLine($"Rundet av {tall} = {Math.Round(tall)}");
        Console.WriteLine($"Kvadratroten av 16 = {Math.Sqrt(16)}");
    }
}