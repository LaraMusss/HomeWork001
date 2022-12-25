// на вход число на выход сколько цифр в числе
Console.WriteLine("Ведите число");
string number = Console.ReadLine();
int sum = 0;
int count = 0;
char []array = new char[number.Length];
for (int i=0; i<array.Length; i++)
{
    array[i] = number[i];
    count++;
    sum=sum+array[i];
    Console.WriteLine(array[i]);
    Console.WriteLine(sum);
}
//Console.WriteLine(sum);