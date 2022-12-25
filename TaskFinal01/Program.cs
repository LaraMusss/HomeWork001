// Задание финальное ввестим массив строк, 
// вывести только массив из строк не > 3 символов
Console.WriteLine("Hello, Final 01/4!");
string[] arr1 = new string[5] {"Hello", "GeekBrains", "48", "OK", "Program"};
string[] arr2 = new string[arr1.Length];

void Array(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
Array(arr1, arr2);
System.Console.WriteLine("Первый массив:  ");
PrintArray(arr1);
System.Console.WriteLine("Новый массив:  ");
PrintArray(arr2);