/*
Задача 50: Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/


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
        for (int j = 0; j < secondDemention; j++) arr[i, j] = rnd.Next(0,10);
    }
    return arr;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) System.Console.Write($"{arr[i, j]}  ");
        System.Console.WriteLine();
    }    
}

int LookupForNumber(int [,] arr, int position)
{
    int row = (position / arr.GetLength(1));
    int col = (position % arr.GetLength(1));
    return arr[row,col];
}

int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = FillArray(firstDemension,secondDemention);
System.Console.WriteLine("Исходный массив чисел");
PrintArray(arr);
System.Console.WriteLine();
System.Console.Write("введите позицию элемента который хотите получить:");
int position = int.Parse(Console.ReadLine());
if (position>= (firstDemension*secondDemention)) 
{
    System.Console.WriteLine($"{position} -> Такого числа в массиве нет");
    return;
}
int number = LookupForNumber(arr, position);
System.Console.WriteLine($"{number} запрошенное число");


