// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Kontrollflyt;

public static class switchCase
{
    public static string dagNavn(int dagNummer)
    {
        switch (dagNummer)
        {
            case 1:
                return "Mandag";
            case 2:
                return "Tirsdag";
            case 3:
                return "Onsdag";
            case 4:
                return "Torsdag";
            case 5:
                return "Fredag";
            case 6:
                return "Lørdag";
            case 7:
                return "Søndag";
            default:
                return "Ugyldig dag";
        }
    }

    /// <summary>
    /// "switch expression" introdusert i C# 8.0
    /// </summary>
    /// <param name="månedNummer"></param>
    /// <returns></returns>
    public static string månedNavn(int månedNummer)
    {
        return månedNummer switch
        {
            1 => "Januar",
            2 => "Februar",
            3 => "Mars",
            4 => "April",
            5 => "Mai",
            6 => "Juni",
            7 => "Juli",
            8 => "August",
            9 => "September",
            10 => "Oktober",
            11 => "November",
            12 => "Desember",
            _ => "Ugyldig måned"
        };
    }

}