using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Bookshelf.Db2
{

    public class Db<T>
    {

        private List<T> objects = new List<T>();

        public Db()
        {
            Thread.Sleep(2000);
        }

        public void save(T persistable)
        {
            Thread.Sleep(500);
            objects.Add(persistable);
        }

        public List<T> findAll()
        {
            Thread.Sleep(500);
            return objects;
        }

        public int count()
        {
            Thread.Sleep(500);
            return objects.Count();
        }

        public void clear()
        {
            objects.Clear();
        }
    }
}
