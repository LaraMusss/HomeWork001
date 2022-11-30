// выводит 3ю цифру многозначного числа или сообщает что ее нет
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N<100)
{
    Console.WriteLine("Нет третьей цифры");
} 
else if (N>=100 && N<1000)
    {
        Console.WriteLine(N%10);
    }
    else 
    {
        while (N>1000)
        {
            N=N/10;
        }
    }
    

