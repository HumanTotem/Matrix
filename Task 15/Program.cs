int[] FillArrayWithRandomNumbers(int size)
{
    int[] array = new int[size];
    Random rnd = new Random ();
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next(100, 1000);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine(string.Join(", ", array));
int count = 0;
for (int index = 0; index < length; index++)
{
    if (array[index] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных элементов в массиве равно {count}");