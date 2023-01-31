// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
if(n>99 && n<1000) {
    Console.WriteLine(n%100/10);
}
else {
    Console.WriteLine("Число не трехзначное");
}