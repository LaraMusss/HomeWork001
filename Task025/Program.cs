// напишите цикл на вход два числа А в степень В 
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;

while (i<N)
    {
    result = result*A;  
    i++;
    }


Console.WriteLine(result);
