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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            load_data();
        }

        private void buttonaddnew_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into admin values ('" + idadmintext.Text + "','" + namatext.Text + "','" + alamattext.Text + "','" + kotatext.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idadmintext.Text = " ";
                namatext.Text = " ";
                alamattext.Text = " ";
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
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.datagridviewadmin.SelectedRows)
            {
                datagridviewadmin.Rows.RemoveAt(item.Index);
            }
        }

        private void alamattext_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelkota_Click(object sender, EventArgs e)
        {

        }

        private void labelalamat_Click(object sender, EventArgs e)
        {

        }

        private void namatext_TextChanged(object sender, EventArgs e)
        {

        }

        private void idadmintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelnama_Click(object sender, EventArgs e)
        {

        }

        private void labelidadmin_Click(object sender, EventArgs e)
        {

        }

        private void datagridviewadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kotatext_TextChanged(object sender, EventArgs e)
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
            NpgsqlCommand cmd = new NpgsqlCommand("select * from admin", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewadmin.DataSource = dt;
        }

        private void datagridviewadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idadmintext.Text = datagridviewadmin.CurrentRow.Cells[0].Value.ToString();
            namatext.Text = datagridviewadmin.CurrentRow.Cells[1].Value.ToString();
            alamattext.Text = datagridviewadmin.CurrentRow.Cells[2].Value.ToString();
            kotatext.Text = datagridviewadmin.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update admin set nama = '" + namatext.Text + "',alamat = '" + alamattext.Text + "',kota = '" + kotatext.Text + "'where id_admin = '" + idadmintext.Text + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idadmintext.Text = " ";
                namatext.Text = " ";
                alamattext.Text = " ";
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
