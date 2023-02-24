// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool CheckRepeat(int[,,] array, int val){
    foreach(int p in array) {
        if (p==val) return true;
    }
    return false;
}

int[,,] Generate3DArray(int[] array)
{
    int[,,] result = new int[array[0], array[1], array[2]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            for (int k = 0; k < array[2]; k++)
            {
                int num = new Random().Next(10, 100);

                while (CheckRepeat(result, num))
                {
                    num = new Random().Next(10, 100);
                }
                result[i, j, k] = num;
                Console.WriteLine($"{result[i, j, k]} ({i},{j},{k})");
            }
        }

    }
    Console.WriteLine();
    return result;
}

Console.WriteLine("Задайте размерность трехмерного массива через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
if (array[0] * array[1] * array[2] > 89) Console.WriteLine("Для данной размерности нельзя сформировать трёхмерный массив из неповторяющихся двузначных чисел");
else Generate3DArray(array);