Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите c: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите d: ");
double d = Convert.ToDouble(Console.ReadLine());


double z = (a / c) * (b / d) - ((a * b - c) / (c * d)) + Math.Sqrt(d);

Console.WriteLine($"Число z равно {z}");
