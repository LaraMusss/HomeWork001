// Задать 2х мерный массив упорядочить по убыванию эл-ты строк
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


for (int i = 0; i < array.GetLength(0); i++)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k<array.GetLength(1)-1; k++)
        {
            
            if (array[i,k] < array[i,k+1]) 
            {
                int temp = array[i,k];
                array [i,k] = array [i,k+1];
                array [i,k+1] = temp;
                
            }
        Console.Write($"{array[i,k]} ");     
        }   
 
    }
    Console.WriteLine();
}
Console.WriteLine();