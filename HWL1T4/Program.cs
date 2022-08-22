Console.Write("Введите число N ");
double numberN = double.Parse(Console.ReadLine());
double count = 0;
if (numberN > 1) 
    {
    for (count = 2; count < numberN; count = count + 2)
    {
      Console.WriteLine(count);   
    }
    }
    else 
    {
        if (numberN < -1)
        {
           for (count = -2; count > numberN; count = count - 2)
    {
      Console.WriteLine(count);   
    }
        }
        else Console.Write("None");
    }