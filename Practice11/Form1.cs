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
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
            sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
               // MessageBox.Show("Подключение установлено!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
            this.Hide();

        }
        



    }
}
