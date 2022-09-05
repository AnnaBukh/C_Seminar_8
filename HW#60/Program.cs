// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int [,,] CreateMass3D(int row, int col, int app, int min, int max)
{
    //int[,,] matrix3D = new int[row, col, app];
    //Random rnd = new Random();
    int[,,] matrix3D = new int[row, col, app]; 
    int ch = 1; 
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
             for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
            //matrix3D[i,j,k] += rnd.Next(99);
            matrix3D[i,j,k] = min + ch;
            ch++;
            }
        }
    }
    return matrix3D;
}

//void PrintMass3D(int[,,] matrix3D)
//{
 //   for (int i = 0; i < matrix3D.GetLength(0); i++)
 //   {
 //       Console.WriteLine("Applicate  "+ (i + 1));
  //      for (int j = 0; j < matrix3D.GetLength(1); j++)
  //      {
   //         for (int k = 0; k < matrix3D.GetLength(2); k++)
   //         {
    //             Console.Write(matrix3D[i, j, k] + " ");
     //       }
     //   Console.WriteLine();
     //   }
    //Console.WriteLine();
   // }
//}

void PrintMass3D(int[,,] matrix3D)
{
       for (int k = 0; k < matrix3D.GetLength(2); k++) //(int i = 0; i < matrix3D.GetLength(0); i++)
    {
        //Console.WriteLine("Applicate  "+ (i + 1));
        for  (int i = 0; i < matrix3D.GetLength(0); i++) //(int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)//(int k = 0; k < matrix3D.GetLength(2); k++)
            {
                 Console.Write(matrix3D[i, j, k] ); // вывод элемента
                 Console.Write( $" ({i}, {j}, {k})     "); // вывод индекса элемента
            }
        Console.WriteLine();
        }
    //Console.WriteLine();
    }
}

int[,,] array3D = CreateMass3D(2, 2, 2, 10, 99);
PrintMass3D(array3D);
Console.WriteLine();