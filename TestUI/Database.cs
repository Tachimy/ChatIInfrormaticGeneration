using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI
{
    public static class Database
    {
        public static string ConnectionString { get; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DictionaryDB.mdf;Integrated Security=True";
    }
}
