using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_restaurant
{
    public partial class FormPayment : Form
    {
        
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            cmb_bankName.Visible = false;
            txb_cardNumber.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txb_cash.Visible = false;
            label7.Visible = false;
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
