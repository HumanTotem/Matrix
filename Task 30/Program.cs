int Square(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }
   return a * Square(a, b-1);
}
System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("В степень какого числа его надо возвести: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Square(number1, number2));