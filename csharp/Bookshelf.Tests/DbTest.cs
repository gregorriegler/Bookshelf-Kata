using FluentAssertions;
using Xunit;
using Bookshelf.Db;
using Bookshelf.Db2;

namespace Bookshelf.Tests;

public class DbTest
{
    [Fact]
    public void DbWorks()
    {
        var dbFactory = DbFactory.getInstance();
        var db = dbFactory.startDb<string>();
        db.findAll().Should().BeEmpty();
        
        db.persist("test");
        db.findAll().Should().Equal("test");
        
        db.persist("another");
        db.findAll().Should().Equal("test", "another");

        db.clear();
        db.findAll().Should().BeEmpty();
    }

    [Fact]
    public void Db2Works()
    {
        var db = new Db2.Db<string>();
        db.findAll().Should().BeEmpty();
        
        db.save("test");
        db.findAll().Should().Equal("test");
        
        db.save("another");
        db.findAll().Should().Equal("test", "another");

        db.clear();
        db.findAll().Should().BeEmpty();
    }
}