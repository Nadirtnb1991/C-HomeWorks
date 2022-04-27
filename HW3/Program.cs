/*
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Enter FiveDigit number ");
int N = Convert.ToInt32(Console.ReadLine());


if (N / 10000 == N % 10 && N / 1000 % 10 == N / 10 % 10)
{
    Console.WriteLine("Entered number IS palindrome");
}
else
{
    Console.WriteLine("Entered number is NOT palindrome");
}
*/

/*
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Sqrt1(double x1, double y1, double z1, double x2, double  y2, double z2)

{
    return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2-y1)*(y2-y1)+(z2 - z1) * (z2 - z1));
}

Console.WriteLine("Enter coordinate X first dot ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Y first dot ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Z first dot ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate X second dot ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Y second dot ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Z second dot ");
double z2 = Convert.ToInt32(Console.ReadLine());


Console.Write(Sqrt1(x1, y1,z1, x2,y2,z2));
*/

/*
// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Sqrt1(int N)
{
    int count = 1;
    Console.Write(N + "->");
    while (count <= N)
    {
        Console.Write(count*count*count + " ");
        count++;
    }
}
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
    Sqrt1(num);
else
    Console.Write("Enter positive number!!!");

*/