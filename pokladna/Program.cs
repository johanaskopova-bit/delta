    //pokladna
    
    
    Console.WriteLine("Cena jednoho lístku je 120kč");
    Console.Write("Kolik lístků chcete koupit? ");
    int pocetListku = int.Parse(Console.ReadLine());
    
    int listek = 120;
    Console.WriteLine("zaplatil");
    int zaplatil = int.Parse(Console.ReadLine());
    int celkovaCena = pocetListku * listek;
    int rozdil = zaplatil-celkovaCena;
    // int absolutniHodnota = Math.Abs(hodnota);
    // if (hodnota >= zaplatil)
    // {
    //     Console.WriteLine("vratilo se: " + hodnota);
    // }
    // else
    // {
    //     Console.WriteLine("Málo jste zaplatily");
    // }
    
    // e code:
    if (rozdil > 0)
    {
        Console.WriteLine("Vratit: " + rozdil);
    }
    else if (rozdil == 0)
    {
        Console.WriteLine("Zaplaceno akorat.");
    }
    else
    {
        Console.WriteLine("Zbyvajici castka k doplaceni: " + Math.Abs(rozdil));
    }
    
    
    
    //cena cesty
    
    
    // Console.WriteLine("Cena za jeden litr benzínu je 46kč a nafty stojí 49kč.");
    // int nafta = 49;
    // int benzin = 46;
    // Console.Write("Kolik km jste ujeli? ");
    // double ujel = double.Parse(Console.ReadLine());
    //
    // Console.Write("Jakou máte spotřebu litrů máte na sto kilometrů? ");
    // double spotreba = double.Parse(Console.ReadLine());
    //
    // Console.Write("Jezdíte na naftu zmáčkněte 1 jestli na benzín zmáčkněte jiné číslo. ");
    // int nafben = int.Parse(Console.ReadLine());
    // double spotrebaP = spotreba /100 * ujel;
    // double cenaCesty = 0;
    // if (nafben == 1)
    // {
    //      cenaCesty = spotrebaP * nafta;
    // }
    // else
    // {
    //      cenaCesty = spotrebaP * benzin;
    // }
    //
    // Console.WriteLine("Spotřebovali jste litrů paliva: "+spotrebaP);
    // Console.WriteLine("Cena projetého paliva: "+cenaCesty);
    
    Console.Write("Pro ukončení programu zmáčkněte libovolnou klávesu. ");
    Console.ReadKey();
    
    