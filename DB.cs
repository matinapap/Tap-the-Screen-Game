using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace froggame
{
    internal class DB
    {

        static public void Creation_DB(ref String connectionString, ref SQLiteConnection connection)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String createSQL = "Create table if not exists Players(Level integer ," + "Username Text," + "Counter integer)";
            SQLiteCommand command = new SQLiteCommand(createSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        static public void Insert_DB(ref String connectionString, ref SQLiteConnection connection, String player, String level, int score)
        {
            connection.Open();
            String insertSQL = "Insert into Players(Username,Level,Counter) values(@Username,@Level,@Counter)";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            command.Parameters.AddWithValue("Username", player);
            command.Parameters.AddWithValue("Level", level);
            command.Parameters.AddWithValue("Counter", score);
            command.ExecuteNonQuery();
            connection.Close();
        }

        static public void Show_Levels(ref String connectionString, ref SQLiteConnection connection, String level, ref System.Collections.Generic.List <int> top5, ref System.Collections.Generic.List<String> topnames)
        {

            connection.Open();
            String selectSQL = "Select * from Players";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            int temp1;
            string temp2;
            while (reader.Read())
            {
                string col1Value = reader[0].ToString();
                if (col1Value == level)
                {
                    string col2Value = reader[1].ToString();
                    string con=reader[2].ToString();
                    int col3Value = Int32.Parse(con);
                    top5.Add(col3Value);
                    topnames.Add(col2Value);
                }
            }
            for (int j = 0; j < top5.Count - 1; j++)
            {
                for (int i = 0; i < top5.Count - j - 1; i++)
                {
                    if (top5[i] < top5[i + 1])
                    {
                        temp1 = top5[i + 1];
                        top5[i + 1] = top5[i];
                        top5[i] = temp1;
                        temp2 = topnames[i + 1];
                        topnames[i + 1] = topnames[i];
                        topnames[i] = temp2;
                    }
                }
            }
            connection.Close();
        }
    }
}
