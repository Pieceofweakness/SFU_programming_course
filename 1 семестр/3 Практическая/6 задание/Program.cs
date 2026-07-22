double x0 = 0;
double y0 = 0;

double R = Convert.ToDouble(Console.ReadLine());
int count = 0;

for(int i = 0; i < 12; i++)
{
    double x = Convert.ToDouble(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());

    double d = Math.Sqrt((x - x0) * (x - x0) + (y-y0)* (y - y0));
    if (d < 2 * R)
    {
        count++;
    }
}


Console.WriteLine(count);


