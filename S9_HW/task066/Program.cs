/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static UserMethods.Method;

Console.WriteLine("Enter number M and N");
int numberM = InputIntNumberTryParse();
int numberN = InputIntNumberTryParse();

if (numberM < 1 || numberN < 1 ) // проверка на > 0
{
    Console.WriteLine("Uncorrect numbers");
    while (numberM < 1)
    {
        Console.WriteLine("Enter number M");
        numberM = InputIntNumberTryParse();
    }
    while (numberN < 1)
    {
        Console.WriteLine("Enter number N");
        numberN = InputIntNumberTryParse();
    }
}

if (numberM > numberN) // проверка на M < N 
{
    int n = numberN;
    numberN = numberM;
    numberM = n;
}

int sumNumForMtoN = SumNumberBetweenMtoN(numberM, numberN);
Console.WriteLine($"Number M = {numberM}; Number N = {numberN};");
Console.WriteLine($"Sum numbers between M to N = {sumNumForMtoN}");

// метод подсчёта суммы между M и N (границы включены)
int SumNumberBetweenMtoN(int numM, int numN)
{
    if (numM > numN) return 0;
    else return numN + SumNumberBetweenMtoN(numM, numN - 1);
}
