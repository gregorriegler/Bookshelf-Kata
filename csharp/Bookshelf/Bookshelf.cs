using Bookshelf.Db;

namespace Bookshelf
{
    public class Bookshelf
    {
        private readonly DbFactory.Db<Book> _db;

        public Bookshelf(DbFactory.Db<Book> db)
        {
            _db = db;
        }

        public List<Book> GetAll()
        {
            return _db.FindAll();
        }

        public void Add(Book book)
        {
            _db.Persist(book);
        }
    }

    public class Book
    {
        public string Refactoring { get; }

        public Book(string refactoring)
        {
            Refactoring = refactoring;
        }
    }
}