// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if (N>0) {
    foreach (int value in Enumerable.Range(1, N)) {
        Console.Write($"{Math.Pow(value, 3)} ");
    }
}
else {
    foreach (int value in Enumerable.Range(N, -N)) {
        Console.Write($"{Math.Pow(value, 3)} ");
    }
}


