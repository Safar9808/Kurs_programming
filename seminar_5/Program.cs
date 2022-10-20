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

