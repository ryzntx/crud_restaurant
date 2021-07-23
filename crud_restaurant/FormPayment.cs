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
                func_.fun_read("SELECT MsMenu.name NamaMenu, OrderDetail.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuId = MsMenu.id WHERE orderId='" + cmb_orderId.Text + "' ", dgv_payment);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        void loadComboBox()
        {
            func_.fun_setComboBox(@"SELECT * FROM OrderDetail WHERE status='unpaid' ", cmb_orderId, "orderId", "orderId");
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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            func_.fun_update(@"UPDATE OrderHeader SET 
            paymentType='"+cmb_typePay.Text+"', bank='"+cmb_bankName.Text+ "', cardNumber='" + txb_cardNumber.Text+"' WHERE id='"+cmb_orderId.Text+"' ");
            func_.fun_query(@"UPDATE OrderDetail SET status='Paid' WHERE orderId='"+cmb_orderId.Text+"'");
        }
    }
}
