namespace PBO_Token
{
    partial class transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaksi));
            this.datatransaksi = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datatransaksi
            // 
            this.datatransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5,
            this.Column6});
            this.datatransaksi.Location = new System.Drawing.Point(46, 80);
            this.datatransaksi.Name = "datatransaksi";
            this.datatransaksi.Size = new System.Drawing.Size(720, 297);
            this.datatransaksi.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 450);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(664, 383);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(102, 39);
            this.buttonexit.TabIndex = 41;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_transaksi";
            this.Column1.HeaderText = "Id Transaksi";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id_produk";
            this.Column7.HeaderText = "Id Produk";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id_supplier";
            this.Column4.HeaderText = "Id Supplier";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_pembayaran";
            this.Column3.HeaderText = "Id Pembayaran";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_customer";
            this.Column2.HeaderText = "Id Customer";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tanggal";
            this.Column5.HeaderText = "Tanggal";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "total_harga";
            this.Column6.HeaderText = "Total Harga";
            this.Column6.Name = "Column6";
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.datatransaksi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "transaksi";
            this.Size = new System.Drawing.Size(820, 450);
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datatransaksi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
