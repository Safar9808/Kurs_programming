//буду вспоминать что происходит 

int factorialchik (int n)
{
    if (n==1) return 1;
    else return n*factorialchik(n-1);
}

int WriteRead(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int N = WriteRead("введи число n: ");
Console.WriteLine(factorialchik(N));

// добавил комент для пуша