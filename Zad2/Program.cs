// Показать натуральные числа от M до N, с помощью рекурсии. N и M заданы

Console.WriteLine ("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine ()); 
Console.WriteLine ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine ()); 

void Numbers(int m, int n)
{
    if (m > n)
        return;
    Console.Write($"{m} ");
    Numbers(m + 1, n);
}

Numbers (m, n);