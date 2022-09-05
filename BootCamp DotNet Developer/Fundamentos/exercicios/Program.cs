// See https://aka.ms/new-console-template for more information
using System;

int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < n; i++)
{
    if (n % i == 0)
    {
        count++;
    }
    if (count > 3)
    {
        Console.WriteLine(false);
    }

    Console.WriteLine(count == 3);
}




// using static System.Console;

// int qt = int.Parse(Console.ReadLine());

// for (int i = 0; i < qt; i++)
// {
//     string[] str = ReadLine().Split(); 
//     string a = str[0];
//     string b = str[1];

//     if (a.EndsWith(b))
//     {
//         WriteLine("encaixa");
//     } 
//     else
//     {
//         Console.WriteLine("não encaixa");
//     }
// }


// int n = int.Parse(Console.ReadLine());
// int p = 1;
// int s = 0;

// while (n > 0)
// {
//     int l = n % 10;

//     p *=  l;
//     s += l;
//     n = (n-1)/10;
// }

// Console.WriteLine(p-s);
