System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
int count = 0;
while (count < b)
{
    result = result * a;
    count++;
}
System.Console.WriteLine($"Число {a} в степени {b} равно {result}");