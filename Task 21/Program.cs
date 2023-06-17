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
void MakeSquares(int[,] matrix)
{
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (rows % 2 == 0 && columns % 2 == 0)
            {
                matrix[rows, columns] = matrix[rows, columns] * matrix[rows, columns];
                System.Console.Write(matrix[rows, columns] + "\t");
            }
            else
            {
                System.Console.Write(matrix[rows, columns] + "\t");
            }
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
System.Console.WriteLine();
MakeSquares(matrica);