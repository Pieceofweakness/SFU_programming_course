using System.Numerics;

int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];


for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

int max = 0;
int index = 0;

for (int i = 0;i < n; i++)
{
    if (a[i] > max)
    {
        max = a[i];
        index = i;
    }
}

a[index] = a[n - 1];
a[n - 1] = max;


foreach(var i in a)
{
    Console.WriteLine(i);
}
