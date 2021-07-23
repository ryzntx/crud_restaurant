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
    public partial class FormManageMenu : Form
    {
        func func_ = new func();
        @const const_ = new @const();
        SqlConnection connection;
        SqlCommand command;
        public FormManageMenu()
        {
            InitializeComponent();
        }

        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txb_menuID.Visible = false;
            func_.fun_connection(const_.url_db());
            func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_mangeMenu);
            dgv_mangeMenu.Columns[0].Visible = false;
            dgv_mangeMenu.Columns[5].Visible = false;
        }

        void refresh()
        {
            txb_cari.Clear();
            txb_carbo.Clear();
            txb_filePath.Clear();
            txb_hargaMenu.Clear();
            txb_menuID.Clear();
            txb_namaMenu.Clear();
            txb_protein.Clear();
            pb_fotoFile.Image = null;
            func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_mangeMenu);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txb_namaMenu.Text != "" && txb_hargaMenu.Text != "" && txb_filePath.Text != "" && txb_carbo.Text != "" && txb_protein.Text != "")
            {
                if (MessageBox.Show("Tambahkan Menu Baru??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "INSERT INTO MsMenu([name],[price],[carbo],[protein],[photo]) VALUES('" + txb_namaMenu.Text + "', '" + txb_hargaMenu.Text + "', '" + txb_carbo.Text + "', '" + txb_protein.Text + "', @pic)";
                    func_.fun_insert_image(query,pb_fotoFile);
                    refresh();
                    
                }
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txb_menuID.Text != "" && txb_namaMenu.Text != "" && txb_hargaMenu.Text != "" && txb_filePath.Text != "" && txb_carbo.Text != "" && txb_protein.Text != "")
            {
                if (MessageBox.Show("Perbarui Menu Ini??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE MsMenu SET name='" + txb_namaMenu.Text + "', price='" + txb_hargaMenu.Text + "', carbo='" + txb_carbo.Text + "', protein='" + txb_protein.Text + "', photo=@Pic WHERE id='" + int.Parse(txb_menuID.Text) + "'";
                    func_.fun_insert_image(query, pb_fotoFile);
                    
                }
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txb_menuID.Text != "" && txb_namaMenu.Text != "" && txb_hargaMenu.Text != "" && txb_carbo.Text != "" && txb_protein.Text != "")
            {
                if (MessageBox.Show("Hapus Menu Ini??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    func_.fun_update("DELETE MsMenu WHERE id='" + int.Parse(txb_menuID.Text) + "'");
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_pickFile_Click(object sender, EventArgs e)
        {
            func_.fun_pickFile(txb_filePath,pb_fotoFile);
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (txb_cari.Text != "")
            {
                func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE name='"+txb_cari.Text+ "' OR price='" + txb_cari.Text + "' OR carbo='" + txb_cari.Text + "' OR protein='" + txb_cari.Text + "' ", dgv_mangeMenu);
            }
            else
            {
                func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_mangeMenu);
            }
        }

        private void dgv_mangeMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_mangeMenu.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txb_menuID.Text = row.Cells[0].Value.ToString();
                txb_namaMenu.Text = row.Cells[1].Value.ToString();
                txb_hargaMenu.Text = row.Cells[2].Value.ToString();
                txb_carbo.Text = row.Cells[3].Value.ToString();
                txb_protein.Text = row.Cells[4].Value.ToString();
                if (DBNull.Value.Equals(row.Cells[5].Value))
                {
                    pb_fotoFile.Image = null;
                }
                else
                {
                    pb_fotoFile.Image = func_.ConvertByteToArray((byte[])row.Cells[5].Value);
                }


            }
        }
        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE price='" + Convert.ToInt32(txb_cari.Text) + "' OR carbo='" + Convert.ToInt32(txb_cari.Text)+ "' OR protein='" + Convert.ToInt32(txb_cari.Text) + "' OR name='"+txb_cari.Text+"' ", dgv_mangeMenu);
                }
                else
                {
                    func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_mangeMenu);
                }
            }
        }
    }
}
