/*
//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size=4;
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000+1);
    }
    return array;
}
PrintResult(FillArray(size));

void PrintResult(int[] array)
{
    int evenNumber = 0;
    int unevenNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenNumber++;
        else unevenNumber++;
    }
    Console.WriteLine("Input number: ");
    int num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Amount of evenNumber is: "+ evenNumber);
    Console.WriteLine("Amount of UNevenNumber is: " +unevenNumber);
    Console.WriteLine();
}
// Меня смузает строка 1 , мне подсказали так сделать , но что то я не пойму для чего она , интересно правильно ли сделал
*/

/*
// Задача 2. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// Например:[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0.

int size = 4;

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
PrintResult(CreateRandomArray(size));

void PrintResult(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumElements += array[i];
    }
    Console.WriteLine("Sum of numbers in odd positions is " + sumElements);
}
    
    Console.WriteLine();

// мне кажется тут не правильно , что то массивы мне тяжело даются
*/

/*
// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Наример: [3 7 22 2 78] -> 76.

int size = 5;
PrintResult(CreateRandomArray(size));

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

//вот дальше у меня проблемы , не понимаю как все сделать грамотно и куда что написать 
*/