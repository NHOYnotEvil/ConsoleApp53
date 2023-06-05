namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int silversToGolds = 100, silversToCrystals = 10000, goldsToSilvers = 100,
                goldsToCrystals = 100, crystalsToSilvers = 10000, crystalsToGolds = 100;
            float silvers;
            float golds;
            float crystals;
            string userInput;
            string commandExit = "exit";
            float currencyCount;
            bool userIsExit = false;

            Console.WriteLine("Добро пожаловать в банк нашей игры. Тут вы можете обменять свои валюты.");

            Console.Write("Введите баланс серебра:");
            silvers = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс золота:");
            golds = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс кристаллов:");
            crystals = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обменять серебро на золото.");
            Console.WriteLine("2 - обменять серебро на кристаллы.");
            Console.WriteLine("3 - обменять золото на серебро.");
            Console.WriteLine("4 - обменять золото на кристаллы.");
            Console.WriteLine("5 - обменять кристаллы на серебро.");
            Console.WriteLine("6 - обменять кристаллы на золото.");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен серебра на золото.");
                    Console.Write("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (silvers >= currencyCount)
                    {
                        silvers -= currencyCount;
                        golds += currencyCount / silversToGolds;
                    }
                    else
                    {
                        Console.WriteLine("Не хватает серебра.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен серебра на кристаллы.");
                    Console.Write("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (silvers >= currencyCount)
                    {
                        silvers -= currencyCount;
                        crystals += currencyCount / silversToCrystals;
                    }
                    break;
                case "3":
                    Console.WriteLine("Обмен золота на серебро.");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (golds >= currencyCount)
                    {
                        golds -= currencyCount;
                        silvers += currencyCount * goldsToSilvers;
                    }
                    break;
                case "4":
                    Console.WriteLine("Обмен золота на кристаллы.");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (golds >= currencyCount)
                    {
                        golds -= currencyCount;
                        crystals += currencyCount / goldsToCrystals;
                    }
                    break;
                case "5":
                    Console.WriteLine("Обмен кристаллов на серебро.");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (crystals >= currencyCount)
                    {
                        crystals -= currencyCount;
                        silvers += currencyCount * crystalsToSilvers;
                    }
                    break;
                case "6":
                    Console.WriteLine("Обмен кристаллов на золото.");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (crystals >= currencyCount)
                    {
                        crystals -= currencyCount;
                        golds += currencyCount * crystalsToGolds;
                    }
                    break;
            }

            Console.WriteLine("Ваш балланс: " + silvers + " серебра, " + golds + " золота, " + crystals + " кристаллов.");
            Console.WriteLine("Что-бы выйти из программы, введите комманду - " + commandExit);

            while (userIsExit == false)
            {
                userInput = Console.ReadLine();

                if (userInput == commandExit)
                {
                    userIsExit = true;
                }
            }
        }
    }
}