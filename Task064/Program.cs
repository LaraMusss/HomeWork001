// Задайте значения M и N. Напишите программу, 
// которая выдает все натуральные числа в промежутке от N до M

Console.WriteLine("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int Numbers(int n, int m)
{
    Console.WriteLine($"{(n)} ");
    if (n == m) return m;
    return Numbers(n - 1, m);     
}
Numbers(n,m);
