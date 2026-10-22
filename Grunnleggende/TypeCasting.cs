// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class TypeCasting
{
    public static void Kjor()
    {
        // Bytte typer, enten implisitt (automatisk) eller eksplisitt (manuelt)

        // Parse: Brukes for å konvertere fra string til en annen type
        // Casting: Brukes for å konvertere mellom kompatible typer manuelt, ofte med (type) foran verdien.
        // Convert: for alt annet

        // Eksempel: String "42" til int 42
        string strTall = "42";
        int tall = int.Parse(strTall);
        Console.WriteLine($"Tall: {tall}");

        // TryParse er sikrere, fordi den ikke kaster unntak hvis konverteringen mislykkes
        string ugyldigTall = "hei";
        int resultat;
        bool suksess = int.TryParse(ugyldigTall, out resultat);
        Console.WriteLine($"Suksess: {suksess}");
        Console.WriteLine($"Resultat: {resultat}");

        // Eksempel: int 42 til string "42"
        int intTall = 42;
        string nyttTallStr = intTall.ToString();
        Console.WriteLine($"Nytt tall som string: {nyttTallStr}");

        // Convert Class: Brukes for å konvertere mellom ulike typer på en trygg måte
        string etGyldigTall = "123";
        int konvertertTall = Convert.ToInt32(etGyldigTall);
        Console.WriteLine($"Konvertert tall: {konvertertTall}");

        // Convert kan brukes til mye
        // Eksempel: string "true" til bool true
        string boolStr = "true";
        bool boolVerdi = Convert.ToBoolean(boolStr);
        Console.WriteLine($"Konvertert bool: {boolVerdi}");

        float floatTall = 3.14f;
        string floatStr = Convert.ToString(floatTall);
        Console.WriteLine($"Konvertert float til string: {floatStr}");

        // Eksempel: implisitt (automatisk) typekonvertering
        int heltall = 100;
        Console.WriteLine($"heltall: {heltall}");
        Console.WriteLine($"heltall type: {heltall.GetType()}");
        // F2-format: Formater denne numeriske verdien som tekst med nøyaktig to sifre etter desimalskilletegnet.
        // Altså er ikke F2-formatet en endring av selve verdien, men kun hvordan den vises som tekst.
        Console.WriteLine($"heltall med F2-formattering: {heltall:F2}");
        double doubleTall = heltall; // implisitt konvertering fra int til double
        Console.WriteLine($"doubleTall type: {doubleTall.GetType()}");
        Console.WriteLine($"doubleTall uten formatering: {doubleTall}");
        Console.WriteLine($"doubleTall med F2-formatering: {doubleTall:F2}");

        // Eksplisitt konvertering (casting)
        double pi = 3.14;
        Console.WriteLine($"pi type: {pi.GetType()}");
        int piInt = (int)pi; // eksplisitt konvertering fra double til int
        Console.WriteLine($"piInt: {piInt}"); // Vi har mistet .14
        Console.WriteLine($"piInt type: {piInt.GetType()}");
    }
}