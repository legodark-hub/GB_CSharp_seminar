// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] ArrayMultiplication(int[] array) {
    int[] result = new int[(array.Length+1)/2]; // создается массив размером в половину входного так, что если количество элементов во входном массиве нечетное, то размер с учетом "среднего" элемента
    for (int i = 0; i < array.Length/2; i++) {
        result[i] = array[i] * array[array.Length-1-i];
    }
    if (array.Length%2 != 0) result[array.Length/2] = array[array.Length/2]; //если число элементов во входе нечетное, то его средний элемент "без пары" добавляется в выходной массив
    return result;
}

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine();
int[] array = input.Split(' ').Select(Int32.Parse).ToArray();
Console.WriteLine(string.Join(" ", ArrayMultiplication(array)));

