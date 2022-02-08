using FluentAssertions;
using Xunit;
using Bookshelf.Db;
using Bookshelf.Db2;

namespace Bookshelf.Tests
{

    public class DbTest
    {
        [Fact (Skip="dont bother the kata solver")]
        public void DbWorks()
        {
            var dbFactory = DbFactory.GetInstance();
            var db = dbFactory.startDb<string>();
            db.FindAll().Should().BeEmpty();

            db.Persist("test");
            db.FindAll().Should().Equal("test");

            db.Persist("another");
            db.FindAll().Should().Equal("test", "another");

            db.Clear();
            db.FindAll().Should().BeEmpty();
        }

        [Fact (Skip="dont bother the kata solver")]
        public void Db2Works()
        {
            var db = new Db<string>();
            db.FindAll().Should().BeEmpty();

            db.Save("test");
            db.FindAll().Should().Equal("test");

            db.Save("another");
            db.FindAll().Should().Equal("test", "another");

            db.Clear();
            db.FindAll().Should().BeEmpty();
        }
    }
}