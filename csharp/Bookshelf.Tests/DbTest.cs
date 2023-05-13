using FluentAssertions;
using Xunit;
using Bookshelf.Db;
using Bookshelf.Db2;

namespace Bookshelf.Tests
{

    public class BookshelfTest
    {
        [Fact]
        public void StartsEmpty()
        {
            var dbFactory = DbFactory.GetInstance();
            var db = dbFactory.startDb<Book>();
            var bookshelf = new Bookshelf(db);
            
            var books = bookshelf.GetAll();
            
            books.Should().BeEmpty();
        }
        
        [Fact]
        public void RetrievesSingleStoredBook()
        {
            var dbFactory = DbFactory.GetInstance();
            var db = dbFactory.startDb<Book>();
            var book = new Book("Refactoring");
            db.Persist(book);
            var bookshelf = new Bookshelf(db);
            
            var books = bookshelf.GetAll();
            
            books.Should().ContainSingle().Which.Should().BeSameAs(book);
        }
        
        [Fact]
        public void AddsBook()
        {
            var dbFactory = DbFactory.GetInstance();
            var db = dbFactory.startDb<Book>();
            var bookshelf = new Bookshelf(db);
            var book = new Book("Refactoring");
            
            bookshelf.Add(book);

            bookshelf.GetAll().Should().ContainSingle().Which.Should().BeSameAs(book);
        }
    }
}