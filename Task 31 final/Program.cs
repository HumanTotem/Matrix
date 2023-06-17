//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NumbersFromTo(int a, int b)
{
    if(b == a)
    {
        return b;
    }
   return b + NumbersFromTo(a, b - 1);
}
System.Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    System.Console.WriteLine($"Ошибка: число {number1} больше числа {number2}");
}
else
{
    System.Console.WriteLine($"Сумма чисел от {number1} до {number2} равна {NumbersFromTo(number1, number2)}");
}






