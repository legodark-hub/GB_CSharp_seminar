// Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
int NumberSum (int num) {
    int sum = 0;
    while (num>0) {
        sum = sum + num%10;
        num/=10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
 Console.WriteLine($"Сумма цифр числа - {NumberSum(num)}");