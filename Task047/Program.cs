// Задайте 2х мерный массив , размер m*n,
// заполненный случайными вещественными числами
Console.WriteLine("Введите размер массива: количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];
for ( int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

