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
static void Starter()
{
    ScoringTable();
    ShowMenu();
    StartProgram();
}

static void StartProgram()
{
    Player currentPlayer = null;
    ScoreInFile scoreInFileInstance = new ScoreInFile();

    while (true)
    {
        var input = Console.ReadLine()!;
        var inputUpper = input.ToUpper();

        if (inputUpper == "Q" && Player.playerAdded)
        {
            Console.WriteLine($"Zawodnik został już dodany. Nie można ponownie dodać");
        }
        else
        {
            switch (inputUpper)
            {
                case "Q":
                    Console.Clear();
                    currentPlayer = SetPlayerDataStat();
                    break;

                case "W":
                    ShowPlayerInfo(currentPlayer);
                    break;

                case "E":
                    ScoreInFile.ShowPlayerStat(scoreInFileInstance);
                    break;

                case "R":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Nie wybrano żadnej opcji!");
                    continue;
            }
        }
    }
}
static void ShowPlayerInfo(Player player)
{
    if (player != null)
    {
        Console.WriteLine("\nWprowadzone dane piłkarza:");
        Console.WriteLine();
        Console.WriteLine($"Imię: {player.Name}");
        Console.WriteLine($"Nazwisko: {player.Surname} ");
        Console.WriteLine($"Kraj: {player.Country} ");
        Console.WriteLine();
        ShowMenuAfterAddPlayer();
    }
    else
    {
        Console.WriteLine("Nie wprowadzono jeszcze danych piłkarza");
    }
}
static void ShowMenu()
{
    Console.WriteLine("naciśnij ==> Q żeby dodać piłkarza i go ocenić ");
    Console.WriteLine("naciśnij ==> W żeby wyświetlić dane piłkarza ");
    Console.WriteLine("naciśnij ==> E żeby wyświetlić statystyki piłkarza ");
    Console.WriteLine("naciśnij ==> R żeby zamknąć aplikację");
}
static Player SetPlayerDataStat()
{
    ScoreInFile scoreInFile = new ScoreInFile();
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

    Console.WriteLine();
    Console.WriteLine("Podaj ilość zdoytych goli przez zawodnika:");
    scoreInFile.AddGoals();

    Console.WriteLine();
    Console.WriteLine("Podaj ilość asyst:");
    scoreInFile.AddAssist();

    Console.WriteLine();
    Console.WriteLine("Podaj ilość żółtych kartek zdobytych w meczu:");
    scoreInFile.AddYellowCard();
    int yellowCards = scoreInFile.Ycard;
    Console.WriteLine();

    if (yellowCards < 2)
    {
        Console.WriteLine("Podaj ilośc czerwonych kartek:");
        scoreInFile.AddRedCard();
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Nie możesz dodać czerwonej kartki, ponieważ piłkarz już zdobył dwie żółte kartki");
    }
    Console.WriteLine();
    ShowMenuAfterAddPlayer();
    Player.playerAdded = true;
    return player;
}

static void ScoringTable()
{
    Console.WriteLine(" ~ strzelone bramki = (+10 pkt)\n ~ asysty = (+5 pkt)\n ~ żółta kartka = (-5 pkt)\n ~ czerwona kartka = (-15 pkt)");
    Console.WriteLine();
    Console.WriteLine("minimalna ocena ogólna to 0\nnp. jeśli dodamy bramkę (+10) i czerwoną kartkę (-15) to ocena ogólna bedzie 0");
    Console.WriteLine();
}
static void ShowMenuAfterAddPlayer()
{
    Console.WriteLine("naciśnij ==> W żeby wyświetlić dane piłkarza ");
    Console.WriteLine("naciśnij ==> E żeby wyświetlić statystyki piłkarza ");
    Console.WriteLine("naciśnij ==> R żeby zamknąć aplikację");

}