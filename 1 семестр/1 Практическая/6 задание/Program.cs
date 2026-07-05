Console.Write("Введите 1 сторону треугольника: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите 2 сторону треугольника: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите 3 сторону треугольника: ");
double c = Convert.ToDouble(Console.ReadLine());



if (a + b > c && a + c > b && b + c > a)
{
    double p = (a + b + c) / 2;
    double gerron = Math.Sqrt( p*(p-a)*(p-b)*(p-c));
    Console.WriteLine($"Площадь треугольника по формуле герона - {gerron}");
}
else
{
    Console.WriteLine("Такого треугольника не существует");
}