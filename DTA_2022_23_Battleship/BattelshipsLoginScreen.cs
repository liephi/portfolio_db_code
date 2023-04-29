using DTA_2022_23_Battleship.Model.Ships;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTA_2022_23_Battleship
{
    public partial class BattelshipsLoginScreen : Form
    {
        public BattelshipsLoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BattleshipContext()) {
                var user = db.Users.Where(u => u.UserName == txtUsername.Text)
                                   .First();
                if (!user.Deactivated)
                {
                }
                   
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=battleship.db;Version=3;";
            string insertQuery = "INSERT INTO Users (username, password) VALUES (@username, @password);";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // create a command to insert the values
                 using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // set the parameter values
                    command.Parameters.AddWithValue("@UserName", UStxt.Text);
                    command.Parameters.AddWithValue("@PasswordHash", PWtxt.Text);

                    // execute the command
                    command.ExecuteNonQuery();
                    

                }
                connection.Close();
            }
        }
    }
}
