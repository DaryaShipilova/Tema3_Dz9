// Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются 
// пользователем

Console.WriteLine("Введите первое число от 0 до 30: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число от 0 до 30: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество первых N чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;

void SumDigit(int k, int m, int sum)
{
    if (count > n)
        return;
        
    sum = (k + m);
    result = sum + m;
    count++;
    Console.Write($"{k} {m} {sum} {result} ");
}
SumDigit(k, m, 0);

