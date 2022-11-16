int cem = 0;
int long_1 = int.Parse(Console.ReadLine());
int[] arr = new int[long_1];
for (int i = 0; i < long_1; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
foreach (var item in arr)
{
    if (item % 2 == 0)
    {
        cem += item;
    }
}
Console.WriteLine(cem);