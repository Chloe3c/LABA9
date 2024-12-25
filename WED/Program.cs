using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номинал монеты (1, 2, 5 или 10): ");
        int nominal = int.Parse(Console.ReadLine());

        if (nominal != 1 && nominal != 2 && nominal != 5 && nominal != 10)
        {
            Console.WriteLine("Номинал монеты должен быть 1, 2, 5 или 10.");
            return;
        }

        Console.Write("Введите количество монет: ");
        int quantity = int.Parse(Console.ReadLine());

        Coin coin = new Coin(nominal, quantity);

        Console.WriteLine(coin.GetInformation());
    }
}