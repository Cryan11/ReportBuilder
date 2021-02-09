using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ReportBuilder
{
    class Connstr
    {
        public MySqlConnection DB { get; set; }
        public string ConnectionString { get; set; }

        //Open the connection and call it by name
        public void Open(string cs)
        {
            ConnectionString = Connection(cs);
            DB = new MySqlConnection(ConnectionString);
            DB.Open();
        }
        //Close the connection
        public void Close()
        {
            if (DB.State == ConnectionState.Open)
                DB.Close();
        }

        public string Connection(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

