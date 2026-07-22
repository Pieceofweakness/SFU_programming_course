int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int sumPows = 0;


for(int i = 1; i < n; i++)
{
    sum += i;
    sumPows += i*i;

    if (sumPows > 500) break;
}
Console.WriteLine(sum);
Console.WriteLine(sumPows);