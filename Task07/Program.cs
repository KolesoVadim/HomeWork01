// Написать программу вычисления произведения чисел от 1 до N.
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
int prod = 1;
for (int i = 2; i <= N; i++)
{
    prod = prod * i;
}
Console.WriteLine($"Произведение чисел равно " + prod);