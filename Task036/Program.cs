// Задать одомерный массив случайными числами
// найти сумму значений элементов нечетных позиций
Console.WriteLine("Массив случайных чисел");
int [] array = new int[4];
int sum =0;
for (int i=0; i<4; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i]+" ");
    if (i%2==0)
    {
    }
    else
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($"сумма значений нечетных элементов в массиве = {sum}");

