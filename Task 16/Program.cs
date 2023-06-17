int[] FillArrayWithRandomNumbers(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = rnd.Next(1, 9);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine(string.Join(", ", array));
int sum = 0;
for(int index = 1; index < array.Length; index = index + 2)
{
    sum = sum + array[index];
}
System.Console.WriteLine($"Сумма элементов на нечетных позициях равнв {sum}");