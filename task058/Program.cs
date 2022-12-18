// Задайте две матрицы, прог-му находить произвед-е матриц
Console.WriteLine("Введите размер массива: количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
int [,] arr = new int [m,n];
int [,] newarr = new int [m,n];
for ( int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for ( int i=0; i<arr.GetLength(0); i++)
{
    for (int j=0; j<arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(0,10);
        Console.Write($"{arr[i,j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for ( int i=0; i<newarr.GetLength(0); i++)
{
    for (int j=0; j<newarr.GetLength(1); j++)
    {
        newarr[i,j] = array[i,j]*arr[i,j];
        Console.Write($"{newarr[i,j]}  ");
    }
    Console.WriteLine();
}