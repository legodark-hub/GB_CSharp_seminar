// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0)) //Две матрицы можно перемножить если количество столбцов первой матрицы равно количеству строк второй матрицы.
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                int res = 0;
                for (int c = 0; c<array1.GetLength(1); c++)
                {
                    res = res + array1[i, c] * array2[c, j];
                }
                result[i, j] = res;
            }
        }
        return result;
    }
    else {Console.WriteLine("матрицы нельзя перемножить");
    return new int[0,0];
    }
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

Console.WriteLine("Задайте число строк и стобцов первого массива, минимальное и максимальное значение элементов через пробел (Две матрицы можно перемножить если количество столбцов первой матрицы равно количеству строк второй матрицы.)");
string input = Console.ReadLine();
int[] array1 = input.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine("Задайте число строк и стобцов второго массива, минимальное и максимальное значение элементов через пробел (Две матрицы можно перемножить если количество столбцов первой матрицы равно количеству строк второй матрицы.)");
input = Console.ReadLine();
int[] array2 = input.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine();
PrintArray(MatrixMultiplication(Generate2DArray(array1), Generate2DArray(array2)));