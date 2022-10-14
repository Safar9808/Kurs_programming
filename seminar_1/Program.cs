/*Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("Большее из чисел: "+number1);
}
else
{
    Console.WriteLine("Большее из чисел: "+number2);
}
*/
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("Большее из чисел: "+number1);
    Console.WriteLine("Меньшее из чисел: "+number1);
}
else
{
    Console.WriteLine("Большее из чисел: "+number2);
    Console.WriteLine("Меньшее из чисел: "+number1);
}
