double[] FillArrayWithRandomNumbers(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine(string.Join(", ", array));
double sum = array[length - 1] - array[0];
System.Console.WriteLine($"Разница между последним и первм числами массива равна {sum}");