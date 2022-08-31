Console.WriteLine("Введи целое положительное число n от 2 до бесконечности и я покажу все четные числа от 1 до n");
string numbN = Console.ReadLine(); //ввод юзером n
int num = int.Parse(numbN);

if (num < 2)
{
    Console.WriteLine("Число не подходит, перезапусти программу и введи чего требуют)");
}
else
{
    for (int i = 2; i <= num; i = i + 2)
    {
        Console.WriteLine(i);
    }
}