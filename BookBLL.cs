class BookBLL : IBookBLL
{
    private IDBItemDAL dbItemDAL;

    public BookBLL(IDBItemDAL dbItemDAL)
    {
        this.dbItemDAL = dbItemDAL;
    }

    public decimal GetTotalCostOfBooks(int targetPageCount)
    {
        decimal totalCost = 0;
        List<Book> books = dbItemDAL.GetBooks();

        foreach (Book book in books)
        {
            if (book.NumberOfPages > targetPageCount)
            {
                totalCost += book.Price;
            }
        }

        return totalCost;
    }
}