// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

double[,] Generate2DArray(int[] array)
{
    double[,] result = new double[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            result[i, j] = new Random().NextDouble() * (array[3] - array[2]) + array[2];
            Console.Write($"{result[i, j]:0.00} ");
        }
        Console.WriteLine();
    }
    return result;
}

Console.WriteLine("Задайте число строк и стобцов массива, минимальное и максимальное значение элементов через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
Generate2DArray(array);