using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_restaurant
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        @const const_ = new @const();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        void login()
        {
            connection = new SqlConnection(const_.url_db());
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string query = "SELECT position FROM MsEmployee WHERE email='" + txb_email.Text + "' AND password='" + txb_password.Text + "' ";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToString(reader["position"]) == "Admin")
                    {
                        this.Hide();
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.FormClosed += (s, args) => this.Close();
                        formAdmin.Show();
                    }
                    if (Convert.ToString(reader["position"]) == "Kasir")
                    {
                        this.Hide();
                        FormCashier formCashier = new FormCashier();
                        formCashier.FormClosed += (s, args) => this.Close();
                        formCashier.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Email atau Password yang dimasukan tidak valid", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
