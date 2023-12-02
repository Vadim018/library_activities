class DBItemDAL : IDBItemDAL
{
    private List<Book> books = new List<Book>(); // Приклад списку книг (може бути замінений на базу даних)

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}