using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlExecutionResponseTypeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxOptions.Text = "Persist Security Info=True";
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            testConnection();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            execute();
        }

        private void updateDSN(object sender, EventArgs e)
        {
            textBoxConnectionString.Text = "Data Source=" + textBoxServer.Text + ";Initial Catalog=" + textBoxDatabase.Text + ";User Id=" + textBoxUser.Text + ";Password=" + textBoxPassword.Text + ";" + textBoxOptions.Text;
        }

        private void testConnection()
        {
            textBoxTestConnectionResult.Text = "";
            string SqlConnectionString = textBoxConnectionString.Text;
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT 1;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(reader[0].ToString() == "1")
                    {
                        textBoxTestConnectionResult.Text += "Successfully connected!";
                    } else
                    {
                        textBoxTestConnectionResult.Text += "Error: Running 'SELECT 1;' statement did not return anything.";
                    }
                }
                reader.Close();
            } catch( Exception e )
            {
                textBoxTestConnectionResult.Text += e.Message;
            }
        }

        private void execute()
        {
            // To Do: Add message like 'Sorry, we're not going to let you do that!' when textBoxSQL.Text contains string 'DELETE' or 'UPDATE' without a 'WHERE' string.
            textBoxResponse.Text = "";
            string SqlConnectionString = textBoxConnectionString.Text;
            List<string> results = new List<string>();
            string currentResult;
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = textBoxSQL.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                reader = cmd.ExecuteReader();
                if (reader.FieldCount < 1)
                {
                    MessageBox.Show("Some queries (like UPDATE statements) return no results for the SqlDataReader to read.");
                }
                while (reader.Read())
                {
                    currentResult = "[";
                    for( int i = 0; i < reader.FieldCount; i++ )
                    {
                        currentResult += reader[i].ToString() + ",";
                    }
                    results.Add(currentResult.TrimEnd(',') + "]");
                }
                reader.Close();
                textBoxResponse.Text += string.Join(Environment.NewLine, results);
            }
            catch (Exception e)
            {
                textBoxResponse.Text += e.Message;
            }
        }
    }
}
