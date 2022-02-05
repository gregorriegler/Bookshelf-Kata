using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Bookshelf.Db
{
    public class DbFactory
    {
        private static DbFactory instance = new DbFactory();

        public static DbFactory getInstance()
        {
            return instance;
        }

        private DbFactory()
        {
        }

        public  Db<T> startDb<T>() {
            return new Db<T>();
        }

        public class Db<T>
        {

            private List<T> objects = new List<T>();

            internal protected Db()
            {
                Thread.Sleep(7000);
            }

            public void persist(T persistable)
            {
                Thread.Sleep(3000);
                objects.Add(persistable);
            }

            public List<T> findAll()
            {
                Thread.Sleep(3000);
                return objects;
            }

            public void clear()
            {
                objects.Clear();
            }
        }
    }
}