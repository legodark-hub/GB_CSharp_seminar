// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
int[,] Generate2DArray(int[] array)
{
    int[,] result = new int [array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            result[i, j] = new Random().Next(array[2], array[3]);
            Console.Write($"{result[i, j]:0.00} ");
        }
        Console.WriteLine();
    }
    return result;
}

double[] GetArithmeticMeanColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++){
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++){
            sum+=array[i,j];
        }
        result[j] = sum/array.GetLength(0);
        Console.Write($"{result[j]:0.00} ");
    }
    return result;
}

Console.WriteLine("Задайте число строк и стобцов массива, минимальное и максимальное значение элементов через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
GetArithmeticMeanColumns(Generate2DArray(array));