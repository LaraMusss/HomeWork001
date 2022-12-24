// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
 
int SumNumbers(int m, int n)
{
    if (m == n) return n;
    return m + SumNumbers(m + 1, n);     
}
Console.WriteLine(SumNumbers(m, n));