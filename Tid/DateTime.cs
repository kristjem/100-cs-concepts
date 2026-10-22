// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Tid;

public static class Tidsreise
{
    public static void tidsmaskin()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"Nåværende dato og tid (UTC): {now}");
        DateTime iDag = DateTime.Today;
        Console.WriteLine($"Dagens dato: {iDag}");
        DateTime julaften = new DateTime(iDag.Year, 12, 24);
        Console.WriteLine($"Julaften: {julaften}");

        // Legge til dager
        DateTime iMorgen = iDag.AddDays(1);
        Console.WriteLine($"I morgen: {iMorgen}");

        // Legge til måneder
        DateTime nesteMaaned = iDag.AddMonths(1);
        Console.WriteLine($"Neste måned: {nesteMaaned}");

        // Legge til år
        DateTime nesteAar = iDag.AddYears(1);
        Console.WriteLine($"Neste år: {nesteAar}");

        // Legge til timer
        DateTime omEnTime = now.AddHours(1);
        Console.WriteLine($"Om en time: {omEnTime}");

        // Legge til minutter
        DateTime omFemtenMinutter = now.AddMinutes(15);
        Console.WriteLine($"Om femten minutter: {omFemtenMinutter}");

        // Legge til sekunder
        DateTime omTrettiSekunder = now.AddSeconds(30);
        Console.WriteLine($"Om tretti sekunder: {omTrettiSekunder}");

        // Forskjell mellom datoer
        TimeSpan forskjell = julaften - iDag;
        Console.WriteLine($"Dager til julaften: {forskjell.Days}");
        Console.WriteLine($"Timer til julaften: {forskjell.TotalHours}");

        // Man kan sammmenligne datoer akkurat som tall
        if (iDag < julaften)
        {
            Console.WriteLine("Dagens dato er før julaften.");
        }
        else if (iDag > julaften)
        {
            Console.WriteLine("Dagens dato er etter julaften.");
        }
        else
        {
            Console.WriteLine("Dagens dato er julaften.");
        }
    }
}