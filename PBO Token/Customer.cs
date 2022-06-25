using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PBO_Token
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
            load_data();
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private void MeExit()
        {

            DialogResult iExit;

            iExit = MessageBox.Show("Confirm", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.datagridviewcustomer.SelectedRows)
            {
                datagridviewcustomer.Rows.RemoveAt(item.Index);
            }
        }

        private void labelidcustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonaddnew_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into customer values ('" + idcustomertext.Text + "','" + idpelanggantext.Text + "','" + namatext.Text + "','" + kotatext.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idcustomertext.Text = " ";
                idpelanggantext.Text = " ";
                namatext.Text = " ";
                kotatext.Text = " ";
                MessageBox.Show("berhasil menambah metode");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            
        }

        private void datagridviewcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server=localhost;port=5432;username=postgres;password=spechtra;database=Token");
        }
        void load_data()
        {
            NpgsqlConnection conn = koneksi();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from customer", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewcustomer.DataSource = dt;
        }

        private void datagridviewcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcustomertext.Text = datagridviewcustomer.CurrentRow.Cells[0].Value.ToString();
            idpelanggantext.Text = datagridviewcustomer.CurrentRow.Cells[1].Value.ToString();
            namatext.Text = datagridviewcustomer.CurrentRow.Cells[2].Value.ToString();
            kotatext.Text = datagridviewcustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update customer set id_pelanggan = '" + idpelanggantext.Text + "',nama = '" + namatext.Text + "',kota = '" + kotatext.Text + "'where id_customer = '" + idcustomertext.Text + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idcustomertext.Text = " ";
                idpelanggantext.Text = " ";
                namatext.Text = " ";
                kotatext.Text = " ";
                MessageBox.Show("berhasil menambah metode");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
        }
    }
}
