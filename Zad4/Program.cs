// Написать программу вычисления функции Аккермана с помощью рекурсии. 

Console.WriteLine("Введите число m, от 0 до 3: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n, от 0 до 5: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m, int n)
{
    {
        if (m == 0)
            return n + 1;

        else if (m > 0 && n == 0)
            return AkkermanFunc(m - 1, 1);

        else if (m > 0 && n > 0)
            return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));

    }
    return AkkermanFunc(m, n);
}
Console.WriteLine($"A({m}, {n}) = {AkkermanFunc(m, n)}");