// Найти сумму элементов от M до N помощью рекурсии. N и M заданы

Console.WriteLine ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine ()); 
Console.WriteLine ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine ()); 

void SumDigit(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма всех элеменов равна: {sum} ");
        return;
    }
    sum = sum + (m++);
    SumDigit(m, n, sum);
} 
SumDigit(m, n, 0);
