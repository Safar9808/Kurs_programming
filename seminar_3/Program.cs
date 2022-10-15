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

