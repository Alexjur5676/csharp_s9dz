// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SUM = 0;
Console.Write($"Сумма чисел от {M} до {N}: ");
Console.Write(PrintMToN(N,M,SUM));

int PrintMToN(int n, int m, int sum )
{
    if (m<= n)
    {
        sum = sum + m;
        m++;
        return PrintMToN(n, m, sum);
    }
    return sum; 
}