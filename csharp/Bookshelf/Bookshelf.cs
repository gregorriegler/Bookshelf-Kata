using Bookshelf.Db;

namespace Bookshelf
{
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
            return _db.FindAll().ConvertAll(toBook);
        }

        public void Add(Book book)
        {
            if (_timesAddedABook == 4)
            {
                book.Anniversary = true;
            }
            _db.Persist(toDict(book));
            _timesAddedABook++;
        }

        private static Book toBook(Dictionary<string, object> dict)
        {
            return new Book((string)dict["name"], (bool)dict["anniversary"]);
        }

        private static Dictionary<string, object> toDict(Book book)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "name", book.Name },
                { "anniversary", book.Anniversary }
            };
            return dictionary;
        }
    }

    public class Book
    {
        public string Name { get; }

        public bool Anniversary { get; set; }

        public Book(string name)
        {
            Name = name;
        }

        public Book(string name, bool anniversary) : this(name)
        {
            Anniversary = anniversary;
        }

        private bool Equals(Book other)
        {
            return Name == other.Name && Anniversary == other.Anniversary;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Book)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Anniversary);
        }
    }
}