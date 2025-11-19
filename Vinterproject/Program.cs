// Start
// spelaren presenteras till spelet med en kortfattad förklaring om vad spelet är men en titel, kort historia, instruktioner.
// Spelaren får välja sitt namn på sin karaktär

// Beslutstagande
// Spelaren får välja mellan normal eller hardcore mode (skillnaden är antalet guld spelaren börjar med)
// Spelaren presenteras i medeltidiksa smedja och från välja mellan att köpa 3 olika vapen
// Spelaren får välja mellan 2 platser som hen vill börja vandra till

// Spelomgången
// Spelaren kommer bemöta olika händelser på vägen emot den valda platsen
// När spelaren bemöter en händelse kommer hen få några alternativ hur hen kan lösa dem
// Beroende på hens val så kommer spelaren antligen förlora något som exempelvis liv, pengar eller få något som exepelvis pengar

// Slut
// Om spelaren kommer fram till sin plats utan att dö kommer hen vinna spelet men om hen dör så kommer hen förlora spelet



// Start
using System.ComponentModel.DataAnnotations;

Console.WriteLine("[===--Elarion--===]");
Console.WriteLine("--Det har varit ett brutalt inbördeskrig i Elarion, Där kung Alvareon Lysandrel blev avsatt tronen av rebelen Arthur Stark och straffad för sina gryma handlingar mot folket av Elarion--");
Console.WriteLine("Tryck en valfri knapp för att gå vidare");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Välkommen kära spelare, välj ditt namn på din kämpe (max 10 bokstäver)");
string heroName = Console.ReadLine();
while (heroName.Length > 10)
{
    Console.WriteLine("Ditt namn får max vara 10 bokstäver");
    heroName = Console.ReadLine();
}

Console.WriteLine($"Vilket fint namn {heroName}, tryck el valfri kanpp för att gå vidare");
Console.ReadLine();
Console.Clear();


//Beslutagande
Console.WriteLine("Vilken svårhetsgrad(1 eller 2)?");
Console.WriteLine("1.Normal");
Console.WriteLine("2.Hardcore");
string svårhetsgrad = Console.ReadLine();
int.TryParse(svårhetsgrad, out int speläge);
Console.Clear();

while(speläge != 1 && speläge !=2)
{
    Console.WriteLine("Välj din svårhets grad (skriv 1 eller 2)");
    Console.WriteLine("1.Normal");
    Console.WriteLine("2.Hardcore");
    svårhetsgrad = Console.ReadLine();
    int.TryParse(svårhetsgrad, out speläge);
    Console.Clear();
}

int guld;

if (speläge == 2)
{
    guld = 20;
}

else
{
    guld = 100;
}

Console.WriteLine($"Tjenare {heroName} välkomen till min smedja, Mitt namn är Robert, Perfekt att du kom när du kom, Jag har precis tillverkad tre nya vapen vilket du kan få köpa (Skriv siffran på vapnet du vill köpa) ");
Console.WriteLine("1. Svärd");
Console.WriteLine("2. Yxa");
Console.WriteLine("3. StridsHammare");
string vapen = Console.ReadLine();
int.TryParse(vapen, out int valdaVapen);
Console.Clear();

while (valdaVapen != 1 && valdaVapen !=2 && valdaVapen !=3)
{
    Console.WriteLine("Vänligen skriv siffran på dit önskande vapen");
    Console.WriteLine("1. Svärd");
    Console.WriteLine("2. Yxa");
    Console.WriteLine("3. StridsHammare");
    vapen = Console.ReadLine();
    int.TryParse(vapen, out valdaVapen);
    Console.Clear();
}

if (valdaVapen == 1)
{
    Console.WriteLine($"Fint val {heroName} ditt svärd kommer tjäna dig bra - Robert ");
    Console.ReadLine();
    Console.Clear();
}

else if (valdaVapen == 2)
{
    Console.WriteLine($"Fint val {heroName} din yxa kommer tjäna dig bra - Robert ");
    Console.ReadLine();
    Console.Clear();
}

else
{
    Console.WriteLine($"Fint val {heroName} din StridsHammare kommer tjäna dig bra - Robert ");
    Console.ReadLine();
    Console.Clear();
}

