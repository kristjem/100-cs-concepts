/*
Med komposisjon beskriver vi hva noe har:
- En bil har en drivlinje.
- En elektrisk drivlinje har et batteri.
- En forbrenningsdrivlinje har en drivstofftank.
- En hybriddrivlinje har både elektrisk motor og forbrenningsmotor.
*/

public abstract class Drivlinje
{ // Gir de forskjellige drivlinjene en felles type.
    // Alle drivlinjer MÅ kunne beskrive seg selv.
    //
    // abstract betyr at vi bare deklarerer metoden her.
    // Underklassene må selv implementere den.
    public abstract string TypeNavn { get; }
    public abstract string Beskriv();
} // Drivlinje er abstrakt og kan ikke instansieres direkte, kun arves fra

public enum Drivstofftype
{
    Bensin,
    Diesel
}

// En klasse som representerer en elektrisk drivlinje.
// Kolonet (:) betyr at klassen arver fra Drivlinje.
public class ElektriskDrivlinje : Drivlinje
{
    // KONSTRUKTØR
    // Har samme navn som klassen.
    // Kjøres automatisk når vi skriver:
    // new ElektriskDrivlinje(100)
    public ElektriskDrivlinje(int batterikapasitetkWh)
    {
        // Setter verdien til propertyen nedenfor.
        // Venstre side: propertyen BatterikapasitetkWh
        // Høyre side: parameteren batterikapasitetkWh
        BatterikapasitetkWh = batterikapasitetkWh;
    }

    // PROPERTY (EGENSKAP)
    // En offentlig egenskap som lagrer batterikapasiteten.
    public int BatterikapasitetkWh { get; }

    // get; betyr at verdien kan leses.
    // Ingen set; betyr at verdien ikke kan endres
    // etter at objektet er konstruert.

    public override string TypeNavn => "ELBIL";
    public override string Beskriv()
    {
        return $"Batteri {BatterikapasitetkWh} kWh";
    }
}

public class ForbrenningsDrivlinje : Drivlinje
{
    // KONSTRUKTØR
    public ForbrenningsDrivlinje(Drivstofftype drivstofftype, int drivstofftankLiter, int sylinderAntall, double motorvolumLiter, bool turbo)
    {
        Drivstoff = drivstofftype;
        DrivstofftankLiter = drivstofftankLiter;
        SylinderAntall = sylinderAntall;
        MotorvolumLiter = motorvolumLiter;
        Turbo = turbo;
    }

    // EGENSKAPER:
    // public – egenskapen er tilgjengelig utenfra.
    // Drivstofftype – datatypen, altså enumen du har deklarert.
    // Drivstoff – navnet på egenskapen som lagrer drivstofftypen.
    // {get} betyr at verdien kan leses utenfra, men bare initialiseres i konstruktøren.
    public Drivstofftype Drivstoff { get; }
    public int DrivstofftankLiter { get; }
    public int SylinderAntall { get; }
    public double MotorvolumLiter { get; }
    public bool Turbo { get; }

    public override string TypeNavn => (Drivstofftype.Bensin == Drivstoff ? "BENSINBIL" : "DIESELBIL");
    public override string Beskriv()
    {
        return $"{Drivstoff}, {DrivstofftankLiter}L tank, {SylinderAntall} sylindre ({MotorvolumLiter}L) {(Turbo ? "med turbo" : "uten turbo")}";
    }
}

public class HybridDrivlinje : Drivlinje
{
    // KONSTRUKTØR
    public HybridDrivlinje(
        ElektriskDrivlinje elektrisk,
        ForbrenningsDrivlinje forbrenning
    )
    {
        Elektrisk = elektrisk;
        Forbrenning = forbrenning;
    }
    // EGENSKAPER er offentlige og kan leses utenfra.
    // Typene er egendefinerte: ElektriskDrivlinje og ForbrenningsDrivlinje
    // og peker til objektene lagret i hhv. Elektrisk og Forbrenning egenskapene.
    public ElektriskDrivlinje Elektrisk { get; }
    public ForbrenningsDrivlinje Forbrenning { get; }

    public override string TypeNavn => "HYBRIDBIL";
    public override string Beskriv()
    {
        return $"{Elektrisk.Beskriv()}, {Forbrenning.Beskriv()}";
    }
}

public class BilKomposisjon
{
    public BilKomposisjon(
        string merke,
        string modell,
        int år,
        Drivlinje drivlinje
    )
    {
        Merke = merke;
        Modell = modell;
        År = år;
        // Her lagrer vi en REFERANSE til drivlinjeobjektet.
        // Vi oppretter ikke en ny drivlinje her.
        // Vi bruker objektet som ble sendt inn.
        Drivlinje = drivlinje;
    }
    // EGENSKAPER (PROPERTIES)
    // Disse beskriver selve bilen.
    public string Merke { get; }
    public string Modell { get; }
    public int År { get; }

    // KOMPOSISJON
    // Bilen HAR en drivlinje.
    //
    // Datatypen er Drivlinje (abstrakt basisklasse).
    // Den faktiske instansen kan for eksempel være
    // ElektriskDrivlinje eller ForbrenningsDrivlinje.
    public Drivlinje Drivlinje { get; }
}

/* Kjør Program.cs "dotnet run" med:
using Objektorientering;

BilKomposisjon naboensBil = new BilKomposisjon("Tesla", "Model X", 2016, new ElektriskDrivlinje(75));
BilKomposisjon bilenMin = new BilKomposisjon("Tesla", "Model X", 2018, new ElektriskDrivlinje(100));
BilKomposisjon konebilenMin = new BilKomposisjon("Skoda", "Fabia", 2009, new ForbrenningsDrivlinje(Drivstofftype.Bensin, 45, 4, 1.6, false));
BilKomposisjon gamlebilenMin = new BilKomposisjon("Ford", "Mondeo", 2014, new ForbrenningsDrivlinje(Drivstofftype.Diesel, 60, 4, 1.6, true));
BilKomposisjon bestefarsBil = new BilKomposisjon(
    "Honda", "Jazz", 2011,
    new HybridDrivlinje(
        new ElektriskDrivlinje(1), // egentlig 0,6 kWh
        new ForbrenningsDrivlinje(Drivstofftype.Bensin, 40, 4, 1.3, false)
    )
);

List<BilKomposisjon> biler = new List<BilKomposisjon>();
biler.Add(naboensBil);
biler.Add(bilenMin);
biler.Add(konebilenMin);
biler.Add(bestefarsBil);
biler.Add(gamlebilenMin);

foreach (BilKomposisjon bil in biler)
{
    // Henter typen fra drivlinjens egen implementasjon.
    string biltype = bil.Drivlinje.TypeNavn;

    // Henter beskrivelsen fra drivlinjens egen implementasjon.
    string beskrivelse = bil.Drivlinje.Beskriv();

    // Setter sammen informasjonen om bilen.
    Console.WriteLine(
        $"{biltype}: {bil.Merke}, {bil.Modell}, {bil.År}, {beskrivelse}"
    );
}

*/