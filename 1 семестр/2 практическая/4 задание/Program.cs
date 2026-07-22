string userChoice = Console.ReadLine();
double userSum = Convert.ToDouble(Console.ReadLine());



if(userChoice == "1")
{
    Console.WriteLine($"Прибыль - {userSum * 0.07} рублей");
}
else if (userChoice == "2")
{
    double newSum = 0;
    for (int i = 0; i < 3; i++)
    {
        newSum = userSum + userSum * 0.08;
    }
    Console.WriteLine($"Прибыль - {newSum - userSum} рублей");
}
else if(userChoice == "3")
{
    double newSum = 0;
    for (int i = 0; i < 5; i++)
    {
        newSum = userSum + userSum * 0.1;
    }
    Console.WriteLine($"Прибыль - {newSum - userSum} рублей");
}
else
{
    Console.WriteLine("Такого варианта нету");
}