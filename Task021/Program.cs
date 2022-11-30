// На вход координаты двух точек на выход расстояние между ними в 3Д пространстве
Console.WriteLine("Введите координаты 2х точек");
Console.WriteLine("Введите координаты точки A (x1, y1, z1)");
Console.WriteLine("Введите x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (x2, y2, z2)");
Console.WriteLine("Введите x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
double z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine("Расстояние между двумя точками А и В в пространстве 3Д = ");
Console.WriteLine(result);
