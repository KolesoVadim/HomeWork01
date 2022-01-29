// Подсчитать сумму цифр в числе.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
int sum = 0;
int count = 0;
while (number >= 1)
{
    int i = number % 10;
    number = number / 10;
    sum = sum + i;
    count++;
}
Console.WriteLine("Сумма цифр в числе = " + sum);