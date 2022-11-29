/* ДОМАШНИЕ ЗАДАНИЯ: 
   Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int WriteRead(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NumPositive(float[] arr)
{
   int res = 0;
   for (int i = 0; i < arr.Length ; i++)
   {
      if (arr[i]>0) res++;   
   }
   Console.WriteLine($"Положительных чисел: {res}");
}

float[] FillArr(int a)
{
   float [] aaa = new float[a];
   for (int i = 1; i <= a; i++)
   {
      aaa[i-1]=WriteRead($"Введите {i}-ое число: ");
   }
   return aaa;
}

int A = WriteRead("Введите количество чисел: ");
NumPositive(FillArr(A));

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
   уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

float[,] FillParametrs()
{
   float[,] arr = new float[2,2];
   arr[0,0] = WriteRead("Введите коэфицент k_1: ");
   arr[0,1] = WriteRead("Введите коэфицент b_1: ");
   arr[1,0] = WriteRead("Введите коэфицент k_2: ");
   arr[1,1] = WriteRead("Введите коэфицент b_2: ");
   return arr;
}

void PointIntersection(float[,] arr)
{
   float x = (arr[1,1]-arr[0,1])/(arr[0,0]-arr[1,0]);
   float y = (arr[0,0]*arr[1,1]-arr[0,1]*arr[1,0])/(arr[0,0]-arr[1,0]);
   Console.WriteLine($"Координата точки пересечения: ({x};{y})");
}

float[,] parametrs = FillParametrs();
Console.WriteLine($"y = {parametrs[0,0]}x + {parametrs[0,1]}");
Console.WriteLine($"y = {parametrs[1,0]}x + {parametrs[1,1]}");
PointIntersection(parametrs);
