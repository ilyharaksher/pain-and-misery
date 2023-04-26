int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int s = 0;
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        s = arr[i];
        break;
    }
}
if (!Convert.ToBoolean(s))
{
    Console.WriteLine("Четных чисел нету");
}
else{
    Console.WriteLine(s);
}