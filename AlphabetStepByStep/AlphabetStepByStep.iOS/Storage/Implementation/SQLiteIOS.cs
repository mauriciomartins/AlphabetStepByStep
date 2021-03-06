﻿using AlphabetStepByStep.Model.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using Xamarin.Forms;
using AlphabetStepByStep.iOS.Storage.Implementation;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace AlphabetStepByStep.iOS.Storage.Implementation
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFileName = "AlphabetStepByStep.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentPath, "..", "library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
