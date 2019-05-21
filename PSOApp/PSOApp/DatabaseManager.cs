using System;
using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;

namespace PSOApp
{
    public class DatabaseManager
    {
        SQLiteConnection dbConnection;
        public DatabaseManager()
        {
            dbConnection = DependencyService.Get<IDBInterface>().CreateConnection();
        }


        public List<ItemModel> GetAllItems()
        {
            return dbConnection.Query<ItemModel>("Select * From [Employee]");
        }

        public int SaveEmployee(ItemModel aItem)

        {
            return dbConnection.Insert(aItem);
        }
    }
}
