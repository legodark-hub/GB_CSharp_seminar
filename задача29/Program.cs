// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
int[] GenerateArray(int min, int max) {
    int[] array = new int[8];
    for (int i=0; i<array.Length; i++) {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
Console.WriteLine("Введите минимальное число элемента массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента массива");
int max = int.Parse(Console.ReadLine());
 Console.WriteLine($"{String.Join(", ", GenerateArray(min,max))}");