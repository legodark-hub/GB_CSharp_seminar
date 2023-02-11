// Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int RandomArrayCount() {
    int[] array = new int[123];
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 1001);
        Console.Write($"{array[i]} ");
        if (array[i]>=10 && array[i]<=99) counter++;
    }
    Console.WriteLine();
    return counter;
}

Console.WriteLine(RandomArrayCount());