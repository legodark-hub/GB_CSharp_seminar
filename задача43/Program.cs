// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersectionPointFinder(double[] parameters) {
    double[] coordinates = new double[2];
    coordinates[0] = (parameters[2] - parameters[0]) / (parameters[1] - parameters[3]); 
    coordinates[1] = parameters[1] * coordinates[0] + parameters[0]; 
    return coordinates;
}

Console.WriteLine("Введите парметры b1, k1, b2 и k2 уравнений прямых y = k1 * x + b1, y = k2 * x + b2 через пробел");
string input = Console.ReadLine();
double[] array = input.Split(' ').Select(double.Parse).ToArray();
Console.WriteLine(string.Join(" ", IntersectionPointFinder(array)));