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
int indexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = 0;
    while (index < length)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
        return position;
    }
}
int[] array = new int[10];
int what = 3;
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int pos = indexOf(array, what);
System.Console.WriteLine(pos);