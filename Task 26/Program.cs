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
 int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            System.Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        int [,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }
System.Console.Write("Введите количество строк массива первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите количество строк массива второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [,] matrica = new int[row1, column1];
int [,] matrica2 = new int[row2, column2];
FillMatrixWithRandomNumbers(matrica);
PrintMatrix(matrica);
System.Console.WriteLine();
FillMatrixWithRandomNumbers(matrica2);
PrintMatrix(matrica2);
System.Console.WriteLine();
System.Console.WriteLine(MatrixMultiplication(matrica, matrica2));