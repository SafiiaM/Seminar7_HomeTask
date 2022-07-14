// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Введите номер строки массива: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine($"Введите номер столбца массива: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; // строки
int m = 4; // столбцы
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine($"Заданный массив: ");


int[,] CreateMatrix(int n, int m)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10, 99);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}

void ReturnPosition(int pos1, int pos2)
{
    if (pos1 > 0 & pos1 < arr.GetLength(0) - 1
        & pos2 > 0 & pos2 < (arr).GetLength(1) - 1)
    {
        Console.WriteLine("Такого числа в массиве нет ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    }
    Console.ReadLine();
}


CreateMatrix(n, m);
ReturnPosition(pos1, pos2);

