int FindSum(int fire)
{
    int sum = 0;
    while (fire > 0)
    {
        sum += fire%10;
        fire = fire/10;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindSum(number));