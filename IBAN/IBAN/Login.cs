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
    public partial class Login : Form
    {
        public static String user;
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K90N83G;Initial Catalog=IBAN;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            String username, password;

            username = usernameTXT.Text;
            password = passwordTXT.Text;

            try
            {
                String querry = "SELECT * FROM users WHERE username ='" + usernameTXT.Text + "' AND password = '" + passwordTXT.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = usernameTXT.Text;
                    password = passwordTXT.Text;

                    user = usernameTXT.Text;
                    Main form2 = new Main();
                    form2.Show();
                    
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTXT.Clear();
                    passwordTXT.Clear();

                    usernameTXT.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }