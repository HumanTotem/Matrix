// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите код дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number < 6)
{
    System.Console.WriteLine("Это будний день");
}
else if (number > 5 && number < 8)
{
    System.Console.WriteLine("Это выходной");
}
else
{
    System.Console.WriteLine("Это не код дня недели");
}