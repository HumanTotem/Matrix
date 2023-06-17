int[] array = {1, 2, 3, 78, 445, 656, 2232, 4, 78};
int n = array.Length;
int find = 78;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}