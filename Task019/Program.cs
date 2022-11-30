// На вход пятизначное число, проверяет является ли оно палиндромом (зеркальным), пример: 23532 является
Console.WriteLine("Введите пятизначное число по одной цифре через энтер");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
if (a==e && b==d)
{
    Console.WriteLine("Число является палиндроном");
}
else
{
    Console.WriteLine("Число не является палиндроном");
}
