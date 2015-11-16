using System;
using NFX;
using NFX.Wave.Client;
using NFX.DataAccess.MySQL;
using NFX.Serialization.JSON;
using Wave.DbApplication.Models;

namespace Wave.DbApplication
{
    internal static class AppContext
    {
        public static MySQLDataStore DataStore
        {
            get { return App.DataStore as MySQLDataStore; }
        }

        public static string FormJSON(Person person, Exception validationError = null)
        {
            return RecordModelGenerator.RowToRecordInitJSON(person, validationError).ToJSON();
        }
    }
}
