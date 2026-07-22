double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());


double cosC = 0;

if(x*x + y*y == z *z || x * x + z * z == y * y || y * y + z * z == x * x)
{
    Console.WriteLine("Треугольник прямоугольный");
}
else
{
    cosC = (x*x + y*y - z*z) / (2*x*y);

    Console.WriteLine($"Значение угла С - {Math.Acos(cosC)}");
}


