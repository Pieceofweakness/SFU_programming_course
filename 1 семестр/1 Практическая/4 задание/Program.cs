Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int randomNumber = rnd.Next(first,second+1);

Console.WriteLine($"Случайное число в диапазоне {first} и {second} - {randomNumber}");
