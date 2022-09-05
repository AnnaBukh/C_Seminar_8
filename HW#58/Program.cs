// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

// формула: 
//1ая матрица A[i,k] размером M*K, 2ая матрица B[k,j] размером K*N, итоговая матрица С[i,j] размером M*N
// проверка условия - произведение возможно, если кол-во столбцов матрицы А равно количеству столбцов матрицы B 
//C[i,j] = Summ(A[i,k]*B[k,j) 

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

int[,] arrayA = CreateMatrix(2, 4, 1, 9);
PrintMatrix(arrayA);
Console.WriteLine();

int[,] arrayB = CreateMatrix(3, 2, 1, 9);
PrintMatrix(arrayB);
Console.WriteLine();

int [,] Product2Matrix(int[,] matrixA, int[,] matrixB)
{

int[,] matrixC =  new int[matrixA.GetLength(0), matrixB.GetLength(1)];

for (int i = 0; i < matrixA.GetLength(0); i++)
            {
 if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
    Console.Write("Размер матриц не корректен, матрицы нельзя перемножить");
    break;
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
                }
            }
return matrixC;
}

int[,] arrayC = Product2Matrix(arrayA, arrayB);
PrintMatrix(arrayC);
