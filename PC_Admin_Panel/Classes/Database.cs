using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace PC_Admin_Panel.Classes
{
    class Database
    {
        ///   ###   Class propeties   ###   ///

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        ///   ###   Error message & flag   ###   ///

        private string _error_message;
        private bool _error_flag;

        public string Error_Message
        {
            get { return _error_message; }
            set { _error_message = value; }
        }
        public bool Error_Flag
        {
            get { return _error_flag; }
            set { _error_flag = value; }
        }

        ///   ###   Class constructor   ###   ///

        public Database()
        {
            Initialize();
        }

        ///   ###   Methods   ###   ///

        #region Methods

            #region Basic methods

            /// <summary>
            /// Initialize values
            /// </summary>
            private void Initialize()
            {
                // Set server informations
                server = "127.0.0.1";
                database = "database";
                uid = "root";
                password = "";

                string connectionString;

                // Create connection string
                connectionString = $"SERVER= {server}; DATABASE= {database}; UID= {uid}; PASSWORD= {password}; SslMode=none";

                // Create MySqlConnection instance
                try
                {
                    connection = new MySqlConnection(connectionString);
                }
                catch (Exception ex)
                {
                    Error_Flag = true;
                    Error_Message = ex.Message;
                }
            }

            /// <summary>
            /// Open connection to database
            /// </summary>
            /// <returns> Return bool result 
            /// true - connected
            /// false - connection error
            /// </returns>
            private bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    //
                    //  !!! Delete after check program  !!!
                    //  Last one is for extra informations 
                    //
                    switch (ex.Number)
                    {

                        case 0:
                            Error_Flag = true;
                            Error_Message = "Cannot connect to server.  Contact administrator";
                            break;
                        /*
                        case 1045:
                            Error_Flag = true;
                            Error_Message = "Invalid username/password, please try again";
                            break;
                        */
                        default:
                            /// !!!   Delete after check program  !!!
                            Error_Flag = true;
                            Error_Message = "Check if server exists\n\n";
                            Error_Message += ex.Message;
                            break;
                    }
                    return false;
                }
            }

            /// <summary>
            /// Close connection
            /// </summary>
            /// <returns> Result in bool form
            /// true - closed
            /// false - error
            /// </returns>
            private bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    Error_Flag = true;
                    Error_Message = ex.Message;
                    return false;
                }
            }
        

            /// <summary>
            /// Insert statement
            /// </summary>
            /// <param name="query"> Your query like 
            /// "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')"; 
            /// </param>
            public void Insert(string query)
            {
                // Open connection
                if (this.OpenConnection() == true)
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute command
                    cmd.ExecuteNonQuery();

                    // Close connection
                    this.CloseConnection();
                }
            }

            /// <summary>
            /// Update statement
            /// </summary>
            /// <param name="query"> Your query like 
            /// "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'"
            /// </param>
            public void Update(string query)
            {
                // Open connection
                if (this.OpenConnection() == true)
                {
                    // Create mysql command
                    MySqlCommand cmd = new MySqlCommand();

                    // Assign the query using CommandText
                    cmd.CommandText = query;

                    // Assign the connection using Connection
                    cmd.Connection = connection;

                    // Execute query
                    cmd.ExecuteNonQuery();

                    // Close connection
                    this.CloseConnection();
                }
            }

            /// <summary>
            /// Delete statement
            /// </summary>
            /// <param name="query"> Your query like
            /// "DELETE FROM tableinfo WHERE name='John Smith'"
            /// </param>
            public void Delete(string query)
            {
                if (this.OpenConnection() == true)
                {
                    // Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute query
                    cmd.ExecuteNonQuery();

                    // Close connection
                    this.CloseConnection();
                }
            }

            /// <summary>
            /// Count statement
            /// </summary>
            /// <param name="query"> Your query like
            /// "SELECT Count(*) FROM tableinfo"
            /// </param>
            /// <returns></returns> 
            public int Count(string query)
            {
                int Count = -1;

                // Open Connection
                if (this.OpenConnection() == true)
                {
                    // Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    // Close Connection
                    this.CloseConnection();

                    return Count;
                }
                else
                {
                    return Count;
                }
            }

            #endregion

            #region Dedicated methods (for this program)

            ///   Load data from server   ///

            /// <summary>
            /// Method load from server admins informations
            /// </summary>
            /// <param name="Admins_List"></param>
            public void Select_Admins(ref List<Classes.Admin> Admins_List)
                {
                    string query = "SELECT * FROM admins";

                    if (this.OpenConnection())
                    {
                        // Create command
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        // Create a data reader and Execute the command
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        // Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            Admins_List.Add(new Admin(
                            dataReader["login"].ToString(),
                            dataReader["password"].ToString()
                             ));
                        }

                        // Close Data Reader
                        dataReader.Close();

                        // Close Connection
                        CloseConnection();
                    }
                }

            /// <summary>
            /// Method load from server users informations
            /// </summary>
            /// <param name="Users_List"> Users list </param>
            public void Select_Users(ref List<User> Users_List)
            {
                string query = "SELECT * FROM users";

                if (this.OpenConnection())
                {
                    // Create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    // Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Users_List.Add(new User(
                        Int32.Parse(dataReader["UID"].ToString()),
                        dataReader["Fuid"].ToString(),
                        dataReader["Guid"].ToString(),
                        dataReader["fname"].ToString(),
                        dataReader["lname"].ToString(),
                        dataReader["email"].ToString(),
                        dataReader["fullname"].ToString(),
                        dataReader["fblink"].ToString(),
                        dataReader["gender"].ToString(),
                        dataReader["dp"].ToString(),
                        dataReader["lastlogin"].ToString(),
                        dataReader["registrationtime"].ToString(),
                        dataReader["referal"].ToString(),
                        dataReader["last_modified"].ToString(),
                        null,
                        false
                         ));
                    }

                    // Close Data Reader
                    dataReader.Close();

                    // Close Connection
                    CloseConnection();
                }
            }

            /// <summary>
            /// Method load from server packs informations
            /// </summary>
            /// <param name="Packs_List"> Packs list </param>
            public void Select_Packs(ref List<Pack> Packs_List)
            {
                string query = "SELECT * FROM warehouse";

                if (this.OpenConnection())
                {
                    // Create command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                    Packs_List.Add(new Pack(
                        Int32.Parse(dataReader["id"].ToString()),
                        Int32.Parse(dataReader["UID"].ToString()),
                        dataReader["fname"].ToString(),
                        dataReader["lname"].ToString(),
                        dataReader["phone"].ToString(),
                        dataReader["country"].ToString(),
                        dataReader["postal_code"].ToString(),
                        dataReader["place"].ToString(),
                        dataReader["house_number"].ToString(),
                        Double.Parse(dataReader["weigth"].ToString()),
                        Double.Parse(dataReader["price"].ToString()),
                        Int32.Parse(dataReader["quantity"].ToString()),
                        Int32.Parse(dataReader["insurance"].ToString()),
                        /*
                         * Change type into string
                         * 
                        (Pack.Payment_Status) Int32.Parse(dataReader["status"].ToString()),
                        (Pack.Delivery_Status) Int32.Parse(dataReader["position"].ToString()),
                        (Pack.Delivery_Option) Int32.Parse(dataReader["option"].ToString()),
                        */
                        dataReader["status"].ToString(),
                        dataReader["position"].ToString(),
                        dataReader["option"].ToString(),
                        "0000",
                        "0000",
                        //dataReader["ordered"].ToString(),
                        //dataReader["delivered"].ToString(),
                        null,
                        false
                        ));
                }
                }
            }

            ///   Display data from server   ///

            /// <summary>
            /// Method load users data from server
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_Users_List()
            {
                string query = "SELECT" +
                    " UID," +
                    " Fuid," +
                    " Guid," +
                    " fname," +
                    " lname," +
                    " email," +
                    " fullname," +
                    " gender," +
                    " lastlogin," +
                    " registrationtime," +
                    " last_modified" +
                    "" +
                    " FROM" +
                    " users";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load data from server
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_Packs_List()
            {
            string query = "SELECT" +
                " id," +
                " UID," +
                " fname," +
                " lname," +
                " phone," +
                " country," +
                " postal_code," +
                " place," +
                " house_number," +
                " weigth," +
                " price," +
                " quantity," +
                " insurance," +
                " status," +
                " position," +
                " option," +
                " ordered," +
                " delivered," +
                " status_checked," +
                " delivered_checked," +
                " product_name" +
                "" +
                " FROM" +
                " warehouse";

            DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load unpayed orders from server
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_Unpaied_Packs_List()
            {
                string query = "SELECT" +
                    " id," +
                    " UID," +
                    " fname," +
                    " lname," +
                    " phone," +
                    " country," +
                    " postal_code," +
                    " place," +
                    " house_number," +
                    " weigth," +
                    " price," +
                    " quantity," +
                    " insurance," +
                    " status," +
                    " position," +
                    " option," +
                    " ordered," +
                    " delivered," +
                    " status_checked," +
                    " delivered_checked," +
                    " product_name" +
                    "" +
                    " FROM" +
                    " warehouse" +
                    "" +
                    " WHERE" +
                    " status = 'waiting_for_a_transfer'";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load undelivered orders from server
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_Undelivered_Packs_List()
            {
                string query = "SELECT" +
                    " id," +
                    " UID," +
                    " fname," +
                    " lname," +
                    " phone," +
                    " country," +
                    " postal_code," +
                    " place," +
                    " house_number," +
                    " weigth," +
                    " price," +
                    " quantity," +
                    " insurance," +
                    " status," +
                    " position," +
                    " option," +
                    " ordered," +
                    " delivered," +
                    " status_checked," +
                    " delivered_checked," +
                    " product_name" +
                    "" +
                    " FROM" +
                    " warehouse" +
                    "" +
                    " WHERE" +
                    " position != 'delivered'";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load list of admins from server
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_Admins_List()
            {
                string query = "SELECT" +
                    " login," +
                    " last_logedin" +
                    "" +
                    " FROM" +
                    " admins";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load informations IP data
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_IP_Data_Informations()
            {
                string query = 
                    "SELECT" +
                    " id," +
                    " admin_id," +
                    " ip," +
                    " UID," +
                    " visited," +
                    " city," +
                    " region," +
                    " region_code," +
                    " country," +
                    " country_name," +
                    " continent_code," +
                    " in_eu," +
                    " postal," +
                    " latitude," +
                    " longitude," +
                    " timezone," +
                    " utc_offset," +
                    " country_calling_code," +
                    " currency, languages," +
                    " asn," +
                    " org" +
                    " FROM" +
                    " ip_data";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            }

            /// <summary>
            /// Method load informations PC data
            /// </summary>
            /// <returns> Results in DataTime form </returns>
            public DataTable Load_PC_Data_Informations()
            {
                string query =
                    "SELECT" +
                    " id," +
                    " admin_id," +
                    " ip," +
                    " UID," +
                    " visited," +
                    " windows_version," +
                    " 64BitOS," +
                    " pc_name," +
                    " cpus_number," +
                    " logical_drivers_available," +
                    " windows_folder," +
                    " host_name," +
                    " domain_name" +
                    " FROM" +
                    " pc_data";

                DataTable table = new DataTable();

                if (this.OpenConnection())
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Error_Flag = true;
                        Error_Message = ex.Message;

                        table = null;
                    }
                }
                else
                    table = null;

                CloseConnection();

                return table;
            } 

            #endregion

        #endregion
    }
}
