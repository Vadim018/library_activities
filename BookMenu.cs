class BookMenu : IMenu
{
    private IBookPL bookPL;

    public BookMenu()
    {
        IDBItemDAL dbItemDAL = new DBItemDAL();
        IBookBLL bookBLL = new BookBLL(dbItemDAL);
        bookPL = new BookPL(bookBLL);
    }

    public void Run()
    {
        Console.WriteLine("Робота з книгами:");
        bookPL.Run();
    }
}