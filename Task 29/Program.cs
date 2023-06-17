int FindSum(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number % 10 + FindSum(number / 10);
}








System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());