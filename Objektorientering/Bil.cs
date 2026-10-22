public class Bil
{
    public Bil(string merke, string modell, int år, DrivlinjeType drivlinje) // Drivlinje er en type definert i denne klassen (her enum)
    {
        Merke = merke;
        Modell = modell;
        År = år;
        Drivlinje = drivlinje;
    }

    public string Merke { get; }
    public string Modell { get; }
    public int År { get; }
    // _ foran navnet indikerer at det er en privat eller intern variabel.
    public DrivlinjeType Drivlinje { get; } // Ikke vanlig med "..enum" i egenskapens navn

    public enum DrivlinjeType
    {
        Diesel,
        Bensin,
        Elektrisk,
        Hybrid
    }
}

// Elbil underklasse
public class Elbil : Bil
{
    // Konstruktør for Elbil som alltid har elektrisk drivlinje
    // this(...) kaller en annen konstruktør i samme klasse.
    // mens base(...) kaller en konstruktør i basisklassen (her Bil):
    public Elbil(string merke, string modell, int år, int batterikapasitetkWh)
        : base(merke, modell, år, DrivlinjeType.Elektrisk)
    {
        BatterikapasitetkWh = batterikapasitetkWh;
    }

    public int BatterikapasitetkWh { get; } // i kWh
}