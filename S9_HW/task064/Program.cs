/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using static UserMethods.Method;

Console.WriteLine("Enter number");
int number = InputIntNumberTryParse();

if (number < 1) // проверка на > 0
{
    Console.WriteLine("Uncorrect number");
    while (number < 1)
    {
        Console.WriteLine("Enter number");
        number = InputIntNumberTryParse();
    }
}

int[] resultArray = NumberBetweenNto1(number, number);
PrintArray(resultArray);

// метод для расчёта чисел от N до 1 с записью в одномерный массив
int[] NumberBetweenNto1(int num, int count, int[] arr = null, int index = 0)
{
    if (arr is null)
    {
        arr = new int[num];
    }

    if (index < arr.Length)
    {
        arr[index] = count;
        NumberBetweenNto1(num, count-1, arr, index + 1);
    }
    return arr;
}