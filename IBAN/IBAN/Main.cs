using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IBAN
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K90N83G;Initial Catalog=IBAN;Integrated Security=True");
        
        private void Form2_Load(object sender, EventArgs e)
        {
            name.Text = Login.user;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(Login.user == "user1")
            {
                cmd.CommandText = "select * from amount WHERE username='user1'";
            }
            else if (Login.user == "user2")
            {
                cmd.CommandText = "select * from amount WHERE username='user2'";
            }
            
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawBTN_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dou you really want to log out?");
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
