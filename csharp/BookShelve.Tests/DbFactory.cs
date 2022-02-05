using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace BookShelve.Tests
{
    internal class DbFactory
    {

        private static DbFactory instance = new DbFactory();

        internal static DbFactory getInstance()
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

            internal void persist(T persistable)
            {
                Thread.Sleep(3000);
                objects.Add(persistable);
            }

            internal List<T> findAll()
            {
                Thread.Sleep(3000);
                return objects;
            }

            internal void clear()
            {
                objects.Clear();
            }
        }
    }
}