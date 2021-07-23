using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_restaurant
{
    public partial class FormOrder : Form
    {
        func func_ = new func();
        @const const_ = new @const();
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        int id = 0;
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            func_.fun_connection(const_.url_db());
            func_.fun_read("SELECT id MenuId, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_menu);
            func_.fun_read("SELECT tempOrder.id orderid, MsMenu.name NamaMenu, tempOrder.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga, tempOrder.total Total FROM tempOrder INNER JOIN MsMenu ON tempOrder.menuId = MsMenu.id; ", dgv_order);
            txb_menuId.Visible = false;
            dgv_menu.Columns[0].Visible = false;
            dgv_menu.Columns[5].Visible = false;
            dgv_order.Columns[0].Visible = false;
        }

        void refresh()
        {
            txb_cari.Clear();
            txb_namaMenu.Clear();
            txb_qty.Clear();
            pb_image.Image = null;
            func_.fun_read("SELECT tempOrder.id, MsMenu.name NamaMenu, tempOrder.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga, tempOrder.total Total FROM tempOrder INNER JOIN MsMenu ON tempOrder.menuId = MsMenu.id; ", dgv_order);
            dgv_order.Columns[0].Visible = false;
            func_.fun_setText("SELECT SUM(carbo) hasil FROM tempOrder INNER JOIN MsMenu ON tempOrder.menuId = MsMenu.id;","Karbohidrat", label4,"hasil");
            func_.fun_setText("SELECT SUM(protein) hasil FROM tempOrder INNER JOIN MsMenu ON tempOrder.menuId = MsMenu.id;","Protein", label5,"hasil");
            func_.fun_setText("SELECT SUM(total) hasil FROM tempOrder INNER JOIN MsMenu ON tempOrder.menuId = MsMenu.id;","Total", label6,"hasil");
        }

        string total()
        {
            int qty = int.Parse(txb_qty.Text);
            int price = int.Parse(txb_price.Text);
            int hasil = price * qty;
            string finaly = hasil.ToString();
            return finaly;
            
        }
       
        string generateId()
        {
            int id = 0;
            string date = DateTime.Now.ToString("yyyyMMdd");
            string hasil = $"{date}{id++.ToString().PadLeft(3,'0')}";
            txb_orderId.Text = hasil;
            return hasil;
        }

        void checkId()
        {

        }

        private void dgv_menu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_menu.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txb_menuId.Text = row.Cells[0].Value.ToString();
                txb_namaMenu.Text = row.Cells[1].Value.ToString();
                txb_price.Text = row.Cells[2].Value.ToString();
                if (DBNull.Value.Equals(row.Cells[5].Value))
                {
                    pb_image.Image = null;
                }
                else
                {
                    pb_image.Image = func_.ConvertByteToArray((byte[])row.Cells[5].Value);
                }
            }
        }
        private void btn_cari_Click(object sender, EventArgs e)
        {
            if(txb_cari.Text != "")
            {
                func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE name='" + txb_cari.Text + "' ", dgv_menu);
            }
            else
            {
                func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_menu);
            }
            
        }

        

        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE name='" + txb_cari.Text + "' ", dgv_menu);
                }
                else
                {
                    func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_menu);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            func_.fun_delete("DELETE FROM tempOrder WHERE='"+txb_menuId.Text+"'");
            refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            func_.fun_query("INSERT INTO OrderHeader([id],[employeeId],[memberId],[date]) VALUES('"+txb_orderId.Text+ "','1','2',getDate());");
            func_.fun_insert("INSERT INTO tempOrder([menuId],[qty],[total]) VALUES('" + txb_menuId.Text+"', '"+ txb_qty.Text+"', '"+total()+"')");
            //func_.fun_insert("INSERT INTO OrderDetail([orderId],[menuId],[qty]) VALUES('" + generateId() + "', '" + txb_menuId.Text + "','" + txb_qty.Text + "')");
            total();
            refresh();
        }
        private void btn_insertOrder_Click(object sender, EventArgs e)
        {

            string query = @"INSERT INTO OrderDetail([orderId],[menuId],[qty]) VALUES
                (@order, @name,@qty)";
            connection = new SqlConnection(const_.url_db());
            try
            {
                foreach (DataGridViewRow row in dgv_order.Rows)
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@order", txb_orderId.Text);
                    command.Parameters.AddWithValue("@name", row.Cells[1].Value);
                    command.Parameters.AddWithValue("@qty", row.Cells[2].Value);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            
        }

        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            func_.fun_query("DELETE FROM tempOrder");
        }

        private void btn_hapusOrder_Click(object sender, EventArgs e)
        {
            func_.fun_delete("DELETE FROM tempOrder");
            txb_orderId.Clear();
            refresh();
        }

        private void dgv_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_order.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.

                txb_menuId.Text = row.Cells[0].Value.ToString();
                txb_namaMenu.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //generateId();
            
            string date = DateTime.Now.ToString("yyyyMMdd");
            id++;
            string hasil = $"{date}{id.ToString().PadLeft(3, '0')}";
            txb_orderId.Text = hasil;
            Console.WriteLine(id);
        }
    }
}
