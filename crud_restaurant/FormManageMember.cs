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
    public partial class FormManageMember : Form
    {
        func func_ = new func();
        @const const_ = new @const();
        public FormManageMember()
        {
            InitializeComponent();
        }

        void refresh()
        {
            txb_cari.Clear();
            txb_email.Clear();
            txb_handphone.Clear();
            txb_memberID.Clear();
            txb_nama.Clear();
            func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember", dgv_manageMember);
        }

        private void FormManageMember_Load(object sender, EventArgs e)
        {
            txb_memberID.Visible = false;
            label2.Visible = false;
            func_.fun_connection(const_.url_db());
            func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember", dgv_manageMember);
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
                if (txb_cari.Text != "") { 
                    func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember WHERE name='" + txb_cari.Text + "' OR email='" + txb_cari.Text + "' OR handphone='" + txb_cari.Text + "' ", dgv_manageMember); 
                }
                else
                {
                    func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember", dgv_manageMember);
                }
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txb_nama.Text != "" && txb_email.Text != "" && txb_handphone.Text != "") 
            {
                if(MessageBox.Show("Tambahkan Member Baru??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                func_.fun_insert("INSERT INTO MsMember([name],[email],[handphone],[joinDate]) VALUES('" + txb_nama.Text + "', '" + txb_email.Text + "', '" + txb_handphone.Text + "', getDate())");
                refresh();
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txb_memberID.Text != "" && txb_nama.Text != "" && txb_email.Text != "" && txb_handphone.Text != "")
            {
                if (MessageBox.Show("Perbarui Member Ini??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    func_.fun_update("UPDATE MsMember SET name='" + txb_nama.Text + "', email='" + txb_email.Text + "', handphone='" + txb_handphone.Text + "' WHERE id='" + int.Parse(txb_memberID.Text) + "' ");
                refresh();
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txb_memberID.Text != "" && txb_nama.Text != "" && txb_email.Text != "" && txb_handphone.Text != "")
            {
                if (MessageBox.Show("Hapus Member Ini??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    func_.fun_delete("DELETE MsMember WHERE id='"+int.Parse(txb_memberID.Text)+"'");
                refresh();
            }
            else
            {
                MessageBox.Show("Harap Isi Semua Kolom!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_manageMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgv_manageMember.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txb_memberID.Text = row.Cells[0].Value.ToString();
                txb_nama.Text = row.Cells[1].Value.ToString();
                txb_email.Text = row.Cells[2].Value.ToString();
                txb_handphone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void txb_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txb_cari.Text != "")
                {
                    func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember WHERE name='" + txb_cari.Text + "' OR email='" + txb_cari.Text + "' OR handphone='" + txb_cari.Text + "' ", dgv_manageMember);
                }
                else
                {
                    func_.fun_read("SELECT id MemberID, name Nama, email Email, handphone Handphone, joinDate TanggalBergabung FROM MsMember", dgv_manageMember);
                }
            }
        }

       
    }
}
