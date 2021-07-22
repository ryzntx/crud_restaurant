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
                    connection = new SqlConnection(const_.url_db());
                    try
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();
                        string query = "INSERT INTO MsMenu([name],[price],[carbo],[protein],[photo]) VALUES('" + txb_namaMenu.Text + "', '" + txb_hargaMenu.Text + "', '" + txb_carbo.Text + "', '" + txb_protein.Text + "', @pic)";
                        command = new SqlCommand(query, connection);
                        MemoryStream stream = new MemoryStream();
                        pb_fotoFile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        command.Parameters.AddWithValue("@Pic", pic);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
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
                    connection = new SqlConnection(const_.url_db());
                    try
                    {
                        if (connection.State == ConnectionState.Closed) connection.Open();
                        string query = "UPDATE MsMenu SET name='" + txb_namaMenu.Text + "', price='" + txb_hargaMenu.Text + "', carbo='" + txb_carbo.Text + "', protein='" + txb_protein.Text + "', photo=@Pic WHERE id='" + int.Parse(txb_menuID.Text) + "'";
                        command = new SqlCommand(query, connection);
                        MemoryStream stream = new MemoryStream();
                        pb_fotoFile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = stream.ToArray();
                        command.Parameters.AddWithValue("@Pic", pic);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
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
            Stream myStream = null;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image File(*.jpg; *.jpe; *.jpeg; *.bmp; *.png) | *.jpg; *.jpe; *.jpeg; *.bmp; *.png";
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if((myStream= fileDialog.OpenFile()) != null)
                    {
                        string fileName = fileDialog.FileName;
                        txb_filePath.Text = fileName;
                        if(myStream.Length > 512000)
                        {
                            MessageBox.Show("Ukuran File Terlalu Besar!");
                        }
                        else
                        {
                            pb_fotoFile.Load(fileName);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (txb_cari.Text != "")
            {
                func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE name='"+txb_cari.Text+ "' OR price='" + int.Parse(txb_cari.Text) + "' OR carbo='" + int.Parse(txb_cari.Text) + "' OR protein='" + int.Parse(txb_cari.Text) + "' ", dgv_mangeMenu);
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
                    pb_fotoFile.Image = ConvertByteToArray((byte[])row.Cells[5].Value);
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

        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu WHERE name='" + txb_cari.Text + "' OR price='" + int.Parse(txb_cari.Text) + "' OR carbo='" + int.Parse(txb_cari.Text) + "' OR protein='" + int.Parse(txb_cari.Text) + "' ", dgv_mangeMenu);
                }
                else
                {
                    func_.fun_read("SELECT id MenuID, name NamaMenu, price Harga, carbo Karbohidrat, protein Protein, photo Foto FROM MsMenu", dgv_mangeMenu);
                }
            }
        }

        void loadImage()
        {
            connection = new SqlConnection(const_.url_db());
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

            }
            catch (Exception ex)
            {

                
            }
            finally
            {

            }
        }
    }
}
