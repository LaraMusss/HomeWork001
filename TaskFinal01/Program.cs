// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Final 01/4!");
string[] array1 = new string[5] {"Russian", "12", "Education", "hi", "GeekBrains"};
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
System.Console.WriteLine("Вывод оригинального массива");
PrintArray(array1);
System.Console.WriteLine("Вывод нового массива");
PrintArray(array2);