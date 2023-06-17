//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine($"{number}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}