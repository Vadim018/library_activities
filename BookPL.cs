class BookPL : IBookPL
{
    private IBookBLL bookBLL;

    public BookPL(IBookBLL bookBLL)
    {
        this.bookBLL = bookBLL;
    }

    public void Run()
    {
        Console.Write("Введіть кількість сторінок: ");
        int targetPageCount = int.Parse(Console.ReadLine());

        decimal totalCost = bookBLL.GetTotalCostOfBooks(targetPageCount);

        Console.WriteLine("Сумарна вартість книг з кількістю сторінок більше {0}: {1}", targetPageCount, totalCost);
    }
}