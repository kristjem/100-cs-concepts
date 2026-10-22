// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Samlinger;

public static class Lists
{
    public static void Kjor()
    {
        Console.WriteLine("Demonstrasjon av lister i C#");
        Console.WriteLine("Lister har dynamisk størrelse.");
        Console.WriteLine("Lister er mer fleksible, men kan ha litt lavere ytelse enn arrays.");
        Console.WriteLine("LISTER BØR BRUKES SOM STANDARD, MED MINDRE DU HAR HELT SPESIELLE GRUNNER TIL Å BRUKE ARRAY.");
        Console.WriteLine("Du kan bruke .Add og .Remove som i JavaScript.");
        Console.WriteLine("For fast størrelse kan man bruke Array i stedet.");

        Console.WriteLine("Lister defineres med List<type> variabelNavn = new List<type>();");

        List<int> numbersList = new List<int>();
        numbersList.Add(10);
        numbersList.Add(20);
        numbersList.Add(30);

        Console.WriteLine("Innholdet i numbersList:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }

        // Fjerne et element fra listen
        numbersList.Remove(20);
        Console.WriteLine("Innholdet i numbersList etter fjerning av 20:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }

        // Sett inn element på en bestemt posisjon
        numbersList.Insert(1, 25);
        Console.WriteLine("Innholdet i numbersList etter innsetting av 25 på indeks 1:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }

        // Få element på en bestemt posisjon
        int elementPåIndeks1 = numbersList[1];
        Console.WriteLine($"Bare elementet på indeks 1 i numbersList: {elementPåIndeks1}");

        // Sjekke om listen inneholder et bestemt element
        bool inneholder10 = numbersList.Contains(10);
        Console.WriteLine($"Inneholder numbersList tallet 10? {inneholder10}");

        // Få antall elementer i listen
        int antallElementer = numbersList.Count;
        Console.WriteLine($"Antall elementer i numbersList: {antallElementer}");

        // Fjerne alle elementer fra listen
        numbersList.Clear();
        Console.WriteLine("Innholdet i numbersList etter å ha fjernet alle elementer:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }
    }
}