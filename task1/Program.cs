// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void FillArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);