// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1.
void PrintNaturalNumbers(int n)
{
    if (n > 0)
    {
        Console.WriteLine(n);
        PrintNaturalNumbers(n - 1);
    }
}

Console.WriteLine("Ведите натуральное число");
PrintNaturalNumbers(int.Parse(Console.ReadLine()));