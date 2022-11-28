// на входе число, на выходе третью цифру или нет третьей цифры
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N<100)
{    
    Console.WriteLine("Нет третьей цифры");
}
else if (N<1000)
    {        
        
        Console.WriteLine(N%10);
    }
    else if (N<10000)
        { 
            N=N/10;
            Console.WriteLine(N%10);    
        }