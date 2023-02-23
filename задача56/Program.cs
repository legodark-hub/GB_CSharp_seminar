// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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

void LowestRowSum(int[,] array) {
    int min = 0;
    int minRow=1;
    for (int x = 0; x < array.GetLength(1); x++) {
        min+=array[0,x];
    }
    Console.WriteLine(min);
    for (int i = 1; i < array.GetLength(0); i++)
    {   
        int sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];
        }
        Console.WriteLine(sum);
        if (sum<min) {
            min = sum;
            minRow = i+1;
        }
        
    }
    Console.WriteLine($"строка с минимальной суммой элементов - {minRow}");
}

Console.WriteLine("Задайте число строк и стобцов массива, минимальное и максимальное значение элементов через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
LowestRowSum(Generate2DArray(array));