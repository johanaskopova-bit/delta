    // string jmeno = "Johana";
    //
    // int vek = 15;
    //
    // double vyska = 1.65;
    //
    // char trida = 'A';
    //
    // bool jePlnoleta = false;
    //
    // Console.WriteLine($"Jméno: (jmeno)");
    // Console.WriteLine($"Věk: (vek)");
    // Console.WriteLine($"Výška: (vyska)");
    // Console.WriteLine($"Třída A/B: (trida)");
    // Console.WriteLine($"Je plnoletý/á: {jePlnoleta}");
    
    Console.Write("Zadej Jméno: ");
    string jmeno = Console.ReadLine();
    // Console.WriteLine(jmeno);

    Console.Write("Zadej svůj věk: ");
    int vek = int.Parse(Console.ReadLine());
    // Console.WriteLine(vek);
    
    Console.Write("Zadej výšku v metrech: ");
    double vyska = double.Parse(Console.ReadLine());
    // Console.WriteLine(vyska);
    
    Console.Write("Zadej jestli chodíš do A/B: ");
    char trida = char.Parse(Console.ReadLine());
    // Console.WriteLine(trida);
    
    Console.WriteLine();
    Console.WriteLine($"Ahoj, já jsem {jmeno}. Je mi {vek}. Měřím {vyska} metrů a chodím do třídy {trida}.\r\n");
    
    // Console.WriteLine($"Jméno: {jmeno}");
    // Console.WriteLine($"Věk: {vek}");
    // Console.WriteLine($"Výška: {vyska}");
    // Console.WriteLine($"Třída A/B: {trida}");
    // Console.WriteLine($"Je plnoletý/á: {jePlnoleta}");
    
    Console.Write("Zmacknete libovolnou klavesu pro ukonceni programu.");
    Console.ReadKey();
    
    
        