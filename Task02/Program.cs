//Найти сумму чисел от 1 до А.
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()??"0");
int Sum = 0;
for (int i = 1; i <= A; i++)
{
    Sum = Sum + i;
}
Console.WriteLine($"Сумма чисел равна: {Sum}");