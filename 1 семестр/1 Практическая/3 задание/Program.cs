int RoadLenght = 163;


Console.Write("Введите скорость: ");
int v = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите время: ");
int t = Convert.ToInt32(Console.ReadLine());


int s = v * t;
int x = s / RoadLenght;

if (s <= RoadLenght)
{
    Console.WriteLine($"Остановиться на отметке {s}");
}
else
{
    Console.WriteLine($"Остановиться на отметке {s - RoadLenght *x}");
}

Console.WriteLine($"Количество кругов {x}");




