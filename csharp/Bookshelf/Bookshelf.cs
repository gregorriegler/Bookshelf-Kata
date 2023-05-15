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

    public IEnumerable<Book> GetAll()
    {
        return _db.FindAll().ConvertAll(ToBook);
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

    public string Summary()
    {
        string summary = "There are " + Count() + " books on the shelf.\n";
        _db.FindAll().ForEach(book => summary += book["name"] + "\n");
        return summary;
    }

    public int Count()
    {
        return _db.FindAll().Count;
    }

    private static Book ToBook(Dictionary<string, object> dict) => new((string)dict["name"], (bool)dict["anniversary"]);
}