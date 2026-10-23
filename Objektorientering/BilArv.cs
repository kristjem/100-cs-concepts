// abstract betyr at klassen ikke kan instansieres direkte, kun arves fra
// altså, man kan ikke opprette new BilAbstrakt direkte

/*
Med arv beskriver vi hva noe er:
- En elbil er en bil.
- En dieselbil er en bil.
- En hybridbil er en bil.
*/
public abstract class BilAbstrakt // Bil er opptatt, derfor BilAbstrakt
{
    // protected betyr at konstruktøren kun kan kalles fra denne klassen 
    // eller fra klasser som arver fra den
    protected BilAbstrakt(
        string merke,
        string modell,
        int år
    )
    {
        if (string.IsNullOrWhiteSpace(merke))
        {
            throw new ArgumentException("Merke kan ikke være tom");
        }
        if (string.IsNullOrWhiteSpace(modell))
        {
            throw new ArgumentException("Modell kan ikke være tom");
        }
        SjekkPositivtHeltall(år, "År");
        Merke = merke;
        Modell = modell;
        År = år;
    }

    public string Merke { get; } // Kan settes første gang, men ikke endres
    public string Modell { get; } // Kan settes første gang, men ikke endres
    public int År { get; } // Kan settes første gang, men ikke endres

    // validator for å sikre positive heltall
    // Her betyr static at metoden ikke trenger en bestemt bilinstans
    protected static void SjekkPositivtHeltall(int verdi, string navn)
    {
        if (verdi <= 0)
        {
            // ArgumentOutOfRangeException er mer spesifikk enn ArgumentException og passer når et tall ligger utenfor det tillatte området.
            throw new ArgumentOutOfRangeException(navn, $"{navn} må være et positivt heltall");
        }
    }
}

// En underklasse for hver biltype (drivlinje)
public class ElbilUnderklasse : BilAbstrakt // Elbil er opptatt, derfor ElbilUnderklasse
{
    public ElbilUnderklasse(
        string merke,
        string modell,
        int år,
        int batterikapasitetkWh, // Utvidelse for Elbil, spesifikk egenskap for denne underklassen
        int rekkeviddeKm // Utvidelse for Elbil, spesifikk egenskap for denne underklassen
    ) : base(merke, modell, år) // Kaller konstruktøren til BilAbstrakt
    {
        SjekkPositivtHeltall(batterikapasitetkWh, "BatterikapasitetkWh");
        SjekkPositivtHeltall(rekkeviddeKm, "RekkeviddeKm");
        BatterikapasitetkWh = batterikapasitetkWh; // Konstruktør
        RekkeviddeKm = rekkeviddeKm; // Konstruktør
    }
    private int _batterikapasitetkWh; // Pga. scope, brukes internt i get/set for BatterikapasitetkWh
    public int BatterikapasitetkWh
    {
        get => _batterikapasitetkWh;
        set // set kalles til og med av konstruktøren ved initialisering
        {
            SjekkPositivtHeltall(value, nameof(BatterikapasitetkWh));
            _batterikapasitetkWh = value; // derfor vil tesla.BatterikapasitetkWh returnere _batterikapasitetkWh
        }
    } // Kan sette inn større batteri, derfor set
    public int RekkeviddeKm { get; set; } //


}

public class DieselbilUnderklasse : BilAbstrakt
{
    public DieselbilUnderklasse(
        string merke,
        string modell,
        int år,
        int drivstofftankLiter // Utvidelse for Dieselbil, spesifikk egenskap for denne underklassen
    ) : base(merke, modell, år)
    {
        SjekkPositivtHeltall(drivstofftankLiter, "DrivstofftankLiter");
        DrivstofftankLiter = drivstofftankLiter; // Konstruktør
    }
    public int DrivstofftankLiter { get; }
    public string Drivstofftype => "Diesel"; // Hardkodet drivstofftype for Dieselbil
}

public class HybridbilUnderklasse : BilAbstrakt
{
    public HybridbilUnderklasse(
        string merke,
        string modell,
        int år,
        int batterikapasitetkWh,
        int rekkeviddeKm,
        int drivstofftankLiter,
        string drivstofftype
    ) : base(merke, modell, år)
    {
        SjekkPositivtHeltall(batterikapasitetkWh, "BatterikapasitetkWh");
        SjekkPositivtHeltall(rekkeviddeKm, "RekkeviddeKm");
        SjekkPositivtHeltall(drivstofftankLiter, "DrivstofftankLiter");
        BatterikapasitetkWh = batterikapasitetkWh;
        RekkeviddeKm = rekkeviddeKm;
        DrivstofftankLiter = drivstofftankLiter;
        Drivstofftype = drivstofftype;
    }
    public int BatterikapasitetkWh { get; }
    public int RekkeviddeKm { get; }
    public int DrivstofftankLiter { get; }
    public string Drivstofftype { get; }
}