// Введите прямоугольный 2х мерный массив
// 
// найти строку с наименьшей суммой эл-в
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
int sum = 0;
int summin=0;

for ( int i=0; i<array.GetLength(0); i++)
{
    
    for (int j=0; j<array.GetLength(0); j++)
    {
        sum =(sum  +array[i,j]);
        if (sum<summin) summin=sum;  
    }
    Console.WriteLine();
    Console.WriteLine($"сумма строки = {sum} ");

}  
Console.WriteLine($"минимальная сумма строки = {summin} ");
Console.WriteLine();
