 /*int Max(int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if( arg2>result) result=arg2;
    if( arg3>result) result=arg3;
    return result;
 }

int a1=3;
int a2=55;
int a3=4;
int a4=6;
int a5=2;
int a6=7;
int a7=75;
int a8=4;
int a9=1;

int max1=Max(a1,a2,a3);
int max2=Max(a4,a5,a6);
int max3=Max(a7,a8,a9);

int max=Max(max1,max2,max3);
Console.WriteLine(max);
*/

/*
int[] array = {11,21,31,41,15,61,17,18};
array[0]=12;
Console.WriteLine(array[4]);
*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);