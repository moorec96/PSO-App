using System;
using SQLite;
using SQLite.Net;

namespace PSOApp
{
    public interface IDBInterface
    {
        SQLiteConnection CreateConnection();
    }
}
