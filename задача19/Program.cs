// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine());
bool palindrome = true;
if (n>9999 && n<100000) {
    string s = Convert.ToString(n);
    for (int c=0; c<s.Length; c++) {
        if (s[c] != s[s.Length-1-c]) {
            palindrome = false;
            break;
        }
    }
    Console.WriteLine(palindrome);
}
else {
    Console.WriteLine("Неправильный ввод");
}
