// int input = int.Parse(Console.ReadLine());
//
// switch (input)
// {
//     case 1:
//         Console.WriteLine("Pondělí");
//         break;
//     case 2:
//         Console.WriteLine("Úterý");
//         break;
//     case 3:
//         Console.WriteLine("Středa");
//         break;
//     case 4:
//         Console.WriteLine("Čtvrtek");
//         break;
//     case 5:
//         Console.WriteLine("Pátek");
//         break;
//     case 6:
//         Console.WriteLine("Sobota");
//         break;
//     case 7:
//         Console.WriteLine("Neděle");
//         break;
//     default:
//         Console.WriteLine("Neplatná operace");
//         break;
// }

//Kalkulačka

Console.Write("Zadejte první číslo: ");
double prvni = double.Parse(Console.ReadLine());
Console.Write("Zadejte druhé číslo: ");
double druhe = double.Parse(Console.ReadLine());

Console.Write("Zadejte operátora: ");
char znak = char.Parse(Console.ReadLine());

double vysledek;
vysledek = 0;

switch (znak)
{
    case '+':
        vysledek = prvni + druhe;
        Console.WriteLine("Výsledek je " + vysledek);
        break;
    case '-':
        vysledek = prvni - druhe;
        Console.WriteLine("Výsledek je " + vysledek);
        break;
    case '*':
        vysledek = prvni * druhe;
        Console.WriteLine("Výsledek je " + vysledek);
        break;
    case '/':
        vysledek = prvni / druhe;
        if (druhe == 0)
        {
            Console.WriteLine("Nejde dělit 0 ");
        }
        else
        {
            Console.WriteLine("Výsledek je " + vysledek);
        }
        break;
    default:
        Console.WriteLine("Operace je neplatná :( ");
        break;
}