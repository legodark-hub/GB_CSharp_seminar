// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int num = 2;
while(num<=n) {
    Console.WriteLine(num);
    num+=2;
};
