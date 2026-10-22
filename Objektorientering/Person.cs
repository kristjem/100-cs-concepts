
public class Person
{
    // Konstruktører for Person-klassen
    // Konstruktør kjøres når et objekt av klassen opprettes med new Person(...)
    // Det er ikke nødvendigvis vanlig eller ønskelig å ha alle tre konstruktørene. Men C# tillater det
    // C# finner konstruktøren som passer til argumentene, og bruker den til å initialisere objektet.

    // Konstruktør 1: Standardkonstruktør uten parametere
    public Person() { }

    // Konstruktør 2: Tar både navn og alder som parametere
    public Person(string navn, int alder) // Konstruktør som tar navn og alder som parametere
    {
        Navn = navn;
        Alder = alder;
    }

    // Konstruktør 3: Tar kun navn som parameter, og setter alder til 0 som standard
    public Person(string navn) : this(navn, 0) { } // "Constructor chaining": Kaller den andre konstruktøren med standard alder 0 hvis kun navn er gitt

    // Egenskaper for Person-klassen
    public string Navn { get; set; } // Alle personer har et navn, og get/set gir tilgang til det
    public int Alder { get; set; } // Alle personer har en alder, og get/set gir tilgang til det
}