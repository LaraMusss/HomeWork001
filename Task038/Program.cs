// Задать массив вещественных чисел
// найти разницу между макс и мин значениями элементов массива
Console.WriteLine("Массив случайных чисел");
int [] array = new int[5];
int result =0;
for (int i=0; i<5; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i]+" ");
}
for (int i=0; i<4; i++)
{
    int minPos = i;
    for (int j=i+1; j<5; j++)
    {
        if (array[j]<array[minPos]) minPos=j;
    }
    int maxPos = i;
    for (int e=i+1; e<5; e++)
    {
        if (array[e]>array[maxPos]) maxPos=e;
    }
result = array[maxPos] - array[minPos];
}

Console.WriteLine($"Разница между значениями макс и мин = {result}");

