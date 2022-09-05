// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
///Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


int [,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //i < row, (0) - строки 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// j < col , (1) - столбцы 
        {
        matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        //if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
        //else Console.Write($"{matrix[i,j], 3}");
// вариант с помощью тернарного оператора
        Console.Write(j < matrix.GetLength(1) - 1 ?
         $"{matrix[i,j], 3}," : 
         $"{matrix[i,j], 3}");
        }
         Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrix(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();

void RowSortDown(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++) 
    {                                
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)  //(int j = matrix.GetLength(1) - 1; j > 0; j--) 
        {                          
            for (int k = 0; k < matrix.GetLength(1)- 1; k++) 
            {
             if (matrix[i, k] < matrix[i, k + 1]) 
             {
                int var = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = var;
             }
            }
        }
    }    
}
RowSortDown(array2D);
PrintMatrix(array2D);
Console.WriteLine();