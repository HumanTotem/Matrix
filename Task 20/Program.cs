void FillMatrixWithRandomNumbers(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = rows + columns;
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
System.Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [,] matrica = new int[row, column];
FillMatrixWithRandomNumbers(matrica);
PrintMatrix(matrica);