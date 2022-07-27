Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма натуральных элементов = {sum}");
    return;
  }
  PrintSum(m, n - 1, sum);
}