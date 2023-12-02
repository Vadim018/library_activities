class MainMenu : IMenu
{
    private IMenu bookMenu;
    private IMenu strategyMenu;

    public MainMenu()
    {
        bookMenu = new BookMenu();
        strategyMenu = new StrategyMenu();
    }

    public void Run()
    {
        Console.WriteLine("1. Робота з книгами");
        Console.WriteLine("2. Вибір стратегії");
        Console.WriteLine("0. Вихід");
        Console.Write("Введіть варіант: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                bookMenu.Run();
                break;
            case 2:
                strategyMenu.Run();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Невірний варіант. Спробуйте ще раз.");
                Run();
                break;
        }
    }
}