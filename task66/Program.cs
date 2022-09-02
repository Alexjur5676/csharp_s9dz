// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;

if (M >= N || M < 0 || N < 0 )
{
  Console.Write("Введите положительное значение M меньшее N" );
} 
else
{
  SumNumbersMToN(N, M, Sum);
  Console.Write($"Сумма чисел от {M} до {N}: ");
  Console.Write(SumNumbersMToN(N, M, Sum));
}

int SumNumbersMToN(int n, int m, int sum )
{
    if (m<= n)
    {
        sum = sum + m;
        m++;
        return SumNumbersMToN(n, m, sum);
    }
    return sum; 
}