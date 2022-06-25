using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Token
{
    public partial class Form1 : Form
    {
        Login objLoginForm;
        Customer objCustomerForm;
        Produk objProdukForm;
        Admin objAdminForm;
        Metodepembayaran objMetodepembayaranForm;
        Supplier objSupplierForm;
        Beranda objBerandaForm;
        transaksi objtransaksiForm;

        public Form1()
        {
            InitializeComponent();
            initGuiKomponen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //gui
        private void initGuiKomponen()
        {
            objLoginForm = new Login(this);
            objLoginForm.Dock = DockStyle.Fill;
            this.Controls.Add(objLoginForm);

            objCustomerForm = new Customer();
            objCustomerForm.Location = new Point(168, 0);
            objCustomerForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objCustomerForm);

            objProdukForm = new Produk();
            objProdukForm.Location = new Point(168, 0);
            objProdukForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objProdukForm);

            objAdminForm = new Admin();
            objAdminForm.Location = new Point(168, 0);
            objAdminForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objAdminForm);

            objMetodepembayaranForm = new Metodepembayaran();
            objMetodepembayaranForm.Location = new Point(168, 0);
            objMetodepembayaranForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objMetodepembayaranForm);

            objSupplierForm = new Supplier();
            objSupplierForm.Location = new Point(168, 0);
            objSupplierForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objSupplierForm);
            
            objBerandaForm = new Beranda();
            objBerandaForm.Location = new Point(168, 0);
            objBerandaForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objBerandaForm);

            objtransaksiForm = new transaksi();
            objtransaksiForm.Location = new Point(168, 0);
            objtransaksiForm.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objtransaksiForm);

            showLoginForm();
        }

        // awalan
        public void hideMainForm()
        {
            BG1.Visible = false;
            BG2.Visible = false;
            labelutama.Visible = false;
            objProdukForm.Visible = false;
            objCustomerForm.Visible = false;
            objAdminForm.Visible = false;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible = false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;

        }
        public void showForm()
        {
            BG1.Visible = true;
            labelutama.Visible = true;
            objBerandaForm.Visible = true;
            BG2.Visible = true;

        }

        //login
        public void showLoginForm()
        {
            objLoginForm.Visible = true;
            hideMainForm();

        }

        //hide form
        
        //public void hidecustomerform()
        //{
        //    objCustomerForm.Visible = false;
        //}
        //public void hideProdukform()
        //{
        //    objProdukForm.Visible = false;
        //}
        
        //show form
        public void showcustomerform()
        {
            objCustomerForm.Visible = true;
            objProdukForm.Visible = false;
            objAdminForm.Visible  =false;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible=false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;

        }
        public void showprodukform()
        {
            objCustomerForm.Visible = false;
            objProdukForm.Visible = true;
            objAdminForm.Visible = false;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible = false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;
        }

        public void showadminform()
        {
            objCustomerForm.Visible = false;
            objProdukForm.Visible = false;
            objAdminForm.Visible = true;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible = false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;
        }
        public void showmetodepembayaranform()
        {
            objCustomerForm.Visible = false;
            objProdukForm.Visible = false;
            objAdminForm.Visible = false;
            objMetodepembayaranForm.Visible = true;
            objSupplierForm.Visible = false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;
        }
        public void showsupplierform()
        {
            objCustomerForm.Visible = false;
            objProdukForm.Visible = false;
            objAdminForm.Visible = false;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible = true;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = false;
        }
        public void showtransaksiform()
        {
            objCustomerForm.Visible = false;
            objProdukForm.Visible = false;
            objAdminForm.Visible = false;
            objMetodepembayaranForm.Visible = false;
            objSupplierForm.Visible = false;
            objBerandaForm.Visible = false;
            objtransaksiForm.Visible = true;
        }

        //button
        private void buttoncustomer_Click(object sender, EventArgs e)
        {
            showcustomerform();
        }

        private void buttonproduk_Click(object sender, EventArgs e)
        {
            showprodukform();
        }

        private void buttonadmin_Click(object sender, EventArgs e)
        {
            showadminform();
        }

        private void buttonmetodepembayaran_Click(object sender, EventArgs e)
        {
            showmetodepembayaranform();
        }

        private void buttonsupplier_Click(object sender, EventArgs e)
        {
            showsupplierform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showtransaksiform();
        }
    }
}  
