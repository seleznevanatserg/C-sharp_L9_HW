/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using static UserMethods.Method;

Console.WriteLine("Enter number N and M (number >= 0)");
int numberN = InputIntNumberTryParse();
int numberM = InputIntNumberTryParse();

if (numberM < 0 || numberN < 0) // проверка на >= 0
{
    Console.WriteLine("Uncorrect number");
    while (numberM < 0)
    {
        Console.WriteLine("Enter number M");
        numberM = InputIntNumberTryParse();
    }
    while (numberN < 0)
    {
        Console.WriteLine("Enter number N");
        numberN = InputIntNumberTryParse();
    }
}


int a = AkkermanFuncion(numberN, numberM);
Console.WriteLine(a);



int AkkermanFuncion(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    else
    {
        if ((numN != 0) && (numM == 0)) return AkkermanFuncion(numN - 1, 1);
        else return AkkermanFuncion(numN - 1, AkkermanFuncion(numN, numM - 1));
    }
}