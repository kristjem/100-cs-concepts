// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Grunnleggende;

public static class Variabler
{
    public static void Typer()
    {
        int age = 25;
        Console.WriteLine($"Age: {age}");
        age = 30;
        Console.WriteLine($"Updated Age: {age}");

        // DOUBLE: 64-bit binært flyttall
        double pi = 3.14;

        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"DOUBLE: 0.1 + 0.2 == 0.3: {0.1 + 0.2 == 0.3}");
        // False


        // DECIMAL: 128-bit desimalrepresentasjon
        // DECIMAL brukes ofte for økonomiske beregninger på grunn av høy presisjon
        decimal pris = 29.90m;

        Console.WriteLine($"Pris: {pris}");
        Console.WriteLine($"DECIMAL: 0.1m + 0.2m == 0.3m: {0.1m + 0.2m == 0.3m}");
        // True

        decimal veldigPresis = 0.000000000123456789m;
        Console.WriteLine($"Presis decimal: {veldigPresis}");


        // FLOAT: 32-bit binært flyttall
        float temperatur = 23.5f;

        Console.WriteLine($"Temperatur: {temperatur}");
        Console.WriteLine($"FLOAT: 0.1f + 0.2f == 0.3f: {0.1f + 0.2f == 0.3f}");
        // True!

        string name = "Alice";
        Console.WriteLine($"Name: {name}");

        bool isStudent = true;
        Console.WriteLine($"Is Student: {isStudent}");

        char grade = 'A'; // char er en enkelt tegnvariabel
        Console.WriteLine($"Grade: {grade}");


        string funfact = "decimal må ha 'm' bak tallet og float må ha 'f' bak tallet, fordi C# ellers antar at det er en double";
        Console.WriteLine($"Funfact: {funfact}");

        DateTime today = DateTime.Now;
        Console.WriteLine($"Today: {today}");

        DateTime yesterday = today.AddDays(-1);
        Console.WriteLine($"Yesterday: {yesterday}");

        DateTime lastDayOfCurrentMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
        Console.WriteLine($"Last Day of Current Month: {lastDayOfCurrentMonth}");

        var message = "C# knows this is a string type";
        Console.WriteLine($"Message: {message}");
    }

    /// <summary>
    /// Her kan jeg skrive informasjon som jeg ser når jeg bruker metoden BrukerInput.
    ///  Markdown støttes ikke, kun xml.
    /// </summary>
    /// <returns>Her kunne jeg skrevet hva som ble returnert</returns>
    public static void BrukerInput()
    {
        Console.WriteLine("Name? ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out _)) // _ betyr at vi ignorerer verdien som returneres av TryParse
        {
            Console.WriteLine("Invalid name input.");
            return;
        }

        Console.WriteLine("Age? ");
        string ageInput = Console.ReadLine();
        if (int.TryParse(ageInput, out int age))
            Console.WriteLine($"{name} is {age} years old.");
        else
            Console.WriteLine("Invalid age input.");
    }

    public static void Strings()
    {
        Console.WriteLine("String manipulation examples:");
        string nameNotNormalized = "      Edward  ";
        Console.WriteLine($"Original name: {nameNotNormalized}");
        string name = nameNotNormalized.Trim();
        Console.WriteLine($"Trimmed name: {name}");
        Console.WriteLine($"Lowercase name: {name.ToLower()}");
        Console.WriteLine($"Uppercase name: {name.ToUpper()}");
        Console.WriteLine($"Length of name: {name.Length}");
        Console.WriteLine($"Contains 'Edward': {name.Contains("Edward")}");
        Console.WriteLine($"Starts with 'Ed': {name.StartsWith("Ed")}");
        Console.WriteLine($"Ends with 'ward': {name.EndsWith("ward")}");
        Console.WriteLine($"Index of 'Edward': {name.IndexOf("Edward")}");
        Console.WriteLine($"Substring (0, 2): {name.Substring(0, 2)}"); // Henter substring fra indeks 0 til 1
        Console.WriteLine($"Replace 'Edward' with 'Eddy': {name.Replace("Edward", "Eddy")}");
        Console.WriteLine($"Is null or whitespace: {string.IsNullOrWhiteSpace(name)}");
        Console.WriteLine($"Is null or empty: {string.IsNullOrEmpty(name)}");
        Console.WriteLine($"Has A: {name.Contains("A")}");
        Console.WriteLine($"Has a: {name.Contains("a")}");
        Console.WriteLine($"Has case insensitive 'a': {name.Contains("a", StringComparison.OrdinalIgnoreCase)}");

        Console.WriteLine("REMEMBER: strings NEVER change in C#, because they are immutable.");
        string otherName = "Frank";
        Console.WriteLine($"otherName: {otherName}"); // Frank
        otherName.ToUpper();
        Console.WriteLine($"otherName after ToUpper without assignment (otherName.ToUpper()): {otherName}"); // Frank
        otherName = otherName.ToUpper(); // reassigns a new uppercase string to otherName
        Console.WriteLine($"otherName after ToUpper with assignment (otherName = otherName.ToUpper()): {otherName}"); // FRANK
    }
}