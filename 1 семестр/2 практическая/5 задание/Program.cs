double speed = Convert.ToDouble(Console.ReadLine());

double speedLimit = 90;
double accept = speed - speedLimit;

if (speed <= speedLimit)
{
    Console.WriteLine("Скорость допустима");
}
else if (accept >=20 && accept <= 39)
{
    Console.WriteLine("Штраф 500 рублей");
}
else if (accept >= 40 && accept <= 59)
{
    Console.WriteLine("Штраф 1500 рублей");
}
else if (accept >= 60 && accept <= 79)
{
    Console.WriteLine("Штраф 2500 рублей");
}
else if (accept >= 80)
{
    Console.WriteLine("Штраф 5000 рублей");
}