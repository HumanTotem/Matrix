//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NumbersToN(int number)
{
    if(number == 0)
    {
        return;
    }
    System.Console.Write($"{number} ");
    NumbersToN(number-1);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersToN(number);