using System;
using System.Collections.Generic;
using SQLite;
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
            return dbConnection.Query<ItemModel>("Select * From Drops");
        }

        public int SaveEmployee(ItemModel aItem)

        {
            return dbConnection.Insert(aItem);
        }
    }
}
