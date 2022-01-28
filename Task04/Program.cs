// Определить количество цифр в числе.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
int sum = 0;
while (number > 0)
{
    number = number / 10;
    sum++;
}
Console.WriteLine(sum);