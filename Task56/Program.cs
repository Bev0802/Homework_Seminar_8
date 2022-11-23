// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

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

//метод находит сумму строк массива
int[] SumRowsMatrix(int[,] matrix)
{
    int[] SumRowsMat = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        int num;
        //int resultSum;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            num = matrix[i, j];
            //Console.Write($"{sum}, ");
            sum += num;
        }
        SumRowsMat[i] = sum;
    }
    return SumRowsMat;
}

//метод печатает одномерный массив.
void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    //Console.Write("] ");
}

//метод находит номер строки с наименьшим числом.
int NumberRowSmallestSumElements(int[] array)
{
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            row = i+1;
        }

    }
    return row;
}

//ПРОГРАММА
int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine(" ");

Console.Write("Суммы строк массива: ");
int[] sumRowsMatrix = SumRowsMatrix(array2D);
PrintArray(sumRowsMatrix);
Console.WriteLine(" ");

//Вывод результата
int numberRowSmallestSumElements = NumberRowSmallestSumElements(sumRowsMatrix);
Console.Write($"Номер строки с наименьшей суммой элементов: {numberRowSmallestSumElements}");
