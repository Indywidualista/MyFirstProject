using MyFirstProject;

Console.WriteLine("*****************************************");
Console.WriteLine("************** FC STAT v1.0 *************");
Console.WriteLine("*****************************************");
Console.WriteLine("by Indywidualista");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" Witam w prostym programie do oceny piłkarzy");
Console.WriteLine();
Console.WriteLine("po przez parę kryteriów które wpływają na jego ocenę ogólną");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("        Naciśnij dowolny klawisz żeby kontynuować...");
Console.ReadKey(true);
Console.Clear();


Starter();
void Starter()
{
    ScoringTable();
    StartProgram();
}
    
void StartProgram()
{
    ShowMenu();
    while (true)
    {
        var input = Console.ReadLine()!;
        var inputUpper = input.ToUpper();

        switch (inputUpper)
        {
            case "Q":
                SetPlayerData();
                break;

            case "W":
                ShowPlayerInfo();  // jak to naprawić ?
                break;

            case "E":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Nie wybrano żadnej opcji!");
                continue;
        }
    }
}

void ShowPlayerInfo(Player player)
{
    Console.WriteLine("\nWprowadzone dane piłkarza:");
    Console.WriteLine($"Imię: {player.Name}");
    Console.WriteLine($"Nazwisko: {player.Surname} ");
    Console.WriteLine($"Kraj: {player.Country} ");
}

static void ShowMenu()
{
    Console.WriteLine("naciśnij ==> Q żeby dodać piłkarza i go ocenić ");
    Console.WriteLine("naciśnij ==> W żeby wyświetlić dane piłkarza ");
    Console.WriteLine("naciśnij ==> E żeby zamknąć aplikację");
}
void SetPlayerData()
{
    Player player = new Player();
    Console.WriteLine();
    Console.WriteLine("Podaj imię zawodnika:");
    player.SetName();
    
    Console.WriteLine();
    Console.WriteLine("Podaj nazwisko zawodnika:");
    player.SetSurname();
   
    Console.WriteLine();
    Console.WriteLine("Podaj kraj zawodnika:");
    player.SetCountry();
    
}

static void ScoringTable()
{
    Console.WriteLine(" ~ strzelone bramki = (+10 pkt)\n ~ asysty = (+5 pkt)\n ~ żółta kartka = (-5 pkt)\n ~ czerwona kartka = (-15 pkt)");
    Console.WriteLine();
    Console.WriteLine("minimalna ocena ogólna to 0\nnp. jeśli dodamy bramkę (+10) i czerwoną kartkę (-15) to ocena ogólna bedzie 0");
    Console.WriteLine();
}