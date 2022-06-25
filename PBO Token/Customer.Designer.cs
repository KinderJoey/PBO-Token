namespace PBO_Token
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.kotatext = new System.Windows.Forms.TextBox();
            this.namatext = new System.Windows.Forms.TextBox();
            this.labelkota = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.idpelanggantext = new System.Windows.Forms.TextBox();
            this.idcustomertext = new System.Windows.Forms.TextBox();
            this.labelidpelanggan = new System.Windows.Forms.Label();
            this.labelidcustomer = new System.Windows.Forms.Label();
            this.buttonaddnew = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.datagridviewcustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kotatext
            // 
            this.kotatext.Location = new System.Drawing.Point(513, 93);
            this.kotatext.Name = "kotatext";
            this.kotatext.Size = new System.Drawing.Size(189, 20);
            this.kotatext.TabIndex = 25;
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(513, 45);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(189, 20);
            this.namatext.TabIndex = 24;
            // 
            // labelkota
            // 
            this.labelkota.AutoSize = true;
            this.labelkota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkota.Location = new System.Drawing.Point(436, 93);
            this.labelkota.Name = "labelkota";
            this.labelkota.Size = new System.Drawing.Size(42, 20);
            this.labelkota.TabIndex = 23;
            this.labelkota.Text = "Kota";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnama.Location = new System.Drawing.Point(436, 45);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(51, 20);
            this.labelnama.TabIndex = 22;
            this.labelnama.Text = "Nama";
            // 
            // idpelanggantext
            // 
            this.idpelanggantext.Location = new System.Drawing.Point(158, 93);
            this.idpelanggantext.Name = "idpelanggantext";
            this.idpelanggantext.Size = new System.Drawing.Size(189, 20);
            this.idpelanggantext.TabIndex = 21;
            // 
            // idcustomertext
            // 
            this.idcustomertext.Location = new System.Drawing.Point(158, 45);
            this.idcustomertext.Name = "idcustomertext";
            this.idcustomertext.Size = new System.Drawing.Size(189, 20);
            this.idcustomertext.TabIndex = 20;
            // 
            // labelidpelanggan
            // 
            this.labelidpelanggan.AutoSize = true;
            this.labelidpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidpelanggan.Location = new System.Drawing.Point(35, 93);
            this.labelidpelanggan.Name = "labelidpelanggan";
            this.labelidpelanggan.Size = new System.Drawing.Size(103, 20);
            this.labelidpelanggan.TabIndex = 19;
            this.labelidpelanggan.Text = "Id Pelanggan";
            // 
            // labelidcustomer
            // 
            this.labelidcustomer.AutoSize = true;
            this.labelidcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidcustomer.Location = new System.Drawing.Point(35, 45);
            this.labelidcustomer.Name = "labelidcustomer";
            this.labelidcustomer.Size = new System.Drawing.Size(96, 20);
            this.labelidcustomer.TabIndex = 18;
            this.labelidcustomer.Text = "Id Customer";
            // 
            // buttonaddnew
            // 
            this.buttonaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddnew.Location = new System.Drawing.Point(673, 134);
            this.buttonaddnew.Name = "buttonaddnew";
            this.buttonaddnew.Size = new System.Drawing.Size(125, 46);
            this.buttonaddnew.TabIndex = 17;
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
            this.buttondelete.TabIndex = 16;
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
            this.buttonexit.TabIndex = 15;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // datagridviewcustomer
            // 
            this.datagridviewcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagridviewcustomer.Location = new System.Drawing.Point(22, 134);
            this.datagridviewcustomer.Name = "datagridviewcustomer";
            this.datagridviewcustomer.Size = new System.Drawing.Size(633, 272);
            this.datagridviewcustomer.TabIndex = 14;
            this.datagridviewcustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewcustomer_CellClick);
            this.datagridviewcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewcustomer_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_customer";
            this.Column1.HeaderText = "Id Customer";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_pelanggan";
            this.Column2.HeaderText = "Id Pelanggan";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nama";
            this.Column3.HeaderText = "Nama";
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
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(673, 186);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(125, 46);
            this.buttonupdate.TabIndex = 55;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.kotatext);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.labelkota);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.idpelanggantext);
            this.Controls.Add(this.idcustomertext);
            this.Controls.Add(this.labelidpelanggan);
            this.Controls.Add(this.labelidcustomer);
            this.Controls.Add(this.buttonaddnew);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.datagridviewcustomer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(820, 450);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kotatext;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.Label labelkota;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.TextBox idpelanggantext;
        private System.Windows.Forms.TextBox idcustomertext;
        private System.Windows.Forms.Label labelidpelanggan;
        private System.Windows.Forms.Label labelidcustomer;
        private System.Windows.Forms.Button buttonaddnew;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView datagridviewcustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonupdate;
    }
}
