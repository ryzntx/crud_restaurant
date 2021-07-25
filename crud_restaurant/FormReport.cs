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
    public partial class FormReport : Form
    {
        func func_ = new func();
        @const const_ = new @const();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            func_.fun_connection(const_.url_db());
            getComboBoxItem();
        }

        void getComboBoxItem()
        {
            func_.fun_setComboBox("SELECT DISTINCT TOP 100 date FROM OrderHeader;", comboBox1, "date", "date");
            func_.fun_setComboBox("SELECT DISTINCT TOP 100 date FROM OrderHeader;", comboBox2, "date", "date");
            
        }

        void showData()
        {
            func_.fun_read("SELECT date, total FROM OrderHeader WHERE date BETWEEN '"+comboBox1.SelectedValue+"' AND '"+comboBox2.SelectedValue+"' ORDER BY date ASC ", dataGridView1);
        }

        private void btn_bulan_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
