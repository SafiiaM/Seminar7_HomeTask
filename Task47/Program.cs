﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine($"Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Double[,] CreateMatrixRndDouble(int m, int n)
{
    double[,] array = new double[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble();

        }
    }
    return array;

}

void PrintMatrix(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)

        {
            if (j == 0) Console.Write("[");

            double AlignmentNumber = Math.Round(arr[i, j], 1);
            Console.Write(AlignmentNumber + " ");
        }
        Console.WriteLine("]");
    }
}


double[,] matrix = CreateMatrixRndDouble(num1, num2);
PrintMatrix(matrix);

