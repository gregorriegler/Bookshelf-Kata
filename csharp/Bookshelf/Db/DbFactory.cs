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

        public  Db<T> startDb<T>() {
            return new();
        }

        public class Db<T>
        {
            private readonly List<T> _objects = new();

            protected internal Db()
            {
                Thread.Sleep(7000);
            }

            public void Persist(T persistable)
            {
                Thread.Sleep(3000);
                _objects.Add(persistable);
            }

            public List<T> FindAll()
            {
                Thread.Sleep(3000);
                return _objects;
            }

            public void Clear()
            {
                _objects.Clear();
            }
        }
    }
}