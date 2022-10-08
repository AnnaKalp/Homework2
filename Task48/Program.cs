﻿/*Задача48:Задайте двумерный массив размера m на n, каждый 
элемент в массиве находится по формуле:Amn = m+n.
Выведите полученный массив на экран.
m=3, n=4.
0123
1234
2345*/

Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");

    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = i + j;
        }
    }
}

