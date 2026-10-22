// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

// Instanser av en klasse har camelCase, f.eks. Elbil tesla = new Elbil(...)

public static class Navnekonvensjon
{
    public static void Kjor()
    {
        // PascalCase brukes for klassenavn og metodenavn
        int GetStudentCount()
        {
            //camelCase for variabler
            int studentCount = 0;

            // UPPER_CASE for konstanter
            const int MAX_COUNT = 500;
            Console.WriteLine($"Max count: {MAX_COUNT}");

            // Tydelige variabelnavn, f.eks. ikke bare "sc" men "studentCount"
            return studentCount;
        }
        int count = GetStudentCount();
        Console.WriteLine($"Student count: {count}");

        // Koden skal kunne leses som setninger, der det er mulig
    }

    // Interface starter med stor I, f.eks. ITegnbar
    interface ITegnbar
    {
        void Tegn();
    }

    class Sirkel : ITegnbar
    {
        public void Tegn()
        {
            Console.WriteLine("Tegner en sirkel");
        }
    }

    class Firkant : ITegnbar
    {
        // Privat variabel starter med underscore og liten bokstav
        private string _enPrivatVariabel;
        // Offentlig egenskap starter med stor bokstav
        public string EnOffentligEgenskap { get; set; }

        public void Tegn()
        {
            Console.WriteLine("Tegner en firkant");
        }
    }
}