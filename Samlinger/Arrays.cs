// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Samlinger;

public static class Arrays
{
    public static void Kjor()
    {
        Console.WriteLine("Demonstrasjon av arrays i C#");
        Console.WriteLine("Når en Array er opprettet, har den en fast størrelse.");
        Console.WriteLine("Array er best for ytelse, dersom størrelsen på samlingen er kjent på forhånd.");
        Console.WriteLine("F.eks. finnes ikke .pop og .push som i JavaScript.");
        Console.WriteLine("For dynamisk størrelse kan man bruke List i stedet.");
        // Tom array av heltall med fast størrelse på 5
        int[] tomHeltallArray = new int[5];

        // Array med forhåndsdefinerte heltall
        int[] heltallArray = { 1, 2, 3, 4, 5 };

        // Array med forhåndsdefinerte strenger
        string[] strengArray = { "Hei", "Verden", "C#" };

        string andreVerdi = strengArray[1];
        Console.WriteLine($"Indeks 1 i strengArray: {andreVerdi}");
        Console.WriteLine($"C# har ikke -1 som indeks for siste element");
        Console.WriteLine($"Men indeks ^1 i strengArray blir siste element: {strengArray[^1]}");
        Console.WriteLine($"Men indeks ^2 i strengArray blir nest siste element: {strengArray[^2]}");
        Console.WriteLine($"Lengden på strengArray er {strengArray.Length}");

    }
}