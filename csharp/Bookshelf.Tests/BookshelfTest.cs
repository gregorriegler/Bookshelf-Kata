using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using Bookshelf.Db;

namespace Bookshelf.Tests;

public class BookshelfTest
{
    private readonly DbFactory.Db _db;

    public BookshelfTest()
    {
        var dbFactory = DbFactory.GetInstance();
        _db = dbFactory.StartDb();
    }

    [Fact]
    public void StartsEmpty()
    {
        var bookshelf = new Bookshelf(_db);

        var books = bookshelf.GetAll();

        books.Should().BeEmpty();
    }

    [Fact]
    public void RetrievesSingleStoredBook()
    {
        var book = new Book("Refactoring");
        _db.Persist(new Dictionary<string, object>
        {
            {"name", "Refactoring"},
            {"anniversary", false}
        });
        var bookshelf = new Bookshelf(_db);

        var books = bookshelf.GetAll();

        books.Should().ContainSingle().Which.Should().BeEquivalentTo(book);
    }

    [Fact]
    public void AddsBook()
    {
        var bookshelf = new Bookshelf(_db);
        var book = new Book("Refactoring");

        bookshelf.Add(book);

        bookshelf.GetAll().Should().ContainSingle().Which.Should().BeEquivalentTo(book);
    }

    [Fact]
    public void The5ThBookIsAnniversary()
    {
        var bookshelf = new Bookshelf(_db);
        bookshelf.Add(new Book("NotAAnniversary1"));
        bookshelf.Add(new Book( "NotAAnniversary2"));
        bookshelf.Add(new Book("NotAAnniversary3"));
        bookshelf.Add(new Book("NotAAnniversary4"));
            
        bookshelf.Add(new Book("Anniversary5"));

        bookshelf.GetAll().Should().Contain(
            new List<Book>
            {
                new("NotAAnniversary1"),
                new("NotAAnniversary2"),
                new("NotAAnniversary3"),
                new("NotAAnniversary4"),
                new("Anniversary5", true)
            }
        );
    }
    
    [Fact]
    public void CountsAddedBooks()
    {
        var bookshelf = new Bookshelf(_db);
        bookshelf.Add(new Book("Book1"));
        bookshelf.Add(new Book( "Book2"));
        bookshelf.Add(new Book("Book3"));

        bookshelf.Count().Should().Be(3);
    }
    
    [Fact]
    public void ProvidesASummary()
    {
        var bookshelf = new Bookshelf(_db);
        bookshelf.Add(new Book("Book1"));
        bookshelf.Add(new Book( "Book2"));
        bookshelf.Add(new Book("Book3"));
        
        bookshelf.Summary().Should().Be(@"There are 3 books on the shelf.
Book1
Book2
Book3
");
    }
}