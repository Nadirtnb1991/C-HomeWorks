/*
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Middle()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + "->");
    int num1 = num% 100;
    int num2 = num1/10;
    

    Console.Write(num2);
}


Middle();

*/

/*

//Задача2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Last()
{
    int num1 = new Random().Next(1, 999);
    Console.Write(num1 + "->");
    
    if (num1>99)
    {
        while(num1>999)
        num1/=10;
        num1%=10;
        {
            Console.Write("Have third number");
        }
    }
    else
        {
            Console.Write("Don't have third number");
        }

    

    Console.Write(num1);
}

Last();

*/


/*
//Задача3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day <1 )
{
    Console.WriteLine("Incorrect number of day");
}

if(day>=1 && day<=5)
    {
        Console.Write("Is not dayoff");
    }
else
{
    if (day==6)
    {
        Console.Write("Is dayoff");
    }
    if (day==7)
    {
        Console.Write("Is dayoff");
    }

}

*/