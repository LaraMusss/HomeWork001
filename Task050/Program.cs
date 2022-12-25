// Задайте 2х мерный массив размер m*n,
// на вход принимает элемент и проверяет значение элемента
// или что такого эл-те нет 
Console.WriteLine("Введите размер массива: количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
for ( int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,50);
        Console.Write($"{array[i,j]}  ");
        
    }
    Console.WriteLine();
}
Console.WriteLine();

for ( int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        if (array[i,j]==Num) 
            Console.WriteLine("Число есть в массиве");
        else 
            Console.WriteLine("Числа нет в массиве"); 
    }
    Console.WriteLine();        
}
Console.WriteLine();