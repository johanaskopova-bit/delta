//Hádání čísla

int cislo = Random.Shared.Next(1, 10001);
int pokusy = 0;


Console.Write("Hádej celé číslo: ");
int tip = int.Parse(Console.ReadLine());

while (tip != cislo)
{
    Console.WriteLine("Špatně zkus to znovu ");
    
    if (tip < cislo)
    {
        Console.Write("Číslo co hledáš je větší než co si tipl.");
        if (cislo - tip >= 3000)
        {
            Console.WriteLine("Samá voda");
        }
        else if (cislo - tip >= 1000)
        {
            Console.WriteLine("Přihoříva ");
        }
        else  if (cislo - tip >= 400)
        {
            Console.WriteLine(" Skoro hoří");
        }
        else
        {
            Console.WriteLine(" Hoří");
        }
    }
    else
    {
        Console.Write("Číslo co hledáš je menší než co si tipl.");
        if (tip - cislo >= 3000)
        {
            Console.WriteLine(" Samá voda");
        }
        else if (tip - cislo >= 1000)
        {
            Console.WriteLine(" Přihořívá ");
        }
        else if (tip - cislo >= 400)
        {
            Console.WriteLine(" Skoro hoří");
        }
        else
        {
            Console.WriteLine(" Hoří");
        }
    }
    
    tip = int.Parse(Console.ReadLine());
    pokusy = pokusy + 1;
}
Console. WriteLine("Výhra");
Console.WriteLine("Trvalo to pokusů: "+pokusy);
