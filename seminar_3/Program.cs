/* Напишите программу, которая принимает на вход координаты точки (X и Y),
   причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка */

string chetvert(int x, int y)
{
    string name = x>0 && y>0 ? "1 четверть" : x<0 && y>0 ? "2 четверть" : x<0 && y<0 ? "3 четверть" : "4 четверть"; // тернартный оператор
    return name;
}
Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine(chetvert(x,y));

// Домашние задания

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number % 10 == number / 10000 && number / 1000 % 10 == number / 10 % 10) Console.WriteLine("Да, это палиндром");
else Console.WriteLine("Нет, это не палиндром"); 

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Расстояние между точками равно {Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1))}");

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
void tabOfCube(int n)
{
    int i = 1;
    while (i < n+1)
    {
        Console.Write($"{i*i*i}, ");
        i++;
    }
}
tabOfCube(N);

// Создать программу, которая из массива удаляется элемент с позиции, которую введет пользователь.


