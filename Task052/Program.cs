// Задайте 2х мерный массив , размер m*n,
// заполненный случайными целыми числами,
// найдите ср арифм элем в каждом столбце
Console.WriteLine("Введите размер массива: количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
for ( int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,100);
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}


for ( int j=0; j<array.GetLength(1); j++)
{
    int sum = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        
        if (i==i)
        sum=(sum+array[i,j]);
    }
    Console.WriteLine();
    
    Console.WriteLine($"ср арифм сумма столбца = {sum/m} ");
}
Console.WriteLine();
