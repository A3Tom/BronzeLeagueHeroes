using System;
using System.IO;

namespace TS.BronzeLeagueHeroes.Data.Classes
{
    class SqlLoader
    {
        public static string GetSql(string fileName)
        {
            var filePath = string.Format(@"{0}\Sql\{1}.sql", AppDomain.CurrentDomain.BaseDirectory, fileName);
            return File.ReadAllText(filePath);
        }
    }
}
