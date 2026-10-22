// static betyr at klassen er statisk. Du kan ikke opprette objekter av den.
// Alle medlemmene i klassen må også være statiske.
// namespace forteller C# at klassen ForLoop tilhører navnerommet Kontrollflyt

namespace Objektorientering;

/*
Det er fire grunnleggende prinsipper i objektorientert programmering:
1. Innkapsling (Encapsulation)
2. Arv (Inheritance)
3. Polymorfisme (Polymorphism)
4. Abstraksjon (Abstraction)

1. Innkapsling:
- Innkapsling handler om å beskytte dataene i en klasse ved å gjøre feltene private og gi tilgang gjennom 
offentlige metoder (gettere og settere).
- Dette bidrar til å opprettholde integriteten til objektets tilstand og hindrer uautorisert tilgang 
eller endring.

2. Arv:
- Arv gjør det mulig å opprette en ny klasse basert på en eksisterende klasse, og gjenbruke kode.
- Den nye klassen (subklasse) arver feltene og metodene fra den eksisterende klassen (superklasse), 
og kan også legge til egne felter og metoder.

3. Polymorfisme:
- Polymorfisme tillater objekter av forskjellige klasser å bli behandlet som objekter av en felles superklasse.
- Dette gjør det mulig å skrive fleksibel og gjenbrukbar kode, der metoder kan operere på objekter av ulike typer.

4. Abstraksjon:
- Abstraksjon handler om å skjule implementasjonsdetaljer og kun eksponere det som er nødvendig for brukeren av klassen.
- Dette bidrar til å redusere kompleksitet og gjøre koden mer forståelig og vedlikeholdbar.

Klasser:
- En klasse er en mal for å opprette objekter. Den definerer hvilken data og hvilke funksjonalitet objektene av klassen vil ha.
- Objekter er instanser av en klasse, og hver instans har sin egen tilstand basert på klassens felter.

*/