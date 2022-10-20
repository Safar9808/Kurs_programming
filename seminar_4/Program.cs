// меняет местами 1 и последнее имя, второе и предпоследнее итп
int n = int.Parse(Console.ReadLine());
string[] names = new string [n];
void vivod(string[] arr)
{
    foreach(var i in arr)
    {
        Console.Write(i+" ");
    }
}
for ( int i=0;i<n;i++)
{
    names[i] = Console.ReadLine();
}
vivod(names);
