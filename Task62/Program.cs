// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    
    for (int i = 0; i < matrix.GetLength(0)-3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (max >= min) matrix[i, j] = min++;
        }
    }  
    
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

int [,] productMatrices=CreateMatrixRndInt(4,4,1,16);
PrintMatrix(productMatrices);