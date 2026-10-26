   //složené podmínky
   
    Console.Write("Zadejte věk. ");
    
        int vek = int.Parse(Console.ReadLine());
    
    bool plantostListku = bool.Parse(Console.ReadLine());
    
    if (plantostListku && vek >= 15)
    {
        Console.WriteLine("Můžete vztoupit do areálu.");
    }
    else
    {
        Console.WriteLine("Nemůžete vztoupit. ");
    }
 
    