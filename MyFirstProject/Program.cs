﻿using MyFirstProject;

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
Console.WriteLine("        Naciśnij każdy klawisz żeby kontynuować...");
Console.ReadKey(true);
Console.Clear();
Console.WriteLine("kryteria takie jak:");
Console.WriteLine();
Console.WriteLine(" ~ strzelone bramki = (+10 pkt)\n ~ asysty = (+5 pkt)\n ~ żółta kartka = (-5 pkt)\n ~ czerwona kartka = (-15 pkt)");
Console.WriteLine();
Console.WriteLine("minimalna ocena ogólna to 0\nnp. jeśli dodamy bramkę (+10) i czerwoną kartkę (-15) to ocena ogólna bedzie 0");
Console.WriteLine();

List<string> footballerData = new List<string>();
Console.WriteLine("Podaj imię zawodnika:");
var name = Console.ReadLine();
footballerData.Add(name);
Console.WriteLine();
Console.WriteLine("Podaj nazwisko zawodnika:");
var surname = Console.ReadLine();
footballerData.Add(surname);
Console.WriteLine();
Console.WriteLine("Podaj kraj zawodnika:");
var country = Console.ReadLine();
footballerData.Add(country);


while (true)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine("Wybierz opcje co chcesz dodać do statystyk zawodnika:");
    Console.WriteLine();
    Console.WriteLine("1. BRAMKA\n2. ŻÓŁTA KARTKA\n3. CZERWONA KARTKA\n4. WYJŚCIE Z APLIKACJI");
    var input = Console.ReadLine();

    if (input == "4")
    {
        break;
    }


}

Console.WriteLine("\nWprowadzone dane piłkarza:");
Console.WriteLine($"Imię: {footballerData[0]}");
Console.WriteLine($"Nazwisko: {footballerData[1]}");
Console.WriteLine($"Kraj: {footballerData[2]}");
