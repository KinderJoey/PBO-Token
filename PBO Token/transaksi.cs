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
    public partial class transaksi : UserControl
    {
        public transaksi()
        {
            InitializeComponent();
            load_data();
        }
        private static NpgsqlConnection koneksi()
        {
            return new NpgsqlConnection("server=localhost;port=5432;username=postgres;password=spechtra;database=Token");
        }
        void load_data()
        {
            NpgsqlConnection conn = koneksi();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from transaksi", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datatransaksi.DataSource = dt;
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
    
    }
}
