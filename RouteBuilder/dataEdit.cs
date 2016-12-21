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
        public dataEdit()
        {
            InitializeComponent();            
        }

        private void dataEdit_Load(object sender, EventArgs e)
        {
            
            
            foreach (DataTable table in objectsDataSet.Tables)
            {
                comboBox1.Items.Add(table.TableName);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select table");
                return;
            }
            dataGridView1.DataSource = objectsDataSet;
            dataGridView1.DataMember = comboBox1.SelectedItem.ToString();
            //dataGridView1.Update();
            //objectsDataSetTableAdapters.;
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
    }
}
