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

namespace crud_restaurant
{
    public partial class FormPayment : Form
    {
        func func_ = new func();
        @const const_ = new @const();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            func_.fun_connection(const_.url_db());
            loadComboBox();
            cmb_bankName.Visible = false;
            txb_cardNumber.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txb_cash.Visible = false;
            label7.Visible = false;
            showData();
        }

        void showData()
        {
            try
            {
                string value = cmb_orderId.SelectedItem.ToString();
                label8.Text = $"combobox: {value}";

                func_.fun_read("SELECT MsMenu.name NamaMenu, OrderDetail.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuId = MsMenu.id WHERE orderId='" + cmb_orderId.Text + "' ", dgv_payment);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        void loadComboBox()
        {
            connection = new SqlConnection(const_.url_db());
            string query = "SELECT orderId FROM OrderDetail";
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                command = new SqlCommand(query,connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string orderId = Convert.ToString(reader["orderId"]);
                    cmb_orderId.Items.Add(orderId);
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
        private void cmb_typePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_typePay.SelectedIndex == 1)
            {
                cmb_bankName.Visible = true;
                txb_cardNumber.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txb_cash.Visible = false;
                label7.Visible = false;
            } else if(cmb_typePay.SelectedIndex == 0)
            {
                txb_cash.Visible = true;
                label7.Visible = true;
                cmb_bankName.Visible = false;
                txb_cardNumber.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                cmb_bankName.Visible = false;
                txb_cardNumber.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                txb_cash.Visible = false;
                label7.Visible = false;
            }
        }
    }
}
