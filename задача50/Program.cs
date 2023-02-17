// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
double[,] Create2DArray(int[] array)
{
    double[,] result = new double[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            Console.WriteLine($"Введите значение элемента {i}-ой строки {j}-го столбца");
            result[i, j] = double.Parse(Console.ReadLine());
        }
    }
    return result;
}

double Print2DArrayElement(int[] pos, double[,] array)
{
    if (array.GetLength(0) > pos[0] && array.GetLength(1) > pos[1]) return (array[pos[0], pos[1]]);
    else {Console.WriteLine("Элемента в заданной позиции нет"); return 0;};
}

Console.WriteLine("Задайте число строк и стобцов массива через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
double[,] createdArray = Create2DArray(array);
Console.WriteLine("Задайте позицию элемента массива через пробел");
string input1 = Console.ReadLine();
int[] pos = input1.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(Print2DArrayElement(pos, createdArray));