// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int NaturalNumbersSum(int m, int n)
{
    if (m < n) return m+NaturalNumbersSum(m+1,n);
    else return m;
}

Console.WriteLine("Введите начальное число промежутка");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число промежутка");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumbersSum(m,n));