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
    public partial class Produk : UserControl
    {
        public Produk()
        {
            InitializeComponent();
            load_data();
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
                NpgsqlCommand cmd = new NpgsqlCommand("insert into produk values ('" + idproduktext.Text + "','" + barangtext.Text + "','" + dayatext.Text + "','" + kotatext.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idproduktext.Text = " ";
                barangtext.Text = " ";
                dayatext.Text = " ";
                kotatext.Text = " ";
                MessageBox.Show("berhasil menambah metode");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.datagridviewproduk.SelectedRows)
            {
                datagridviewproduk.Rows.RemoveAt(item.Index);
            }
        }

        private void Produk_Load(object sender, EventArgs e)
        {
            
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

        private void buttonexit_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server=localhost;port=5432;username=postgres;password=spechtra;database=Token");
        }
        void load_data()
        {
            NpgsqlConnection conn = koneksi();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from produk", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewproduk.DataSource = dt;
        }

        private void datagridviewproduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idproduktext.Text = datagridviewproduk.CurrentRow.Cells[0].Value.ToString();
            barangtext.Text = datagridviewproduk.CurrentRow.Cells[1].Value.ToString();
            dayatext.Text = datagridviewproduk.CurrentRow.Cells[2].Value.ToString();
            kotatext.Text = datagridviewproduk.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update produk set nama = '" + barangtext.Text + "',daya = '" + dayatext.Text + "',kota = '" + kotatext.Text + "'where id_produk = '" + idproduktext.Text + "'", conn);
                //NpgsqlCommand cmd = new NpgsqlCommand("update produk set nama = '" + barangtext.Text + "',daya = '" + dayatext.Text + "',kota = '" + kotatext.Text + "'where id_produk = @id", conn);
                //cmd.Parameters.AddWithValue("@id", int.Parse(idproduktext.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idproduktext.Text = " ";
                barangtext.Text = " ";
                dayatext.Text = " ";
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
