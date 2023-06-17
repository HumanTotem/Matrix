void FillMatrixWithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = rnd.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            System.Console.Write(matrix[rows, columns] + "\t");
        }
        System.Console.WriteLine();
    }
}
void FindMin(int[,] matrix)
{
    int sum = 0;
    int temp = 0;
    for(int rows = 0; rows < 1; rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            temp = temp + matrix[rows, columns];
        }
    }
     for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            sum = sum + matrix[rows, columns];
        }
        if (sum < temp)
        {
            temp = sum;
            sum = 0;
        }
        System.Console.WriteLine(temp);
    }
    
}
System.Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [,] matrica = new int[row, column];
FillMatrixWithRandomNumbers(matrica);
PrintMatrix(matrica);
System.Console.WriteLine();
FindMin(matrica);