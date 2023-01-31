// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите  число");
int n = int.Parse(Console.ReadLine());
if(n>99) {
    string s = Convert.ToString(n);
    Console.WriteLine(s[2]);
}
else {
    Console.WriteLine("Третьей цифры нет");
}