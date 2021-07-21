using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            func_.fun_connection(const_.url_db());
            func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu II", dgv_menu);
            func_.fun_read("SELECT MsMenu.name NamaMenu, OrderDetail.qty Banyak, MsMenu.carbo Carbo, MsMenu.protein Protein, MsMenu.price Harga FROM OrderDetail INNER JOIN MsMenu ON OrderDetail.menuId = MsMenu.id; ", dgv_order);
        }

        void refresh()
        {
            txb_cari.Clear();
            txb_namaMenu.Clear();
            txb_qty.Clear();
            func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu", dgv_menu);
        }

        private void dgv_menu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_menu.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txb_namaMenu.Text = row.Cells[0].Value.ToString();


                if (DBNull.Value.Equals(row.Cells[5].Value))
                {
                    pb_image.Image = null;
                }
                else
                {
                    pb_image.Image = ConvertByteToArray((byte[])row.Cells[5].Value);
                }


            }
        }
        public Image ConvertByteToArray(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if(txb_cari.Text != "")
            {
                func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu WHERE name='" + txb_cari.Text + "' ", dgv_menu);
            }
            else
            {
                func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu", dgv_menu);
            }
            
        }

        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu WHERE name='" + txb_cari.Text + "' ", dgv_menu);
                }
                else
                {
                    func_.fun_read("SELECT name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto, image Image FROM MsMenu", dgv_menu);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //func_.fun_insert("INSERT INTO OrderHeader([id],[employeeId],[memberId],[date]) VALUES('""','1','2',getDate());");
        }
    }
}
