

string LargestWord(string predl)
{
    string[] parts = predl.Split(" ");
    int maxLenght = 0;
    string maxWord = "";

    foreach(var i in parts)
    {
        if(i.Length > maxLenght) maxLenght = i.Length;
    }

    foreach(var i in parts)
    {
        if (i.Length == maxLenght)
        {
            maxWord = i;
        }
    }

    return maxWord;
    
}


string predl = Console.ReadLine();

Console.WriteLine(LargestWord(predl));
