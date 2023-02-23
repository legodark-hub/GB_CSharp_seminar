// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
int[,] Generate2DArray(int[] array)
{
    int[,] result = new int[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            result[i, j] = new Random().Next(array[2], array[3]);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return result;
}

int[,] Sort2DArrayRows(int[,] array)
{
    for (int h = 0; h < array.GetLength(0); h++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[h, i] < array[h, j])
                {
                    int k = array[h, i];
                    array[h, i] = array[h, j];
                    array[h, j] = k;
                }
            }
        }

    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте число строк и стобцов массива, минимальное и максимальное значение элементов через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
PrintArray(Sort2DArrayRows(Generate2DArray(array)));

