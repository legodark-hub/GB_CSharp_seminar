// Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int ArrayEvenCounter(int n) {
    int[] array = new int[n];
    int evencounter = 0;
    for (int i = 0; i<array.Length; i++) {
        array[i] = new Random().Next(1,1000);
        Console.Write($"{array[i]} ");
        if (array[i]%2==0) evencounter++;
    }
    Console.WriteLine();
    return evencounter;
}

Console.WriteLine("Введите размер массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(ArrayEvenCounter(n));