// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
Console.Write("Введите неотрицательное значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0)
    Console.Write("Введите неотрицательное значение M и N" );
else
    Ackerman_function(M, N);
    
Console.Write("Значение функции Акермана: ");
Console.Write(Ackerman_function(M, N));

int Ackerman_function(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return Ackerman_function(m - 1, 1);
    else
      return Ackerman_function(m - 1, Ackerman_function(m, n - 1));
}
