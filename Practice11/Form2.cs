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
    public partial class Form2 : Form
    {

        private SqlConnection sqlConnection = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 newfrm1 = new Form1();
            newfrm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SamofalovDYU\Desktop\Practice11\Practice11\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Table] (Question 1, Question 2, Question 3) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}')", sqlConnection);
        }
    }
}
