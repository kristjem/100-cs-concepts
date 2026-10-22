// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Kontrollflyt;

// array of fruits


public static class ForLoop
{
    /// <summary>
    /// Looper gjennom et array av frukter og skriver ut hver frukt med iterasjonsnummer.
    /// new string[] betyr at vi oppretter et nytt array av strenger.
    /// { "Eple", "Banan", "Kirsebær", "Appelsin" } har {} fordi vi spesifiserer elementene i arrayet.
    /// i motsetning til JavaScript hvor man kan bruke [] direkte for å lage et array av strenger.
    /// </summary>
    private static string[] fruktArray = new string[] { "Eple", "Banan", "Kirsebær", "Appelsin" };
    public static void loopStringArray(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        // Må bruke < og ikke <= fordi array-indekser starter på 0 og går til Length - 1.
        {
            Console.WriteLine($"Iterasjon: {i}, Frukt: {stringArray[i]}");
        }
    }
    public static string[] GetFruktArray()
    {
        return fruktArray;
    }
}
