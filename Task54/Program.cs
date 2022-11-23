// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//метода создает массив из произвольных чисел.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//метод печатает массив.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

//метод сортирует по убыванию.
int[,] SortColumnsMatrixDescend(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int s = j + 1; s < matrix.GetLength(1); s++)
            {
                if (matrix[i, j] < matrix[i, s])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, s];
                    matrix[i, s] = temp;
                }   
            }         
        }
    }
    return matrix;
}

//метод сортирует по возрастанию.
int[,] SortColumnsMatrixAscend(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int s = j + 1; s < matrix.GetLength(1); s++)
            {
                if (matrix[i, j] > matrix[i, s])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, s];
                    matrix[i, s] = temp;
                }   
            }         
        }
    }
    return matrix;
}

int[,] array2D = CreateMatrixRndInt(10, 10, 10, 100);
PrintMatrix(array2D);
Console.WriteLine(" ");

Console.WriteLine("Массив каждой строки двумерного массива располагаем по убыванию: ");
int[,] sortarray = SortColumnsMatrixDescend(array2D);
PrintMatrix(sortarray);
Console.WriteLine(" ");

Console.WriteLine("Массив каждой строки двумерного массива располагаем по возрастанию: ");
int[,] sortarray2D = SortColumnsMatrixAscend(sortarray);
PrintMatrix(sortarray2D);