using Bookshelf.Db;

namespace Bookshelf;

public class Bookshelf
{
    private readonly DbFactory.Db _db;
    private int _timesAddedABook;

    public Bookshelf(DbFactory.Db db)
    {
        _db = db;
    }

    public List<Book> GetAll()
    {
        Book Converter(Dictionary<string, object> dict) => new((string)dict["name"], (bool)dict["anniversary"]);
        return _db.FindAll().ConvertAll((Converter<Dictionary<string,object>,Book>)Converter);
    }

    public void Add(Book book)
    {
        if (_timesAddedABook == 4)
        {
            book.Anniversary = true;
        }

        var dictionary = new Dictionary<string, object>
        {
            { "name", book.Name },
            { "anniversary", book.Anniversary }
        };
        _db.Persist(dictionary);
        _timesAddedABook++;
    }
}