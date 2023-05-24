//Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число больше, а какое меньеш.


Console.WriteLine("Введите первое число ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2=Convert.ToInt32(Console.ReadLine());

if(num>num2)
{
    Console.WriteLine("первое число больше второго");
    Console.Write(" max = ");
    Console.Write(num);
    Console.Write(" min = ");
    Console.Write(num2);
}
else
{
    Console.WriteLine("второе число больше первого");
    Console.Write(" max = ");
    Console.Write(num2);
    Console.Write(" min = ");
    Console.Write(num);
}

