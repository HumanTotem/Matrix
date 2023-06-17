void NumbersToN(int number)
{
    if(number == 0)
    {
        return;
    }
    NumbersToN(number-1);
    System.Console.Write($"{number} ");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersToN(number);