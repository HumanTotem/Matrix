﻿// Console.WriteLine("Введите имя: ");
// string name = Console.ReadLine();
// if(name.ToLower() == "маша")
// {
//     Console.WriteLine("Это Маша");
// }
// else
// {
//     Console.WriteLine($"Привет, {name}");
// }
int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 40;
int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa;
int y = xb;
int count = 0;
while (count < 100)
{
    int bib = new Random().Next(0,3);
    if(bib == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if(bib == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(bib == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}