/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("Большее из чисел: "+number1);
    Console.WriteLine("Меньшее из чисел: "+number2);
}
else
{
    Console.WriteLine("Большее из чисел: "+number2);
    Console.WriteLine("Меньшее из чисел: "+number1);
}

*/

/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("Максимальное из чисел: "+a);
    }
    else
    {
        Console.WriteLine("Максимальное из чисел: "+c);
    }
}
else
{
   if (b>c)
    {
        Console.WriteLine("Максимальное из чисел: "+b);
    }
    else
    {
        Console.WriteLine("Максимальное из чисел: "+c);
    } 
}
*/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}
*/

/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 2;
while (i<=N)
{
    Console.WriteLine(i);
    i = i+2;
}
*/

