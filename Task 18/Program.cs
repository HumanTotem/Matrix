// string[,] table = new string[2, 5];
// table[1,2] = "хуй";
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int col = 0; col < 5; col++)
//     {
//         System.Console.WriteLine($"+{table[rows, col]}+");
//     }
// }

void FillArray(int[,] matrix)
{
    Random rnd = new Random();
     for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rnd.Next(1,10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int col = 0; col < matrix.GetLength(1); col++)
        {
            System.Console.Write($"{matrix[row, col]} ");
        }
        System.Console.WriteLine();
    }
}

double FindSum(int row, int col)
{
    
}

int[,] matr = new int[3, 3];
FillArray(matr);
PrintArray(matr);
System.Console.WriteLine();
int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);
FindSum(matr);