/*  ДОМАШНИЕ ЗАДАНИЯ:
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
    Напишите программу, которая покажет количество чётных чисел в массиве. */
int WriteRead(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void vivod(int[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine();
}
int[] CreateFillArr(int d)
{
    int[] arr = new int[d];
    for (int i = 0; i < d; i++) arr[i]= new Random().Next(100,199);
    return arr;
}
int NumEven(int[] arr)
{
    int k=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) k++;
    }
    return k;
}

int A = WriteRead("Введите размер массива: ");
int[] aaa = CreateFillArr(A);
vivod(aaa);
Console.WriteLine($"Количество четных чисел: {NumEven(aaa)}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int SumOdd(int[] arr)
{
    int sum=0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int B = WriteRead("Введите размер массива: ");
int[] bbb = CreateFillArr(B);
vivod(bbb);
Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOdd(bbb)}");

//Задача 38: Задайте массив ВЕЩЕСТВЕННЫХ чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateFillArrDouble(int d)
{
    double[] arr = new double[d];
    for (int i = 0; i < d; i++) arr[i]= Math.Round(new Random().NextDouble()*100, 3);
    return arr;
}
void vivodDouble(double[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine();
}
double max(double[] arr)
{
    double res = arr[0];
    for (int i = 1; i < arr.Length; i++) if (arr[i]>res) res = arr[i];
    return res;
}
double min(double[] arr)
{
    double res = arr[0];
    for (int i = 1; i < arr.Length; i++) if (arr[i]<res) res = arr[i];
    return res;
}

int C = WriteRead("Введите размер массива: ");
double[] ccc = CreateFillArrDouble(C);
vivodDouble(ccc);
Console.WriteLine($"Разница между max и min: {Math.Round(max(ccc)-min(ccc), 3)}");

/* Дополнительно. Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует,
   замените его на 200. Обновите список только при первом вхождении числа 20. */

int[] CreateFillArrTwenty(int d)
{
    int[] arr = new int[d];
    for (int i = 0; i < d; i++) arr[i]= new Random().Next(17,23);
    return arr;
}

int D = WriteRead("Введите длину списка: ");
int[] ddd = CreateFillArrTwenty(D);
vivod(ddd);
int[] DeleteTwenty(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 20)
        {
            arr[i]=200;
            break;
        } 
    }
    return arr;
}
vivod(DeleteTwenty(ddd));