# 100 C# Concepts

Et praktisk læringsprosjekt for å utforske 100 konsepter innen C# og .NET.

Prosjektet følger YouTube-videoen **«Master C# in 100 Minutes – 100 Concepts Every Developer Should Know»**, der hvert konsept implementeres som et eget kodeeksempel.

## 🎯 Formål

Målet er å lære C# gjennom praktisk programmering, eksperimentering og utforsking, fremfor å bare følge en videoleksjon.

Hvert konsept implementeres som et lite, selvstendig eksempel som kan kjøres, endres og videreutvikles.

Med bakgrunn fra JavaScript/Node.js og Python brukes prosjektet også til å utforske likheter og forskjeller mellom disse språkene og C#.

## 🛠️ Teknologier

- C# / .NET 9
- Visual Studio Code
- C# Dev Kit
- Docker / Dev Containers

Utviklingsmiljøet kjører i en Docker-container basert på Microsofts offisielle .NET SDK-image. Dermed er prosjektet uavhengig av en lokal .NET-installasjon.

## 📁 Prosjektstruktur

```text
100-cs-concepts/
├── .devcontainer/       # Docker-utviklingsmiljø
├── Grunnleggende/       # Variabler, datatyper, arrays osv.
├── Kontrollflyt/        # Løkker, betingelser og switch
│   └── ForLoop.cs
├── Objektorientering/   # Klasser, arv, interfaces osv.
├── Program.cs           # Applikasjonens startpunkt
└── 100-cs-concepts.csproj
```

Konseptene organiseres etter tema, med én C#-fil per konsept.

## 🚀 Kom i gang

### Forutsetninger

- Docker
- Visual Studio Code
- Dev Containers-utvidelsen

### Kjør prosjektet

1. Klon repoet.
2. Åpne prosjektmappen i VS Code.
3. Velg **Dev Containers: Reopen in Container**.
4. Vent til utviklingsmiljøet er startet.
5. Kjør følgende kommando i terminalen:

```bash
dotnet run
```

Det er ikke nødvendig å installere .NET SDK lokalt.

## 💻 Kodeeksempel

Hvert konsept implementeres i en egen klasse med en statisk `Kjor()`-metode, som kan kalles fra `Program.cs`.

**Kontrollflyt/ForLoop.cs**

```csharp
namespace Kontrollflyt;

public static class ForLoop
{
    public static void Kjor()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iterasjon: {i}");
        }
    }
}
```

**Program.cs**

```csharp
using Kontrollflyt;

ForLoop.Kjor();
```

Resultat:

```text
Iterasjon: 0
Iterasjon: 1
Iterasjon: 2
Iterasjon: 3
Iterasjon: 4
```

## 📚 Læringsmetode

For hvert konsept gjennomføres følgende:

1. Se den aktuelle delen av videoen.
2. Pause videoen og implementer konseptet selv.
3. Kjør koden og kontroller resultatet.
4. Eksperimenter med egne endringer og varianter.
5. Gå videre til neste konsept.

Prosjektet bygges gradvis ut etter hvert som nye konsepter gjennomgås.

## 📝 Om prosjektet

Dette er et personlig læringsprosjekt og en sandkasse for eksperimentering, ikke en produksjonsapplikasjon.

Hovedfokuset er å forstå språket, syntaksen og prinsippene bak C# og .NET.

Kodeeksemplene prioriterer lesbarhet og læring fremfor avansert arkitektur eller optimalisering.

Klasser, metoder og variabler navngis i hovedsak på norsk, mens etablerte programmeringsbegreper beholdes på engelsk der det er naturlig.

## 📺 Inspirasjon og kilder

Prosjektet er inspirert av YouTube-videoen **«Master C# in 100 Minutes – 100 Concepts Every Developer Should Know»**, samt dokumentasjon og læringsressurser fra Microsoft Learn.

Kodeeksemplene er skrevet og tilpasset som en del av egen læring.