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


//================================================================================
// Start
//--------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("[===--Elarion--===]");
Console.WriteLine("--Det har varit ett brutalt inbördeskrig i Elarion, Där kung Alvareon Lysandrel blev avsatt tronen av rebelen Arthur Stark och straffad för sina gryma handlingar mot folket av Elarion--");
Console.WriteLine("Tryck enter för att gå vidare");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Välkommen kära spelare, välj ditt namn på din kämpe (max 10 bokstäver)");
string hjälteNamn = Console.ReadLine();
while (hjälteNamn.Length > 10)
{
    Console.WriteLine("Ditt namn får max vara 10 bokstäver");
    hjälteNamn = Console.ReadLine();
}

Console.WriteLine($"Vilket fint namn {hjälteNamn}, tryck enter för att gå vidare");
Console.ReadLine();
Console.Clear();




//============================================================================================
//Beslutagande
//--------------------------------------------------------------------------------------------

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

Console.WriteLine($"Tjenare {hjälteNamn} välkomen till min smedja, Mitt namn är Robert, Perfekt att du kom när du kom, Jag har precis tillverkad tre nya vapen vilket du kan få köpa (Skriv siffran på vapnet du vill köpa) ");
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
    Console.WriteLine($"Fint val {hjälteNamn} ditt svärd kommer tjäna dig bra på dina äventyr - Robert ");
    Console.ReadLine();
    styrka += 5;
    försvar += 15;
    guld -= 10;
    Console.Clear();
}

else if (valdaVapen == 2)
{
    Console.WriteLine($"Fint val {hjälteNamn} din yxa kommer tjäna dig bra på dina äventyr - Robert (Tryck enter för att gå vidare)");
    Console.ReadLine();
    styrka += 10;
    försvar += 0;
    guld -= 5;
    Console.Clear();
}

else
{
    Console.WriteLine($"Fint val {hjälteNamn} din StridsHammare kommer tjäna dig bra på dina äventyr - Robert (Tryck enter för att gå vidare) ");
    Console.ReadLine();
    styrka += 20;
    försvar += 10;
    guld -= 20;
    Console.Clear();
}




int avstånd = 0; // denna variabel kommer avändas senare under spelomgången och är tänk att användas till att räkna ut hur många händelser som kommer inträffa, (högre avstånd mer händelser)

Console.WriteLine($"Det finns äventyr att ta till dig, {hjälteNamn} - Robert");
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
    Console.WriteLine($"Golorn är en väldig fin stad, Ett bra val {hjälteNamn} (Tryck enter för att gå vidare)");
    Console.ReadLine();
    avstånd += 20;
    Console.Clear();
}
else if (valdaResa == 2)
{
    Console.WriteLine($"Aetherwind är en unik men väldig fint slott, Ett bra val {hjälteNamn} (Tryck enter för att gå vidare)");
    Console.ReadLine();
    avstånd += 15;
    Console.Clear();
}





//============================================================================================
// Spelomgång
//--------------------------------------------------------------------------------------------

int hälsa = 100;

while (avstånd > 0 && hälsa > 0)
{
    List<string> händelser = ["bakhåll", "handlare", "vilt djur" ];
    string händelse = händelser[Random.Shared.Next(händelser.Count)];

//===========================================================================================
// Händesle Bakhåll
//-------------------------------------------------------------------------------------------

    if (händelse == "bakhåll")
    {
        Console.WriteLine($"det är ett {händelse}!, vad tänker du göra?");
        Console.WriteLine("1. Försöka muta orcen");
        Console.WriteLine("2. Bekämpa orcen");
        Console.WriteLine("3. Försöka att springa iväg");
        string bakhåll = Console.ReadLine();
        int.TryParse(bakhåll, out int bVallet); // bvalet står för det vall som man väler under bahålls, alltså bvallet
        Console.ReadLine();

        while (bVallet != 1 && bVallet != 2 && bVallet !=3)
        {
            Console.WriteLine("Du kan bara välja mellan 1, 2 eller 3");
            Console.WriteLine($"1. Försöka muta orcen, du har {guld} guld ");
            Console.WriteLine("2. Bekämpa orcen");
            Console.WriteLine("3. Försöka att springa iväg");
            bakhåll = Console.ReadLine();
            int.TryParse(bakhåll, out bVallet);
            Console.Clear();
        }

        if (bVallet == 1)
        {
            if (guld < 15)
            {
                Console.WriteLine("Du har inte tillräckligt guld för att jag ska ge mig - orc");
                Console.WriteLine("Var beräd att känna mitt vrede- orc");
                Console.ReadLine();
                Console.Clear();
                bVallet ++;
                
            }

            if (guld > 15)
            {
            Console.WriteLine("Jaaa, ge mig 15 guld och du är fri att gå- orc");
            Console.ReadLine();
            Console.Clear();
            avstånd -= 5;
            guld -= 15;
            }

        }

        if (bVallet == 2)
        {
        
            int orcHälsa = 100;
            int spelOmgång = 0;
            Console.WriteLine("Du tror att du kan besegra mig- orcen");
            Console.Clear();
            
                
                while (hälsa > 0 && orcHälsa > 0)
                {  
                    spelOmgång ++;
                    Console.WriteLine($"--=== Omgång {spelOmgång} ===-- ");
                    Console.WriteLine($"{hjälteNamn}: {hälsa}    Orchen: {orcHälsa}");

                    int spelarSkada = Random.Shared.Next(16);
                    Console.WriteLine($"{hjälteNamn} gjorde {spelarSkada} skada");
                    Console.WriteLine($"Din syrka bidrar med en skada på {styrka}");
                    orcHälsa -= spelarSkada;
                    orcHälsa -= styrka;
                    orcHälsa = Math.Max(0, orcHälsa);

                    int orcSkada = Random.Shared.Next(10, 25);
                    Console.WriteLine($"Orchen gjorde {orcSkada} skada");
                    Console.WriteLine($"Ditt försvar gav dig {försvar} liv");
                    hälsa -= orcSkada;
                    hälsa += försvar;
                    hälsa = Math.Max(0, hälsa);

                    Console.WriteLine("(Tryck enter för att gå vidare)");

                    Console.ReadLine();
                    Console.Clear();

                    if (orcHälsa <= 0)
                    {
                        Console.WriteLine($"Bra gjort {hjälteNamn}, du lyckades besegra orchen");
                        avstånd -= 10;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            
        }

        if (bVallet == 3)
        {
            int fly = Random.Shared.Next(11);
            if (fly == 0)
            {
                Console.WriteLine($"Bra gjort {hjälteNamn}, du lyckades fly från orcen");
                avstånd -= 10;
                Console.ReadLine();
                Console.Clear();
            }
            else if (fly >= 1)
            {
                Console.WriteLine("Du lyckades fly från orcen men sprang åt fel håll så nu är du längre ifrån desinationen");
                avstånd += 10;
                Console.ReadLine();
                Console.Clear();  
            }
        }
    
    }

//===========================================================================================
// Händesle handlare
//-------------------------------------------------------------------------------------------

    else if (händelse == "handlare")
    {
        Console.WriteLine($"det kom en {händelse}!");
        Console.WriteLine($"Tjena {hjälteNamn} jag har några saker att sälja till dig om du önskar det (Skriv siffran på ditt val)");
        Console.WriteLine($"1. 20 liv för 20 guld, din nuvarande hälsa: {hälsa}");
        Console.WriteLine($"2. 20 styrka för 20 guld, din nuvarande syrka: {styrka} ");
        Console.WriteLine("3. Jag vill inte köpa något");
        Console.WriteLine($"Guld: {guld}");
        string hvall = Console.ReadLine();
        int.TryParse(hvall, out int hvallet); // hvallet står för valet du gjorde under händelsen handlare, alltså hvallet
        Console.Clear();

        while (hvallet != 1 && hvallet !=2 && hvallet != 3)
        {
            Console.WriteLine($"Tyvärr {hjälteNamn} du måste välja mellan någon av alternativen 1-3 ");
            Console.WriteLine($"1. 20 liv för 20 guld, din nuvarande hälsa: {hälsa}");
            Console.WriteLine($"2. 20 styrka för 20 guld, din nuvarande syrka: {styrka} ");
            Console.WriteLine("3. Jag vill inte köpa något");
            hvall = Console.ReadLine();
            int.TryParse(hvall, out hvallet);
            Console.Clear();
        }

        if (hvallet == 1 && guld > 20)
        {
            Console.WriteLine($"Tack för köpet, {hjälteNamn} - Handlaren");
            Console.ReadLine();
            Console.Clear();
            hälsa += 20;
            guld -= 20; 
        }

        else if (hvallet == 2 && guld > 20)
        {
            Console.WriteLine($"Tack för köpet, {hjälteNamn} - Handlaren");
            Console.ReadLine();
            Console.Clear();
            styrka += 20;
            guld -= 20; 
        }

        else if (hvallet == 3)
        {
            Console.WriteLine($"Det var tråkigt att du inte köpte något, {hjälteNamn} - Handlaren");
            avstånd -= 5; // här förlorar du anvstånd för du stannade inte extra länge och pratade med handelsmanen
            Console.ReadLine();
            Console.Clear();
        }

        else if (guld < 20)
        {
            Console.WriteLine($"Du hadde tyvärr inte råd med något, {hjälteNamn} - Handlare");
            Console.ReadLine();
            Console.Clear();
        }

        
    }

//===========================================================================================
// Händesle viltDjur
//-------------------------------------------------------------------------------------------


    else if (händelse == "vilt djur")
    {
        Console.WriteLine($"en {händelse} dök upp!");
        List<string> djur = ["Varg", "Älg", "Häst"];
        string djuret = djur[Random.Shared.Next(djur.Count)];
        Console.ReadLine();
        Console.WriteLine("Tryck enter för att gå vidare");
        Console.Clear();


//==============================================================================
// Varg
//------------------------------------------------------------------------------

        if (djuret == "Varg")
        {
            Console.WriteLine($"Det är en {djuret} vad tänker du göra? (skriv siffran)");
            Console.WriteLine("1. Slåss mot vargen");
            Console.WriteLine("2. Springa iväg ");
            string dValen = Console.ReadLine(); // dvValen betyder djur varg valet
            int.TryParse(dValen, out int dvValet);
            Console.Clear();

            while(dvValet != 1 && dvValet != 2)
            {
                Console.WriteLine("Du måste välje mellan 1 eller 2");
                Console.WriteLine("1. Slås mot vargen");
                Console.WriteLine("2. Springa iväg ");
                dValen = Console.ReadLine(); //dvalen betyder djurvalen
                int.TryParse(dValen, out dvValet);
                Console.Clear();
            }

            if(dvValet == 1)
            {
                int djurSpelomgång = 0;
                int vargLiv = 100;
                Console.WriteLine($"{hjälteNamn}, Vargar är farliga djur lycka till");
                Console.ReadLine();
                Console.Clear();

                while(vargLiv > 0 && hälsa > 0)
                {
                djurSpelomgång ++;
                Console.WriteLine($"--==={djurSpelomgång}===--");
                Console.WriteLine($"{hjälteNamn}: {hälsa}     Vargen: {vargLiv}");
                
                int jaktSkada = Random.Shared.Next(15);
                Console.WriteLine($"{hjälteNamn}, gjorde {jaktSkada} på vargen");
                Console.WriteLine($"Din styka bidrog med {styrka} skada");
                vargLiv -= jaktSkada;
                vargLiv -= styrka;
                vargLiv = Math.Max(0, vargLiv);

                int vargSkada = Random.Shared.Next(10, 20);
                Console.WriteLine($"Vargen gjorde {vargSkada} på {hjälteNamn}");
                Console.WriteLine($"Ditt försvar bidrog med {försvar} liv");
                hälsa -= vargSkada;
                hälsa += försvar;
                hälsa = Math.Max(0, hälsa);

                Console.WriteLine("(Tryck enter för att gå vidare)");
                Console.ReadLine();
                Console.Clear();

                if (vargLiv <= 0)
                {
                    Console.WriteLine($"Bra gjort {hjälteNamn}, du lyckades ta ner en varg ");
                    Console.ReadLine();
                    Console.WriteLine("(Tryck enter för att gå vidare)");
                    Console.Clear();
                    avstånd -= 5;

                }

                }
            }

            else if (dvValet == 2)
            {
                int fly = Random.Shared.Next(11);
                if (fly == 0)
                {
                    Console.WriteLine($"Bra gjort {hjälteNamn}, du lyckades fly från vargen");
                    avstånd -= 10;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (fly >= 1)
                {
                    Console.WriteLine("Du lyckades fly från vargen men sprang åt fel håll så nu är du längre ifrån desinationen");
                    avstånd += 10;
                    Console.ReadLine();
                    Console.Clear();  
                }
            }
        }

//==============================================================================
// Älg
//------------------------------------------------------------------------------

        else if (djuret == "Älg")
        {
            Console.WriteLine($"Det är en {djuret}, vad tänker du göra? (skriv siffran)");
            Console.WriteLine("1. Försöka smyga förbi älgen");
            Console.WriteLine("2. Försöka skräma iväg älgen");
            string däval = Console.ReadLine(); //dävalet betyder djur häst valen
            int.TryParse(däval, out int dävalet);
            Console.Clear();

            while(dävalet != 1 && dävalet != 2);
            {
                Console.WriteLine("Skriv siffran på vad du tänker göra.");
                Console.WriteLine("1. Försöka smyga förbi älgen ");
                Console.WriteLine("2. Försöka skräma iväg älgen");
                däval = Console.ReadLine();
                int.TryParse(däval, out dävalet);
                Console.Clear();
            }

            if (dävalet == 1)
            {
                int smygaFörbi = Random.Shared.Next(3);

                if(smygaFörbi == 1)
                {
                    Console.WriteLine($"{hjälteNamn}, du luckades smyga förbi älgen");
                    Console.ReadLine();
                    Console.WriteLine("(Tryck enter för att gå vidare)");
                    Console.Clear();
                    avstånd -= 5;
                }

                else
                {
                    Console.WriteLine($"{hjälteNamn}, älgen kände sig hotad och spakade dig i magen du förlorade 50 liv, nu har du {hälsa} liv kvar");
                    Console.ReadLine();
                    Console.WriteLine("(Tryck enter för att gå vidare)");
                    Console.Clear();
                    hälsa -= 50;
                }
            }
            else if (dävalet == 2)
            {
            
            }

        }

//==============================================================================
// Häst
//------------------------------------------------------------------------------

        else if (djuret == "Häst")
        {
            Console.WriteLine($"Det är en {djuret}, vad tänker du göra? (skriv siffran)");
            Console.WriteLine("1. Försöka tämja hästen");
            Console.WriteLine("2. ignorera hästen och gå vidare");
            string dhval = Console.ReadLine(); //dhvalet betyder djur häst valen
            int.TryParse(dhval, out int dhvalet);
            Console.Clear();

            while(dhvalet != 1 && dhvalet != 2);
            {
                Console.WriteLine("Skriv siffran på vad du tänker göra.");
                Console.WriteLine("1. ignorera hästen och gå vidare");
                Console.WriteLine("2. Försöka tämja hästen");
                dhval = Console.ReadLine();
                int.TryParse(dhval, out dhvalet);
                Console.Clear();
            }

            if (dhvalet == 1)
            {
                Console.WriteLine($" {hjälteNamn}, du försätter vidare på ditt äventyr");
                Console.ReadLine();
                Console.WriteLine("(Tryck enter för att gå vidare)");
                Console.Clear();
                avstånd -= 5;

            }

            else if (dhvalet == 2)
            {
                int tämja = Random.Shared.Next(100);

                if (tämja == 1)
                {
                    Console.WriteLine($" {hjälteNamn}, du lyckades tämja hästen och du rider ända till din destination utan att bemöta några fler trubbel");
                    Console.ReadLine();
                    Console.WriteLine("(Tryck enter för att gå vidare)");
                    Console.Clear();
                    avstånd = 0;
                }

                else 
                {
                    Console.WriteLine($" {hjälteNamn}, du skrämde iväg hästen");
                    Console.ReadLine();
                    Console.WriteLine("(Tryck enter för att gå vidare)");
                    Console.Clear();
                }


            }
        }
    }

    
}




//============================================================================================
// Slut
//--------------------------------------------------------------------------------------------
 
 if (hälsa <= 0)
{
    Console.WriteLine($"Ett bra försök {hjälteNamn}, men ditt liv slockandes, (Tryck enter för att avsluta spelet)");
    Console.ReadLine();
}

else if (avstånd <= 0 && valdaResa == 1)
{
   Console.WriteLine($"Bra jobbat {hjälteNamn}, du kom fram till Golorn, (Tryck enter för att avsluta spelet)"); 
   Console.ReadLine();
}

else if (avstånd <= 0 && valdaResa == 2)
{
    Console.WriteLine($"Bra jobbat {hjälteNamn}, du kom fram till Aetherwind, (Tryck enter för att avsluta spelet)"); 
    Console.ReadLine();
}