// Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int ArrayOddSum(int n) {
    int[] array = new int[n];
    int oddsum = 0;
    for (int i = 0; i<array.Length; i++) {
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]} ");
        if (i%2!=0) oddsum+=array[i];
    }
    Console.WriteLine();
    return oddsum;
}

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(ArrayOddSum(n));