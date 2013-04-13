using System;
class MethodForSortingStrings
{
    static void Main()
    {
        string temp;
        Console.WriteLine("Enter string array lenght");
        int n = int.Parse(Console.ReadLine());
        string[] a=new string[n];
        Console.WriteLine("Enter array");
        for (int i = 0; i < n; i++)
        {
            a[i] = Console.ReadLine();
        }
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i; j < a.Length; j++)
                if (a[i].Length > a[j].Length)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}