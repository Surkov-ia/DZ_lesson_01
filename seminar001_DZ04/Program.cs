//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int num1=1;
while (num1 <= num)
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine("Чётные числа");
        Console.Write(num1 + ", ");
    }
    num1++;
}
