using System;
using System.IO;
using SQLite;


[assembly: Xamarin.Forms.Dependency(typeof(PSOApp.Droid.DatabaseService))]
namespace PSOApp.Droid
{
    public class DatabaseService : IDBInterface
    {

        public SQLiteConnection CreateConnection()
        {
            var dbName = "Drop_Chart_DB.db";
            var path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }

        void ReadWriteStream(Stream readStream, Stream writeStream)
        {
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            while (bytesRead >= 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }
    }
}
