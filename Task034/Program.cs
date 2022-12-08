// Задать массив случайными 3х зн положит числами
// найти кол-во чет чисел в массиве
Console.WriteLine("Массив случайных трехзначных чисел");
int [] array = new int[5];
int count =0;
for (int i=0; i<5; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i]+" ");
    if (array[i]%2==0)
    {
        count=count+1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");

