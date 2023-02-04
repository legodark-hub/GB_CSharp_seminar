// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату X первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки");
double z2 = double.Parse(Console.ReadLine());


double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Расстояние между точками={d:f3}");
