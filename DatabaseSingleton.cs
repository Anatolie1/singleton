using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Singleton
{
    public sealed class DatabaseSingleton
    {
        private static DatabaseSingleton instance;
        private DatabaseSingleton()
        {
            Console.WriteLine("Connection to DB");
        }

        public static DatabaseSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseSingleton();
            }
            return instance;
        }

    }
}
