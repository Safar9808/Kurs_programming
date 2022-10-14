// 1 type

void Method1()
{
    Console.WriteLine("Autor");
}

Method1();

// 2 type

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2(msg: "sometext", count: 4); // или Method2('some text', 4)

