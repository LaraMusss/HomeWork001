// На вход ввести трехзначное значение, на выход вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a/10;
Console.WriteLine(b%10);
