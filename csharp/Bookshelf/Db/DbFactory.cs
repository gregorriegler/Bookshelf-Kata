using System.Collections.Generic;
using System.Threading;

namespace Bookshelf.Db
{
    public class DbFactory
    {
        private static readonly DbFactory Instance = new();

        public static DbFactory GetInstance()
        {
            return Instance;
        }

        private DbFactory()
        {
        }

        public static Db startDb() {
            return new();
        }

        public class Db
        {
            private readonly List<Dictionary<string,object>> _objects = new();

            protected internal Db()
            {
                Thread.Sleep(1000);
            }

            public void Persist(Dictionary<string,object> item)
            {
                Thread.Sleep(500);
                _objects.Add(item);
            }

            public List<Dictionary<string,object>> FindAll()
            {
                Thread.Sleep(500);
                return _objects;
            }

            public void Clear()
            {
                _objects.Clear();
            }
        }
    }
}