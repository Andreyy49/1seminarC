Console.WriteLine("Введи число a");
string numbA = Console.ReadLine(); //ввод юзером a
Console.WriteLine("Введи число b");
string numbB = Console.ReadLine(); //ввод юзером b

var num1 = double.Parse(numbA);
var num2 = double.Parse(numbB);

if (num1 > num2)
{
    Console.WriteLine($"число a = {num1} больше");
}
else if (num1 < num2)
{
    Console.WriteLine($"число b = {num2} больше");
}
else
{
    Console.WriteLine("Числа a и b равны");
}