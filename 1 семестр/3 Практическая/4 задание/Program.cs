double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double C = Convert.ToDouble(Console.ReadLine());
double D = Convert.ToDouble(Console.ReadLine());

double sum = 0;
double count = 0;



for (int x = 1; x <= 10; x++)
{
    double y = A * Math.Sqrt(B*x+D) -C * x;

    if (y > 0)
    {
        sum += y;
        count++;
    }

}

Console.WriteLine(sum);
Console.WriteLine(count);
Console.WriteLine(sum/count);

