using System;
using SQLite;
using AlphabetStepByStep.Droid.Storage.Implementation;
using Xamarin.Forms;
using System.IO;
using AlphabetStepByStep.Model.Storage;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace AlphabetStepByStep.Droid.Storage.Implementation
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {

        }
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFileName = "AlphabetStepByStep.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}