// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double MinMaxDifference (double[] array) {
    double max = array[0];
    double min = array[0];
    foreach (double i in array) {
        if(i>max) max = i;
        if(i<min) min = i;
    }
    return Math.Abs(min-max);
}

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine();
double[] array = input.Split(' ').Select(Double.Parse).ToArray();
Console.WriteLine(MinMaxDifference(array));