Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

double k = y / x;

double a = Math.Atan(k);
Console.WriteLine($"Угол наклона прямой на плоскости равен {a}");
