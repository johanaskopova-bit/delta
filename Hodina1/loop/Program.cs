//Hádání čísla
//
// int cislo = Random.Shared.Next(1, 10001);
// int pokusy = 0;
//
//
// Console.Write("Hádej celé číslo: ");
// int tip = int.Parse(Console.ReadLine());
//
// while (tip != cislo)
// {
//     Console.WriteLine("Špatně zkus to znovu ");
//     
//     if (tip < cislo)
//     {
//         Console.Write("Číslo co hledáš je větší než co si tipl.");
//         if (cislo - tip >= 3000)
//         {
//             Console.WriteLine("Samá voda");
//         }
//         else if (cislo - tip >= 1000)
//         {
//             Console.WriteLine("Přihoříva ");
//         }
//         else  if (cislo - tip >= 400)
//         {
//             Console.WriteLine(" Skoro hoří");
//         }
//         else
//         {
//             Console.WriteLine(" Hoří");
//         }
//     }
//     else
//     {
//         Console.Write("Číslo co hledáš je menší než co si tipl.");
//         if (tip - cislo >= 3000)
//         {
//             Console.WriteLine(" Samá voda");
//         }
//         else if (tip - cislo >= 1000)
//         {
//             Console.WriteLine(" Přihořívá ");
//         }
//         else if (tip - cislo >= 400)
//         {
//             Console.WriteLine(" Skoro hoří");
//         }
//         else
//         {
//             Console.WriteLine(" Hoří");
//         }
//     }
//     
//     tip = int.Parse(Console.ReadLine());
//     pokusy = pokusy + 1;
// }
// Console. WriteLine("Výhra");
// Console.WriteLine("Trvalo to pokusů: "+pokusy);



// odpocet 
//
//
// Console.Write("napište kladné celéčíslo: ");
// int cislo = int.Parse(Console.ReadLine());
//
// while (cislo != 0)
// {
//     Console.WriteLine(cislo);
//     cislo -= 1;
// }
// Console.WriteLine("0");
// Console.WriteLine("Start!");


// soucet 1 az N
//
// int prvni = 1;
// int vysledek = 1;
//     Console.Write("Napište libovolné kladné celé číslo: ");
// int dva = int.Parse(Console.ReadLine());
//
// while (prvni - dva != 0)
// {
//     prvni += 1;
//     vysledek += prvni;
// }
// Console.WriteLine (vysledek);


//prihlášení
//
// int pin = 1234;
// int pokus = 0;
// Console.WriteLine("Zadejte čtyř místný pin pro přihlášení");
// int kod = int.Parse(Console.ReadLine());
//
// while (kod != pin && pokus != 2)
// {
//     Console.WriteLine("Chybně zadaný pin kód. \r\n Zkuste to znovu");
//     kod = int.Parse(Console.ReadLine());
//     pokus += 1;
// }
//
// if (kod == pin)
// {
//     Console.WriteLine("Vítejte váš zůstatek je: 5kč");
// }
// else
// {
//     Console.WriteLine("Přístup zamítnut k překročení limitu pokusů zadání pin kódu.");
// }


//vypis 1 - N
//
// Console.Write("Napište libovolnékladné celé číslo:");
// int cislo = int.Parse(Console.ReadLine());
// int tip = 1;
//
// for (int i = 0; i != cislo; i++)
// {
//     Console.WriteLine(tip);
//     tip++;
// }


//Součet N zadaných čísel

Console.Write("Kolik čísel chcete zadat:");
int pocet = int.Parse(Console.ReadLine());

    
