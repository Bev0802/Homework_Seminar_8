// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

//МЕТОДЫ
//метод создает трехмерный массив заполенный не повторяющимися числами.
int[,,] CreateArray3DInt(int rows, int columns, int depth, int min, int max)
{
    if (rows * columns * depth > max - min)
        Console.WriteLine($"Размер данного массива не позволяет заполнить его не повторяющимися числами");
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (max >= min) matrix[i, j, k] = min++;
            }
        }
    }
    return matrix;
}

//метод печататет трехмерный массив с указанием индексов каждого элемента.
void PrintArray3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],3}({i},{j},{k}) ");
                else Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
            }
        }
        Console.WriteLine(" |");
    }
}

//ВЫВОД РЕЗУЛЬТАТА
int[,,] Array3D = CreateArray3DInt(4, 2, 2, 10, 99);
PrintArray3D(Array3D);
