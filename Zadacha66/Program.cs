﻿int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}