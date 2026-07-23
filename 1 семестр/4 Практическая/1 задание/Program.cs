
void Chisla(int[] collection)
{
    int lenght = collection.Length;
    int maxim1 = collection.Max();
    int minim1 = collection.Min();
    int maxim2 = 0;
    int minim2 = 99999;

    foreach(var i in collection)
    {
        if(i > maxim2) maxim2 = i;
    }
    foreach(var i in collection)
    {
        if(i<minim2) minim2 = i;
    }


    Console.WriteLine(Proizv(maxim1,minim1));
    Console.WriteLine(Proizv(maxim2, minim2));

}




double Proizv(double a, double b)
{
    return a * b;
}


Chisla([1,2,3,4]);