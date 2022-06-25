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
    public partial class Metodepembayaran : UserControl
    {
        public Metodepembayaran()
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
                NpgsqlCommand cmd = new NpgsqlCommand("insert into pembayaran ( metode, nama, pajak, diskon) values ('" + metodetext.Text+ "','" + namatext.Text + "','" + pajaktext.Text + "','" + diskontext.Text + "')",conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idmetodetext.Text = " ";
                metodetext.Text = " ";
                namatext.Text = " ";
                pajaktext.Text = " ";
                diskontext.Text = " ";
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
            foreach (DataGridViewRow item in this.datametode.SelectedRows)
            {
                datametode.Rows.RemoveAt(item.Index);
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
            NpgsqlCommand cmd = new NpgsqlCommand("select * from pembayaran",conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datametode.DataSource = dt;
        }

        private void datametode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idmetodetext.Text = datametode.CurrentRow.Cells[0].Value.ToString();
            metodetext.Text = datametode.CurrentRow.Cells[1].Value.ToString();
            namatext.Text = datametode.CurrentRow.Cells[2].Value.ToString();
            pajaktext.Text = datametode.CurrentRow.Cells[3].Value.ToString();
            diskontext.Text = datametode.CurrentRow.Cells[4].Value.ToString();
        }

        private void nline(object sender, EventArgs e)
        {

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = koneksi();
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update pembayaran set metode = '"+metodetext.Text+"',nama = '"+namatext.Text+"',pajak = '"+pajaktext.Text+"',diskon = '"+diskontext.Text+"'where id_metode = @id", conn);
                cmd.Parameters.AddWithValue("@id",int.Parse(idmetodetext.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                load_data();
                idmetodetext.Text = " ";
                metodetext.Text = " ";
                namatext.Text = " ";
                pajaktext.Text = " ";
                diskontext.Text = " ";
                MessageBox.Show("berhasil menambah metode");
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");
            }
        }
    }

}
