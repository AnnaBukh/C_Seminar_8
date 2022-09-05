//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[,] array2D = CreateMatrix(5, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();

int [] MatrixRowMinSumm(int[,] matrix) // получение матрицы с суммами элементов по строкам 
{
    int [] sum = new int [matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)   // (int j = 0; j < matrix.GetLength(1); j++)
    {                                      
        for (int j = 0; j < matrix.GetLength(1); j++) // (int i = 0; i < matrix.GetLength(0); i++)
        {                                               
        sum [i] += matrix[i,j]; 
        }
    }    
 return sum;
}

int[] arrayRowMinSum = MatrixRowMinSumm(array2D);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

PrintArray(arrayRowMinSum);

Console.WriteLine();
// поиск индекса наименьшего числа в массиве

void IndMinElement(int[] array)
{
int minEl = array[0];
int minInd = 0;
for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < minEl) 
      {
       minEl = array[i];
       minInd = i;
       }
    } 
Console.Write($"номер строки с наименьшей суммой элементов:  {minInd + 1}");     
}
IndMinElement(arrayRowMinSum);