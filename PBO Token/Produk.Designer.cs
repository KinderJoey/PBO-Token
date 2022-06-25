namespace PBO_Token
{
    partial class Produk
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produk));
            this.kotatext = new System.Windows.Forms.TextBox();
            this.dayatext = new System.Windows.Forms.TextBox();
            this.labelkota = new System.Windows.Forms.Label();
            this.labeldaya = new System.Windows.Forms.Label();
            this.barangtext = new System.Windows.Forms.TextBox();
            this.idproduktext = new System.Windows.Forms.TextBox();
            this.labelbarang = new System.Windows.Forms.Label();
            this.labelidproduk = new System.Windows.Forms.Label();
            this.buttonaddnew = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.datagridviewproduk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewproduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kotatext
            // 
            this.kotatext.Location = new System.Drawing.Point(513, 93);
            this.kotatext.Name = "kotatext";
            this.kotatext.Size = new System.Drawing.Size(189, 20);
            this.kotatext.TabIndex = 37;
            // 
            // dayatext
            // 
            this.dayatext.Location = new System.Drawing.Point(513, 45);
            this.dayatext.Name = "dayatext";
            this.dayatext.Size = new System.Drawing.Size(189, 20);
            this.dayatext.TabIndex = 36;
            // 
            // labelkota
            // 
            this.labelkota.AutoSize = true;
            this.labelkota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkota.Location = new System.Drawing.Point(436, 93);
            this.labelkota.Name = "labelkota";
            this.labelkota.Size = new System.Drawing.Size(42, 20);
            this.labelkota.TabIndex = 35;
            this.labelkota.Text = "Kota";
            // 
            // labeldaya
            // 
            this.labeldaya.AutoSize = true;
            this.labeldaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldaya.Location = new System.Drawing.Point(436, 45);
            this.labeldaya.Name = "labeldaya";
            this.labeldaya.Size = new System.Drawing.Size(46, 20);
            this.labeldaya.TabIndex = 34;
            this.labeldaya.Text = "Daya";
            // 
            // barangtext
            // 
            this.barangtext.Location = new System.Drawing.Point(158, 93);
            this.barangtext.Name = "barangtext";
            this.barangtext.Size = new System.Drawing.Size(189, 20);
            this.barangtext.TabIndex = 33;
            // 
            // idproduktext
            // 
            this.idproduktext.Location = new System.Drawing.Point(158, 45);
            this.idproduktext.Name = "idproduktext";
            this.idproduktext.Size = new System.Drawing.Size(189, 20);
            this.idproduktext.TabIndex = 32;
            // 
            // labelbarang
            // 
            this.labelbarang.AutoSize = true;
            this.labelbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbarang.Location = new System.Drawing.Point(35, 93);
            this.labelbarang.Name = "labelbarang";
            this.labelbarang.Size = new System.Drawing.Size(61, 20);
            this.labelbarang.TabIndex = 31;
            this.labelbarang.Text = "Barang";
            // 
            // labelidproduk
            // 
            this.labelidproduk.AutoSize = true;
            this.labelidproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidproduk.Location = new System.Drawing.Point(35, 45);
            this.labelidproduk.Name = "labelidproduk";
            this.labelidproduk.Size = new System.Drawing.Size(77, 20);
            this.labelidproduk.TabIndex = 30;
            this.labelidproduk.Text = "Id Produk";
            this.labelidproduk.Click += new System.EventHandler(this.labelidcustomer_Click);
            // 
            // buttonaddnew
            // 
            this.buttonaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddnew.Location = new System.Drawing.Point(673, 134);
            this.buttonaddnew.Name = "buttonaddnew";
            this.buttonaddnew.Size = new System.Drawing.Size(125, 46);
            this.buttonaddnew.TabIndex = 29;
            this.buttonaddnew.Text = "Add New";
            this.buttonaddnew.UseVisualStyleBackColor = true;
            this.buttonaddnew.Click += new System.EventHandler(this.buttonaddnew_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(673, 238);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(125, 46);
            this.buttondelete.TabIndex = 28;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(673, 342);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(125, 64);
            this.buttonexit.TabIndex = 27;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // datagridviewproduk
            // 
            this.datagridviewproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewproduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagridviewproduk.Location = new System.Drawing.Point(22, 134);
            this.datagridviewproduk.Name = "datagridviewproduk";
            this.datagridviewproduk.Size = new System.Drawing.Size(633, 272);
            this.datagridviewproduk.TabIndex = 26;
            this.datagridviewproduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewproduk_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_produk";
            this.Column1.HeaderText = "Id Produk";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama";
            this.Column2.HeaderText = "Barang";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "daya";
            this.Column3.HeaderText = "Daya";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "kota";
            this.Column4.HeaderText = "Kota";
            this.Column4.Name = "Column4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 450);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(673, 186);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(125, 46);
            this.buttonupdate.TabIndex = 53;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.kotatext);
            this.Controls.Add(this.dayatext);
            this.Controls.Add(this.labelkota);
            this.Controls.Add(this.labeldaya);
            this.Controls.Add(this.barangtext);
            this.Controls.Add(this.idproduktext);
            this.Controls.Add(this.labelbarang);
            this.Controls.Add(this.labelidproduk);
            this.Controls.Add(this.buttonaddnew);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.datagridviewproduk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Produk";
            this.Size = new System.Drawing.Size(820, 450);
            this.Load += new System.EventHandler(this.Produk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewproduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kotatext;
        private System.Windows.Forms.TextBox dayatext;
        private System.Windows.Forms.Label labelkota;
        private System.Windows.Forms.Label labeldaya;
        private System.Windows.Forms.TextBox barangtext;
        private System.Windows.Forms.TextBox idproduktext;
        private System.Windows.Forms.Label labelbarang;
        private System.Windows.Forms.Label labelidproduk;
        private System.Windows.Forms.Button buttonaddnew;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView datagridviewproduk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonupdate;
    }
}
