//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int num = new Random().Next(100, 999);
int s2 = (num / 10) % 10;
Console.WriteLine($"вторая цифра числа {num}: {s2}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int num2 = new Random().Next(1,9999999);

int digitCount(int number)    //int digitCount = (int)Math.Log10(number) + 1;
{
    int k = 0;
    while (number>0)
    {
        number = number / 10;
        k++;
    }
    return k;
}

int powOfTen(int n)         // на это число нужно поделить чтобы уменьшиться до 3-его порядка
{
    int i = 3;
    int t = 1;
    while (i < n)
    {
        t = t * 10;
        i++;
    }
    return t;
}

int res= num2 / powOfTen(digitCount(num2)) % 10;
Console.WriteLine($"третья цифра числа {num2}: {res}");



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int num3 = new Random().Next(1,7);

string checkOfHoliday(int number)
{
    if (number<6) return " не ";
    else return " ";
}
string otvet = checkOfHoliday(num3);
Console.WriteLine($"{num3}-й день недели в календаре{otvet}выходной");