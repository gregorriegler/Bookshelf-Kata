using Bookshelf.Db;

namespace Bookshelf;

public class Bookshelf
{
    private readonly DbFactory.Db<Dictionary<string,object>> _db;
    private int _timesAddedABook;

    public Bookshelf(DbFactory.Db<Dictionary<string,object>> db)
    {
        _db = db;
    }

    public List<Book> GetAll()
    {
        return _db.FindAll().ConvertAll(ToBook);
    }

    public void Add(Book book)
    {
        if (_timesAddedABook == 4)
        {
            book.Anniversary = true;
        }
        _db.Persist(ToDict(book));
        _timesAddedABook++;
    }

    private static Book ToBook(Dictionary<string, object> dict)
    {
        return new Book((string)dict["name"], (bool)dict["anniversary"]);
    }

    private static Dictionary<string, object> ToDict(Book book)
    {
        var dictionary = new Dictionary<string, object>
        {
            { "name", book.Name },
            { "anniversary", book.Anniversary }
        };
        return dictionary;
    }
}