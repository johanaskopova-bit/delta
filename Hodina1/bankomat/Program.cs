    int volba;
    double zustatek = 15394;
    double castka;
  

    Console.WriteLine(" 1 - vypsat zustatek \r\n 2 - vybrat penize \r\n 3 - vlozit penize \r\n 0 - KONEC");
    
    
    do
    {
        volba = int.Parse(Console.ReadLine());

        switch (volba)
        {
            case 1:
                Console.WriteLine("Zůstatek: "+ zustatek);
                break;
            case 2:
                Console.WriteLine("Napište kolik peněz chcete vybrat ");
                castka = double.Parse(Console.ReadLine());
                if (zustatek < castka)
                {
                    Console.WriteLine("Error... Tato částka nemůže být vybrána kvůli nedostatku peněz na účtě");
                }
                else
                {
                    Console.WriteLine("Výběr se zpracovává... Vyčkejte chvíli...");
                    zustatek -= castka;
                    Console.WriteLine("Nový zůstatek: " + zustatek);
                }
                    break;
            case 3:
                Console.WriteLine("Kolik peněz chcete vložit");
                castka = double.Parse(Console.ReadLine());
                if (castka > 0)
            {
                zustatek += castka;
                Console.WriteLine("Nový zůstatek: " + zustatek);
            }
                else
                {
                    Console.WriteLine("Error");
                }
               
                break;
            case 0:
                Console.WriteLine("Zmáčkňete 0 pro uplné dokončení");
                break;
            default:
                Console.WriteLine("Špatná možnost");
                break;
        }
    }
    while (volba != 0);
    Console.ReadKey();
    Console.WriteLine("  KONEC");
   
    