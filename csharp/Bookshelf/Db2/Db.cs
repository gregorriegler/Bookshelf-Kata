using System.Collections.Generic;
using System.Threading;

namespace Bookshelf.Db2
{

    public class Db<T>
    {

        private readonly List<T> _objects = new();

        public Db()
        {
            Thread.Sleep(2000);
        }

        public void Save(T persistable)
        {
            Thread.Sleep(500);
            _objects.Add(persistable);
        }

        public List<T> FindAll()
        {
            Thread.Sleep(500);
            return _objects;
        }

        public int Count()
        {
            Thread.Sleep(500);
            return _objects.Count;
        }

        public void Clear()
        {
            _objects.Clear();
        }
    }
}
