Console.WriteLine("Введи число a");
string numbA = Console.ReadLine(); //ввод юзером a
Console.WriteLine("Введи число b");
string numbB = Console.ReadLine(); //ввод юзером b
Console.WriteLine("Введи число с");
string numbC = Console.ReadLine(); //ввод юзером c

var num1 = double.Parse(numbA);
var num2 = double.Parse(numbB);
var num3 = double.Parse(numbC);

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"число {num1} самое большое");
    }
    else
    {
        Console.WriteLine($"число {num3} самое большое");
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"число {num2} самое большое");
    }
    else
    {
        Console.WriteLine($"число {num3} самое большое");
    }
}