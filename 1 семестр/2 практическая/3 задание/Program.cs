using System.Runtime.InteropServices;

const int maxPacients = 48;

int n = Convert.ToInt32( Console.ReadLine());

if (n > maxPacients)
{
    Console.WriteLine("В очереди стоять нет смысла");
}
else
{
    Console.WriteLine($"Стоять в очереди - {((n-1)/2) * 20} минут");
}

