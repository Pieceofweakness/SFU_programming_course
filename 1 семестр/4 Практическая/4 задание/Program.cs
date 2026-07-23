
bool az(string password)
{
    string letters = "qwertyuiopasdfghjklzxcvbnm";
    bool flag = false;

    foreach(var letter in password)
    {
        foreach(var let in letters)
        {
            if (letter == let)
            {
                flag = true;
                
            }
        }
    }
    return flag;
}

bool AZ(string password)
{
    string letters = "QWERTYUIOPASDFGHJKLZXCVBNM";
    bool flag = false;

    foreach (var letter in password)
    {
        foreach (var let in letters)
        {
            if (letter == let)
            {
                flag = true;

            }
        }
    }
    return flag;
}

bool Chisla(string password)
{
    string letters = "1234567890";
    bool flag = false;

    foreach (var letter in password)
    {
        foreach (var let in letters)
        {
            if (letter == let)
            {
                flag = true;

            }
        }
    }
    return flag;
}

bool Spec(string password)
{
    string letters = "!@#$%^&*()/*.,{}[];'<>?~`";
    bool flag = false;

    foreach (var letter in password)
    {
        foreach (var let in letters)
        {
            if (letter == let)
            {
                flag = true;

            }
        }
    }
    return flag;
}

bool LenghtPass(string password)
{
    bool flag = false;
    if (password.Length >= 6 && password.Length <=12)
    {
        flag = true;
    }
    return flag;
}


Console.WriteLine("Введите пароль");
string Password = Console.ReadLine();

Console.WriteLine(az(Password) && AZ(Password) && Chisla(Password) && Spec(Password) && LenghtPass(Password));



