// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите  цифру, обозначающую день недели");
int n = int.Parse(Console.ReadLine());
if(n>0 && n<8) {
    if(n>5) Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
}
else {
    Console.WriteLine("Неправильный ввод");
}