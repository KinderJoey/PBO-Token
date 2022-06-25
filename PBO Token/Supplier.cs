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
    public partial class Supplier : UserControl
    {
        public Supplier()
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
                NpgsqlCommand cmd = new NpgsqlCommand("insert into supplier ( supplier, barang, kota, jumlah) values ('" + suppliertext.Text + "','" + barangtext.Text + "','" + kotatext.Text + "','" + jumlahtext.Text + "')", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idsuppliertext.Text = " ";
                suppliertext.Text = " ";
                barangtext.Text = " ";
                kotatext.Text = " ";
                jumlahtext.Text = " ";
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
            foreach (DataGridViewRow item in this.datagridviewsupplier.SelectedRows)
            {
                datagridviewsupplier.Rows.RemoveAt(item.Index);
            }
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server=localhost;port=5432;username=postgres;password=spechtra;database=Token");
        }
        void load_data()
        {
            NpgsqlConnection conn = koneksi();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from supplier", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridviewsupplier.DataSource = dt;
        }

        private void datagridviewsupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsuppliertext.Text = datagridviewsupplier.CurrentRow.Cells[0].Value.ToString();
            suppliertext.Text = datagridviewsupplier.CurrentRow.Cells[1].Value.ToString();
            barangtext.Text = datagridviewsupplier.CurrentRow.Cells[2].Value.ToString();
            kotatext.Text = datagridviewsupplier.CurrentRow.Cells[3].Value.ToString();
            jumlahtext.Text = datagridviewsupplier.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update supplier set supplier = '" + suppliertext.Text + "',barang = '" + barangtext.Text + "',kota = '" + kotatext.Text + "',jumlah = '" + jumlahtext.Text + "'where id_supplier = @id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(idsuppliertext.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idsuppliertext.Text = " ";
                suppliertext.Text = " ";
                barangtext.Text = " ";
                kotatext.Text = " ";
                jumlahtext.Text = " ";
                MessageBox.Show("berhasil menambah metode");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
        }
    }
}
