// Показать натуральные числа от N до 1 с помощью рекурсии. N задано

Console.WriteLine ("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine ()); 

void Numbers(int n)
{
    if (n < 1 )
        return;
    Console.Write($"{n} ");
    Numbers(n - 1);
}
Numbers (n);



