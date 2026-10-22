// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Null
{
    public static void Nullable()
    {
        // String (objekt) kan være null
        string brukernavn = null; // output vil være null
        Console.WriteLine($"brukernavn: {brukernavn}");

        // Int er ikke nullable som standard
        int alder = 0; // output vil være 0
        Console.WriteLine($"Alder: {alder}");

        // Int kan gjøres nullable ved å bruke ?
        int? nullableAlder = null; // output vil være null
        Console.WriteLine($"Nullable alder: {nullableAlder}");
        nullableAlder = 25; // output vil være 25
        Console.WriteLine($"Nullable alder: {nullableAlder}");

        // ALLTID SJEKK FØR DU BRUKER NULLABLE-VERDIER
        // Trygg navigering
        int? length = brukernavn?.Length; // output vil være null hvis brukernavn er null
        Console.WriteLine($"brukernavn.Length: {length}");

        int? nullableAlderLength = nullableAlder?.ToString().Length; // output vil være null hvis nullableAlder er null
        Console.WriteLine($"nullableAlder.Length: {nullableAlderLength}");

        if (brukernavn != null)
        {
            Console.WriteLine($"Brukernavn er ikke null: {brukernavn}");
        }
        if (nullableAlder.HasValue)
        {
            Console.WriteLine($"Nullable alder har verdi: {nullableAlder.Value}");
        }
    }
}