using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteBuilder
{

public partial class dataEdit : Form
    {
        public string connectionString = "Data Source=DESKTOP-PC1; Integrated Security=SSPI; Initial Catalog=objects;";

        public dataEdit()
        {
            InitializeComponent();
        }

        private void dataEdit_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand comand = sqlConnection.CreateCommand();
            comand.CommandText = "select * from sys.objects where type_desc = 'USER_TABLE'";
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() != "sysdiagrams") {
                    comboBox1.Items.Add(reader[0].ToString());
                }
            }
            sqlConnection.Dispose();
            sqlConnection.Close();            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select table");
                return;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select table");
                return;
            }
            //editForm Form = new editForm(comboBox1.SelectedItem.ToString());
            //dbOperForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand comand = sqlConnection.CreateCommand();
            comand.CommandText = "select * from " + comboBox1.SelectedItem.ToString();
            SqlDataReader reader = comand.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                MessageBox.Show(reader.GetName(i).ToString());
                dataGridView1.
                i++;
            }
            sqlConnection.Dispose();
            sqlConnection.Close();
        }
    }
}
