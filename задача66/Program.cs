// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int NaturalNumbersSum(int m, int n, int sum = 0)
{
    if (m <= n) return NaturalNumbersSum(m+1,n,sum+m);
    else return sum;
}

Console.WriteLine("Введите начальное число промежутка");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число промежутка");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumbersSum(m,n));