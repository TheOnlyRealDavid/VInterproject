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
using System.Runtime.CompilerServices;

Console.WriteLine("[===--Elarion--===]");
Console.WriteLine("--Det har varit ett brutalt inbördeskrig i Elarion, Där kung Alvareon Lysandrel blev avsatt tronen av rebelen Arthur Stark och straffad för sina gryma handlingar mot folket av Elarion--");
Console.WriteLine("Tryck enter för att gå vidare");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Välkommen kära spelare, välj ditt namn på din kämpe (max 10 bokstäver)");
string heroName = Console.ReadLine();
while (heroName.Length > 10)
{
    Console.WriteLine("Ditt namn får max vara 10 bokstäver");
    heroName = Console.ReadLine();
}

Console.WriteLine($"Vilket fint namn {heroName}, tryck enter för att gå vidare");
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

int guld; // kommer användas för att köpa vapen och kunna betala för att överkomma en händelse, ex muta fienden att inte attackera

if (speläge == 2)
{
    guld = 25;
}

else
{
    guld = 100;
}





int styrka = 0; // dessa variabler kommer användas mer under spelomgången
int försvar = 0;

Console.WriteLine($"Tjenare {heroName} välkomen till min smedja, Mitt namn är Robert, Perfekt att du kom när du kom, Jag har precis tillverkad tre nya vapen vilket du kan få köpa (Skriv siffran på vapnet du vill köpa) ");
Console.WriteLine($"(Du har {guld} guld att spendera)");
Console.WriteLine("1. Svärd, 10 guld");
Console.WriteLine("2. Yxa, 5 guld");
Console.WriteLine("3. StridsHammare, 20 guld");
string vapen = Console.ReadLine();
int.TryParse(vapen, out int valdaVapen);
Console.Clear();

while (valdaVapen != 1 && valdaVapen !=2 && valdaVapen !=3)
{
    Console.WriteLine("Vänligen skriv siffran på dit önskande vapen");
    Console.WriteLine($"kom ihåg du har bara {guld} guld till dit namn");
    Console.WriteLine("1. Svärd, 10 guld");
    Console.WriteLine("2. Yxa, 5 guld");
    Console.WriteLine("3. StridsHammare, 20 guld");
    vapen = Console.ReadLine();
    int.TryParse(vapen, out valdaVapen);
    Console.Clear();
}

if (valdaVapen == 1)
{
    Console.WriteLine($"Fint val {heroName} ditt svärd kommer tjäna dig bra på dina äventyr - Robert ");
    Console.ReadLine();
    styrka += 5;
    försvar += 15;
    guld -= 10;
    Console.Clear();
}

else if (valdaVapen == 2)
{
    Console.WriteLine($"Fint val {heroName} din yxa kommer tjäna dig bra på dina äventyr - Robert (Tryck enter för att gå vidare)");
    Console.ReadLine();
    styrka += 10;
    försvar += 0;
    guld -= 5;
    Console.Clear();
}

else
{
    Console.WriteLine($"Fint val {heroName} din StridsHammare kommer tjäna dig bra på dina äventyr - Robert (Tryck enter för att gå vidare) ");
    Console.ReadLine();
    styrka += 20;
    försvar += 10;
    guld -= 20;
    Console.Clear();
}




int avstånd = 0; // denna variabel kommer avändas senare under spelomgången och är tänk att användas till att räkna ut hur många händelser som kommer inträffa, (högre avstånd mer händelser)

Console.WriteLine($"Det finns äventyr att ta till dig, {heroName} - Robert");
Console.WriteLine($"Jag har några ställen du kan börja din resa till- Robert (Skriv siffran på platsen du vill resa till)");
Console.WriteLine("1. Golorn");
Console.WriteLine("2. Aetherwind");
string resa = Console.ReadLine();
int.TryParse(resa, out int valdaResa);

while (valdaResa != 1 && valdaResa != 2)
{
    Console.WriteLine("Skriv siffran innan namnet på staden du vill resa till");
    Console.WriteLine("1. Golorn");
    Console.WriteLine("2. Aetherwind"); 
    resa = Console.ReadLine();
    int.TryParse(resa, out valdaResa);
    Console.Clear();
}

if (valdaResa == 1)
{
    Console.WriteLine($"Golorn är en väldig fin stad, Ett bra val {heroName} (Tryck enter för att gå vidare)");
    Console.ReadLine();
    avstånd += 20;
    Console.Clear();
}
else if (valdaResa == 2)
{
    Console.WriteLine($"Aetherwind är en unik men väldig fint slott, Ett bra val {heroName} (Tryck enter för att gå vidare)");
    Console.ReadLine();
    avstånd += 10;
    Console.Clear();
}






// Spelomgång

int hälsa = 100;

while (avstånd > 0 && hälsa > 0)
{
    List<string> händelser = ["bakhåll", "handlare", "vilt djur" ];
    string händelse = händelser[Random.Shared.Next(händelser.Count)];

    if (händelse == "bakhåll")
    {
        Console.WriteLine($"det är ett {händelse}!");
        Console.ReadLine();
    }

    else if (händelse == "handlare")
    {
        Console.WriteLine($"det kom en {händelse}!");
        Console.ReadLine();
    }

    else if (händelse == "vilt djur")
    {
        Console.WriteLine($"ett {händelse} dök upp!");
        Console.ReadLine();
    }

    
}





// Slut
 
 if (hälsa > 0)
{
    Console.WriteLine($"Ett bra försök {heroName}, men ditt liv slockandes, (Tryck enter för att avsluta spelet)");
    Console.ReadLine();
}

else if (avstånd > 0 && valdaResa == 1)
{
   Console.WriteLine($"Bra jobbat {heroName}, du kom fram till Golorn, (Tryck enter för att avsluta spelet)"); 
   Console.ReadLine();
}

else if (avstånd > 0 && valdaResa == 2)
{
    Console.WriteLine($"Bra jobbat {heroName}, du kom fram till Aetherwind, (Tryck enter för att avsluta spelet)"); 
    Console.ReadLine();
}