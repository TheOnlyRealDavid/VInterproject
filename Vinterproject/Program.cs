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
bool success = int.TryParse(heroName, out int name);
while (heroName.Length >= 10)
{
    Console.WriteLine("Ditt namn får max vara 10 bokstäver");
    heroName = Console.ReadLine();
    int.TryParse(heroName, out name);
}

Console.WriteLine($"Vilket fint namn {heroName}");
Console.ReadLine();
Console.Clear();


//Beslutagande