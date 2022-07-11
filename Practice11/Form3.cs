using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Practice11
{
    
    public partial class Form3 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ar4ak\source\repos\Practice11\Practice11\Database1.mdf; Integrated Security = True");
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
               

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand command = new SqlCommand();

            string addfps = ($"INSERT INTO Table(Name, Last_Name, Otchestvo) VALUES (N'{textBox1.Text}', @'{textBox2.Text}', @'{textBox3.Text}')");

            MessageBox.Show(command.ExecuteNonQuery().ToString());
               
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
