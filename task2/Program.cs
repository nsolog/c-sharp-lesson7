// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[6,6];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}

string GetArrayEl(int[,] arr)
{
    Console.Write("Введите номер столбца: ");
    int columnNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер строки: ");
    int rowNumber = Convert.ToInt32(Console.ReadLine());

    if (columnNumber < arr.GetLength(0) || rowNumber < arr.GetLength(1))
    {
        return $"{arr[columnNumber, rowNumber]}";
    }
    else
    {
        return "Такого элемента нет";
    }
}

FillArray(array);
Console.WriteLine(GetArrayEl(array));