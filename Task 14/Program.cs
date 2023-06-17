void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.WriteLine(col[index]);
        index++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);