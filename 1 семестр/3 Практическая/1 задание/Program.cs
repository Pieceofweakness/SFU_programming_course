Random rnd = new Random();

int aiChoice = rnd.Next(0, 11);
int countTry = 0;

while (true)
{
    int userChoice = Convert.ToInt32(Console.ReadLine());
    countTry++;

    if (userChoice == aiChoice)
    {
        Console.WriteLine($"Вы угадали загаданое число {aiChoice} за {countTry} попыток");
        break;
    }
    else if (userChoice < aiChoice)
    {
        Console.WriteLine("Число больше");
    }
    else if (userChoice > aiChoice)
    {
        Console.WriteLine("Число меньше");
    }
}

