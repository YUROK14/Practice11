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
            sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Form1 newfrm = new Form1();
            newfrm.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Table] (Имя, Фамилия, Отчество) VALUES (@Имя, @Фамилия, @Отчество)", sqlConnection);
            command.Parameters.AddWithValue("Имя", textBox1.Text);
            command.Parameters.AddWithValue("Фамилия", textBox2.Text);
            command.Parameters.AddWithValue("Отчество", textBox3.Text);
            command.ExecuteNonQuery().ToString();
            Button btn = sender as Button;
            btn.Click -= new EventHandler(button1_Click);
            btn.Click += new EventHandler(button1_Click_1);
            button1.Text = "Перейти к тестам";

            
         
        }
    }
}
