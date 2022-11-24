// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц. 
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
//https://studwork.org/spravochnik/matematika/matricy/umnojenie-matric

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

//Метод перемножения матриц друг на друга.
int [,] ProductMatrices(int[,]mat1,int[,]mat2)
{
    int [,] ProductMatrices = new int [mat1.GetLength(0),mat2.GetLength(1)];
       
    for (int i = 0; i < mat1.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
             int sum = 0;
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
               
                sum += mat1[i,k] * mat2[k,j];
            }
            ProductMatrices[i,j] = sum;
        }
    }
    return ProductMatrices;
}
           
                 

//ПРОГРАММА
int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 10);
Console.WriteLine("ПЕРВАЯ МАТРИЦА: ");
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrixRndInt(4, 3, 1, 10);
Console.WriteLine(" ");
Console.WriteLine("ВТОРАЯ МАТРИЦА: ");
PrintMatrix(matrix2);

//Проверка матиц на возможность переможения
if (matrix1.GetLength(0) != matrix2.GetLength(1) && matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы имею не допустимый размер для перемножения");
        return;         
    }

Console.WriteLine(" ");

//вывод результата
Console.WriteLine("ПРОИЗВЕДЕНИЕ МАТРИЦА: ");
int [,] productMatrices=ProductMatrices(matrix1, matrix2);
PrintMatrix(productMatrices);
