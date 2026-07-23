var people = new Dictionary<string, double>()
{
    ["Маша"] = 10000,
    ["Петя"] = 30000,
    ["Вася"] = 100000,
};


Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.WriteLine("Введите сумму");
double sum = Convert.ToDouble( Console.ReadLine());

var flag = people.ContainsKey(name);
if (flag)
{
    people[name] += sum;
    Console.WriteLine($"{name}, Ваш баланс счета изменен! Текущий баланс {people[name]} рублей.");
    var balance = Balance(people[name]);
    Console.WriteLine($"Вы можете воспользоваться стандартным вкладом нашего банка! Вложив сумму остатка {people[name]} на 3 года под 17% годовых Вы получите прибыль {balance}. Для активации вклада войдите в мобильное приложение!");


}
else
{
    people.Add(name, sum);
    Console.WriteLine($"Благодарим, что вы стали клиентом нашего банка!{name}, Ваш баланс счета изменен! Текущий баланс {sum} рублей.");
}


double Balance(double balance)
{
    for (int i = 0; i < 3; i++)
    {
        balance += balance * 0.17;
    }
    return balance;
}
