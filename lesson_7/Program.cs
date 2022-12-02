/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
   Выполнить с помощью рекурсии.*/

int WriteRead(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void VivodNatur(int n)
{
    if (n==0) return;
    Console.Write($"{n} ");
    VivodNatur(n-1);
}

int N=0;
while (N<1) N = WriteRead("Введите положительное значение N: ");
VivodNatur(N);
Console.WriteLine();


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
   C помощью рекурсии!!!*/

int S=0;
int max = WriteRead("Введите большее число N:");
int min = WriteRead("Введите меньшее число M:");

int SumMN(int m, int n)
{
    if (n<m) return S;
    else 
    {
        S=S+n;
        return SumMN(min,max-1);
    }
}
SumMN(max,min);
Console.WriteLine();


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
   С помощью рекурсии!!!*/

int a = WriteRead("Введите первое неотрицательное чмсло :");
int b = WriteRead("Введите второе неотрицательное чмсло: ");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Akkerman(a - 1, 1);
    else return (Akkerman(a - 1, Akkerman(a, b - 1)));
}
Console.WriteLine(Akkerman(a,b));