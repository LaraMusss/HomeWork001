// На вход цифру, на выход выходной или будни
Console.WriteLine("ВВедите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day==6 || day==7)
    Console.WriteLine("выходной");
else
    Console.WriteLine("будний день");    