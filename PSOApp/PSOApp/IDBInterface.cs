using System;
using SQLite;

namespace PSOApp
{
    public interface IDBInterface
    {
        SQLiteConnection CreateConnection();
    }
}
