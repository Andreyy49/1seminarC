Console.WriteLine("Введи число, я скажу четное ли оно");
string input = Console.ReadLine(); //ввод юзером

int number = int.Parse(input);
if (number == 0)
{
    Console.WriteLine("ты ввел ноль, попытайся еще раз");
}
else
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"число {number} является четным");
    }
    else
    {
        Console.WriteLine($"число {number} не является четным");
    }
}