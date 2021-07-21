using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_restaurant
{
    class func
    {
        SqlConnection connection;
        SqlCommand command;
        

        public void fun_connection(string url)
        {
            connection = new SqlConnection(url);
        }

        public void fun_insert(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void fun_update(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void fun_delete(string query)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void fun_read(string query, DataGridView dgv)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                command = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
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
