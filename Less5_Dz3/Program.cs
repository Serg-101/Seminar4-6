/*
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
using System;

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] FillArray(int firstDemension, int secondDemention)
{
    Random rnd = new Random();
    int[,] arr = new int[firstDemension, secondDemention];
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemention; j++) arr[i, j] = rnd.Next(0, 10);
    }
    return arr;
}

double AverageCol(int[,] arr, int collumn)
{
    int summ = 0;
    int count = arr.GetLength(0);
    for (int i = 0; i < count; i++) summ += arr[i, collumn];
    return Convert.ToDouble(summ) / count;
}

double[] AverageColumnAllOverArray(int[,] arr)
{
    double[] AvgColumn = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
        AvgColumn[i] = AverageCol(arr, i);
    return AvgColumn;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            System.Console.Write($"{arr[i, j]} \t");
        System.Console.WriteLine();
    }
}

//Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив чисел");
PrintArray(arr);
double[] arr2 = AverageColumnAllOverArray(arr);
System.Console.WriteLine("суммы столбцов");
foreach (var item in arr2)
    Console.Write($"{Math.Round(item,1)}\t");
System.Console.WriteLine();
Console.ReadKey();
