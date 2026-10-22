/* Eksempler på bruk av BoolLogikk-klassen
using Grunnleggende;
using Kontrollflyt;
BoolLogikk.Sammenlign(10, 20);
BoolLogikk.LogiskOg(10, 20);
BoolLogikk.LogiskEller(10, 20);

char karakter = Kontrollflyt.ifElse.lagKarakter(85);
Console.WriteLine($"Karakteren er {karakter}");

*/
/*
using Objektorientering;

Person person1 = new Person();
Person person2 = new Person("Ola");
Person person3 = new Person("Kari", 42);

Console.WriteLine($"{person1.Navn}, {person1.Alder}");
Console.WriteLine($"{person2.Navn}, {person2.Alder}");
Console.WriteLine($"{person3.Navn}, {person3.Alder}");

Elbil elbil1 = new Elbil("Tesla", "Model X", 2018, 100);
Console.WriteLine($"{elbil1.Merke}, {elbil1.Modell}, {elbil1.År}, {elbil1.Drivlinje}, {elbil1.BatterikapasitetkWh}");

Bil elbil2 = new Bil("Nissan", "Leaf", 2020, Bil.DrivlinjeType.Elektrisk);
Console.WriteLine($"{elbil2.Merke}, {elbil2.Modell}, {elbil2.År}, {elbil2.Drivlinje}, ");

Bil bil3 = new Bil("Ford", "Mondeo", 2014, Bil.DrivlinjeType.Diesel);
Console.WriteLine($"{bil3.Merke}, {bil3.Modell}, {bil3.År}, {bil3.Drivlinje}");
*/

using Objektorientering;

ElbilUnderklasse elbil1 = new ElbilUnderklasse("Tesla", "Model X", 2018, 100, 500);
Console.WriteLine($"{elbil1.Merke}, {elbil1.Modell}, {elbil1.År}, {elbil1.BatterikapasitetkWh}, {elbil1.RekkeviddeKm}");

HybridbilUnderklasse hybridbil1 = new HybridbilUnderklasse("Toyota", "Prius", 2020, 50, 300, 40, "Bensin");
Console.WriteLine($"{hybridbil1.Merke}, {hybridbil1.Modell}, {hybridbil1.År}, {hybridbil1.BatterikapasitetkWh}, {hybridbil1.RekkeviddeKm}, {hybridbil1.DrivstofftankLiter}, {hybridbil1.Drivstofftype}");

DieselbilUnderklasse dieselbil1 = new DieselbilUnderklasse("Volkswagen", "Passat", 2015, 60);
Console.WriteLine($"{dieselbil1.Merke}, {dieselbil1.Modell}, {dieselbil1.År}, {dieselbil1.DrivstofftankLiter}, {dieselbil1.Drivstofftype}");
