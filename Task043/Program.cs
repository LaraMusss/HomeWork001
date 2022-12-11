// Найти точку пересеч двух прямых заданных уравнениями
// y=k1*x+b1  y=k2*x+b2
// b1 k1 b2 k2 задает пользователь
Console.WriteLine("Введите b1=");
double b1=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите k1=");
double k1=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите b2=");
double b2=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите k2=");
double k2=Convert.ToInt32 (Console.ReadLine());
double x=(b1-b2)/(k2-k1);
double y=k2*x+b2;
x=Math.Round(x, 3);
y=Math.Round(y, 3);
Console.WriteLine($"Точка пересечения двух прямых ({x},{y})");

