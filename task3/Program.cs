// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[5,5];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        
        Console.WriteLine();
    }
}

void GetColumnAverage(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        float sum = 0;
        int counter = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
            counter++;
        }

        float average = sum / counter;
        Console.Write($"{average}; ");
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
GetColumnAverage(array);