//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if (a>b) {
    Console.WriteLine($"Большее число - {a}, меньшее число - {b}");
}
else if (a<b) {
    Console.WriteLine($"Большее число - {b}, меньшее число - {a}");
}
else {
    Console.WriteLine($"Числа {a} и {b} равны");
};