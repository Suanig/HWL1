Console.Write("Введите число А ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите число B ");
double numberB = double.Parse(Console.ReadLine());
double max = numberA;
if (numberA >= numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
Console.Write("Max= ");
Console.Write(max);
