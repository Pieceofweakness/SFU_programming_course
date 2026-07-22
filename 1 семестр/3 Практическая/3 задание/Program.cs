int n = Convert.ToInt32(Console.ReadLine());


int countNotPass = 0;
int countToThree = 0;
int countToFour = 0;
int countToFive = 0;


for(int i = 1; i < n+1; i++)
{
    Random rnd = new Random();
    int podtyagivanya = rnd.Next(0,21);

    if (podtyagivanya < 12) countNotPass++;
    if(podtyagivanya < 14 && podtyagivanya >=12) countToThree++;
    if (podtyagivanya < 16 && podtyagivanya >= 14) countToFour++;
    if (podtyagivanya >= 16) countToFive++;

}

Console.WriteLine($"Не сдало - {countNotPass} учеников");
Console.WriteLine($"Сдало на 3 - {countToThree} учеников");
Console.WriteLine($"Сдало на 4 - {countToFour} учеников");
Console.WriteLine($"Сдало на 5 - {countToFive} учеников");

