/* меняет местами 1 и последнее имя, второе и предпоследнее итп
int n = int.Parse(Console.ReadLine());
string[] names = new string [n];

void vivod(string[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
}
string[] perestanovka(string[] arr)
{
    for ( int i=0;i<arr.Length/2;i++)
    {
        string t = arr[i];
        arr[i]=arr[arr.Length-i-1];
        arr[arr.Length-i-1] = t;
    }
    return arr;
}

for ( int i=0;i<n;i++)
{
    names[i] = Console.ReadLine();
}
vivod(names);
perestanovka(names);
Console.WriteLine();
vivod(names);

//Console.WriteLine(string.Join(" ",arr));     выводит массив через пробел
*/



/* ДОМАШНЕЕ ЗАДАНИЕ: 

   Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
   число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность. */

int WriteRead(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

float degree( int a, int b)                   // решил не делать проверку на отрицательность, а поработать и с ней
{
    float res=1;
    if (b > 0) for ( int i = 0; i < b; i++) res=res*a;
    if (b < 0) for ( int i = 0; i > b; i--) res=res/a;
    return res;
}

int A = WriteRead("Введите основание: ");
int B = WriteRead("Введите показатель степени: ");
Console.WriteLine($"ответ: {degree(A,B)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigits(int c, int n)
{
   int sum = 0;
   while (c>0)
   {
        sum = sum + c % 10;
        c = c / 10;
   }
   return sum;
}
int NumDigits(int c)
{
    int n = 0;
    while (c>0)
    {
        c=c/10;
        n++;
    }
    return n;
}

int C = WriteRead("Введите число, а я посчитаю сумму его цифр: ");
Console.WriteLine($"ответ: {SumDigits(C, NumDigits(C))}");

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
   Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа.
   Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив. */

int[] CreateFillArr(int d)
{
    int[] arr = new int[d];
    for (int i = 0; i < d; i++) arr[i]= new Random().Next(1,199);
    return arr;
}
void vivod(int[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine();
}
int[] SumDigitsArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=SumDigits(arr[i], NumDigits(arr[i]));
    }
    return arr;
}

int D = WriteRead("Введите размер массива: ");
int[] aaa = new int[D];
aaa = CreateFillArr(D);
vivod(aaa);
vivod(SumDigitsArr(aaa));
