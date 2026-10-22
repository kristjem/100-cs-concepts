// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Kontrollflyt;

public static class ifElse
{
    public static char lagKarakter(int poeng) // Metoden returnerer en enkel karakter, derfor char i stedet for string
    {
        if (poeng >= 90)
            return 'A';
        else if (poeng >= 80)
            return 'B';
        else if (poeng >= 70)
            return 'C';
        else if (poeng >= 60)
            return 'D';
        else
            return 'F';
    }
}