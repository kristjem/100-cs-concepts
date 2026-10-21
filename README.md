# 100 C# Concepts

Et praktisk læringsprosjekt for å utforske 100 konsepter innen C# og .NET.

Prosjektet tar utgangspunkt i YouTube-videoen **[«Master C# in 100 Minutes – 100 Concepts Every Developer Should Know»](https://www.youtube.com/watch?v=yVeFlmihyGQ&t=863s)**, der hvert konsept implementeres som et eget kodeeksempel.

## 🎯 Formål

Målet er å lære C# gjennom praktisk programmering, eksperimentering og utforsking, fremfor å bare følge en videoleksjon.

Hvert konsept implementeres som et lite, selvstendig eksempel som kan kjøres, endres og videreutvikles.

Med bakgrunn fra JavaScript/Node.js og Python brukes prosjektet også til å utforske likheter og forskjeller mellom disse språkene og C#.

## 🛠️ Teknologier

- **C# / .NET 9** – programmeringsspråk og utviklingsplattform
- **Visual Studio Code** – kodeeditor
- **C# Dev Kit** – IntelliSense, debugging og prosjektstøtte
- **Docker** – containerbasert utviklingsmiljø
- **Dev Containers** – integrasjon mellom VS Code og Docker
- **Git** – versjonskontroll

## 🐳 Utviklingsmiljø med Dev Container

Prosjektet benytter en Dev Container basert på Microsofts offisielle .NET 9 SDK-image.

Dette gjør at hele utviklingsmiljøet kan gjenskapes på forskjellige maskiner, uten å installere .NET SDK direkte på operativsystemet.

Konfigurasjonen ligger i `.devcontainer/`:

```text
.devcontainer/
├── Dockerfile
└── devcontainer.json
```

**Dockerfile** definerer containerens operativsystem, .NET SDK og øvrige utviklingsverktøy.

**devcontainer.json** forteller VS Code hvordan containeren skal bygges, og hvilke utvidelser som skal installeres.

Fordeler med dette oppsettet:

- Samme .NET-versjon på alle utviklingsmaskiner.
- Ingen lokal installasjon av .NET SDK nødvendig.
- Isolert utviklingsmiljø med egne avhengigheter.
- Enkel oppstart på Windows, Linux og macOS.
- Utviklingsmiljøet versjoneres sammen med kildekoden i Git.

### Forutsetninger

Følgende må være installert på vertsmaskinen:

- Git
- Docker Engine eller Docker Desktop
- Visual Studio Code
- VS Code-utvidelsen **Dev Containers**

C#-utvidelsene installeres automatisk inne i containeren via `devcontainer.json`.

### Kom i gang

**1. Klon repositoryet**

```bash
git clone https://github.com/kristjem/100-cs-concepts.git
cd 100-cs-concepts
```

**2. Åpne prosjektet i VS Code**

```bash
code .
```

**3. Start Dev Container**

Åpne kommandopaletten med `Ctrl + Shift + P`, og velg:

`Dev Containers: Reopen in Container`

VS Code bygger Docker-imaget og starter utviklingsmiljøet. Første oppstart kan ta litt tid.

**4. Kontroller .NET-installasjonen**

Åpne terminalen inne i Dev Containeren:

```bash
dotnet --version
```

Denne skal vise en versjon av .NET SDK 9.

**5. Kjør prosjektet**

```bash
dotnet run
```

Nå er utviklingsmiljøet klart!

### Windows og WSL2

På Windows anbefales det å bruke Docker Desktop med WSL2 og lagre kildekoden på Linux-filsystemet, eksempelvis:

```text
/home/<brukernavn>/dev/100-cs-concepts
```

Prosjektet åpnes fra Ubuntu/WSL-terminalen med:

```bash
code .
```

Deretter åpnes det i Dev Container som beskrevet ovenfor.

**Hvorfor WSL2?**

Prosjekter lagret direkte på Windows-filsystemet (`C:\`) kan oppleve problemer med filovervåking når de monteres inn i Linux-containere.

Dette kan føre til at C# Dev Kit ikke oppdager nye filer, klasser eller namespaces automatisk, selv om `dotnet build` fungerer.

Ved å lagre kildekoden på WSL2 sitt Linux-filsystem unngås normalt disse problemene, samtidig som filsystemytelsen ofte blir bedre.

På Linux, for eksempel Fedora eller Ubuntu, kan prosjektet klones direkte til brukerens hjemmemappe og åpnes i Dev Container uten WSL2.

## 📁 Prosjektstruktur

```text
100-cs-concepts/
├── .devcontainer/       # Docker-utviklingsmiljø
│   ├── Dockerfile
│   └── devcontainer.json
├── Grunnleggende/       # Variabler, datatyper, arrays osv.
├── Kontrollflyt/        # Løkker, betingelser og switch
│   └── ForLoop.cs
├── Objektorientering/   # Klasser, arv og interfaces
├── Program.cs           # Applikasjonens startpunkt
├── 100-cs-concepts.csproj
├── .gitignore
└── README.md
```

Konseptene organiseres etter tema, med én C#-fil per konsept.

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

- YouTube: [«Master C# in 100 Minutes – 100 Concepts Every Developer Should Know»](https://www.youtube.com/watch?v=yVeFlmihyGQ&t=863s)
- [Microsoft Learn – C#](https://learn.microsoft.com/nb-no/dotnet/csharp/)
- [Development Containers](https://containers.dev/)
- [VS Code – Dev Containers](https://code.visualstudio.com/docs/devcontainers/containers)