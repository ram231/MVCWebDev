using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Database
{
    public class DBConenction
    {
        private DBConenction()
        {

        }
        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }

        }
        public string Password { get; set; }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public static DBConenction _instance = null;
        public static DBConenction Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConenction();
            }
            return _instance;
        }
        public bool IsConncet()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=localhost;database={0};UID=Username;password=''", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();

            }
            return true;

        }
        public void Close(){
            connection.Close();
                
        }

    }
}