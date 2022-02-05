using FluentAssertions;
using Xunit;

namespace BookShelve.Tests;

public class DbTest
{
    [Fact]
    public void Works()
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
}