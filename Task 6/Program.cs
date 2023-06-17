//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
    while (number > 999)
    {
        number = number/10;
    }
    number = number % 10;
    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Третьего числа нет");
}
