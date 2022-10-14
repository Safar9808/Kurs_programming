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

// 3 type

int Method3()
{
    return DateTime.Now.Year;
}
 int year = Method3();
 Console.WriteLine(year);

 // 4 type

 string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res= Method4(10, "asdf");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
}

// Задача с заменой пробела на тире, маленьких к и с на большие

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int len = text.Length;
    for (int i = 0; i < len; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '-');
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);

