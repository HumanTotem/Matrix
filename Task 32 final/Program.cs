//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    else if(n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m, n-1));
    }
}
System.Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана равна {Akkerman(number1, number2)}");
