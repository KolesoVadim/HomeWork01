// Возведите число А в натуральную степень B используя цикл.
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите степень В: ");
int B = int.Parse(Console.ReadLine()??"0");
int Result = 1;
for (int i = 1; i <= B; i++)
{
    Result = Result * A;
}
Console.WriteLine ($"{A} в степени {B} = {Result}");