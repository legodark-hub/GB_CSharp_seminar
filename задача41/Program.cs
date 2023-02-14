// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

int PositiveNums(double[] array) {
    int counter = 0;
    foreach (double a in array) {
        if (a>0) counter++;
    }
    return counter;
}

Console.WriteLine("Введите набор чисел через пробел");
string input = Console.ReadLine();
double[] array = input.Split(' ').Select(Double.Parse).ToArray();
Console.WriteLine(PositiveNums(array));