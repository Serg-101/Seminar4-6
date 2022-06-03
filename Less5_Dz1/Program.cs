/*
Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

double[,] FillArray(int firstDemension, int secondDemention)
{
    Random rnd = new Random();
    double[,] arr = new double[firstDemension, secondDemention];
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemention; j++) arr[i, j] = Math.Round((rnd.NextDouble() * 20) - 10, 1);
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {   
            /*switch(Convert.ToString(arr[i,j]).Length)   // красиво форматируем таблицу
            {
                case 1:
                    System.Console.Write($"   {arr[i, j]}\t");
                    break;
                case 2:
                    System.Console.Write($"  {arr[i, j]}\t");
                    break;
                case 3:
                    System.Console.Write($" {arr[i, j]}\t");
                    break;
                case 4:
                    System.Console.Write($"{arr[i, j]}\t");
                    break;
            }*/ 
            //  сократил до одной строки
            Console.Write($"{new string(' ',4-Convert.ToString(arr[i,j]).Length)}{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
double[,] arr = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив вещественных чисел");
PrintArray(arr);
System.Console.WriteLine();
Console.ReadKey();
