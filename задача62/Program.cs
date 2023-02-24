//Напишите программу, которая заполнит спирально массив 4 на 4.



int[,] SpiralFill(int[,] array)
{
    int num = 1; 
    for (int s = 0; s < array.GetLength(0) / 2; s++) //каждый круг спирали заполняется в цикле
    {
        int i = s;  //стартовая позиция круга
        int j = s;
        for (int x = j; x < array.GetLength(1); x++) //движение вправо
        {
            if (array[i, x] == 0)
            {
                array[i, x] = num++;
                j = x;
                PrintArray(array);
                Console.WriteLine();
            }
        }
        for (int x = i + 1; x < array.GetLength(0); x++) //движение вниз
        {
            if (array[x, j] == 0)
            {
                array[x, j] = num++;
                i = x;
                PrintArray(array);
                Console.WriteLine();
            }
        }
        for (int x = j - 1; x >= s; x--) //движение влево
        {
            if (array[i, x] == 0)
            {
                array[i, x] = num++;
                j = x;
                PrintArray(array);
                Console.WriteLine();
            }
        }
        for (int x = i - 1; x > s; x--) //движение вверх
        {
            if (array[x, j] == 0)
            {
                array[x, j] = num++;
                i = x;
                PrintArray(array);
                Console.WriteLine();
            }
        }
    }
    Console.WriteLine();
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

int[,] array = new int[4, 4];
SpiralFill(array);