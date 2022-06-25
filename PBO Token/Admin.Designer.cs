namespace PBO_Token
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.kotatext = new System.Windows.Forms.TextBox();
            this.alamattext = new System.Windows.Forms.TextBox();
            this.labelkota = new System.Windows.Forms.Label();
            this.labelalamat = new System.Windows.Forms.Label();
            this.namatext = new System.Windows.Forms.TextBox();
            this.idadmintext = new System.Windows.Forms.TextBox();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelidadmin = new System.Windows.Forms.Label();
            this.buttonaddnew = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.datagridviewadmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kotatext
            // 
            this.kotatext.Location = new System.Drawing.Point(513, 93);
            this.kotatext.Name = "kotatext";
            this.kotatext.Size = new System.Drawing.Size(189, 20);
            this.kotatext.TabIndex = 37;
            this.kotatext.TextChanged += new System.EventHandler(this.kotatext_TextChanged);
            // 
            // alamattext
            // 
            this.alamattext.Location = new System.Drawing.Point(513, 45);
            this.alamattext.Name = "alamattext";
            this.alamattext.Size = new System.Drawing.Size(189, 20);
            this.alamattext.TabIndex = 36;
            this.alamattext.TextChanged += new System.EventHandler(this.alamattext_TextChanged);
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
            this.labelkota.Click += new System.EventHandler(this.labelkota_Click);
            // 
            // labelalamat
            // 
            this.labelalamat.AutoSize = true;
            this.labelalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelalamat.Location = new System.Drawing.Point(436, 45);
            this.labelalamat.Name = "labelalamat";
            this.labelalamat.Size = new System.Drawing.Size(59, 20);
            this.labelalamat.TabIndex = 34;
            this.labelalamat.Text = "Alamat";
            this.labelalamat.Click += new System.EventHandler(this.labelalamat_Click);
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(158, 93);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(189, 20);
            this.namatext.TabIndex = 33;
            this.namatext.TextChanged += new System.EventHandler(this.namatext_TextChanged);
            // 
            // idadmintext
            // 
            this.idadmintext.Location = new System.Drawing.Point(158, 45);
            this.idadmintext.Name = "idadmintext";
            this.idadmintext.Size = new System.Drawing.Size(189, 20);
            this.idadmintext.TabIndex = 32;
            this.idadmintext.TextChanged += new System.EventHandler(this.idadmintext_TextChanged);
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnama.Location = new System.Drawing.Point(35, 93);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(51, 20);
            this.labelnama.TabIndex = 31;
            this.labelnama.Text = "Nama";
            this.labelnama.Click += new System.EventHandler(this.labelnama_Click);
            // 
            // labelidadmin
            // 
            this.labelidadmin.AutoSize = true;
            this.labelidadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidadmin.Location = new System.Drawing.Point(35, 45);
            this.labelidadmin.Name = "labelidadmin";
            this.labelidadmin.Size = new System.Drawing.Size(72, 20);
            this.labelidadmin.TabIndex = 30;
            this.labelidadmin.Text = "Id Admin";
            this.labelidadmin.Click += new System.EventHandler(this.labelidadmin_Click);
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
            // datagridviewadmin
            // 
            this.datagridviewadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewadmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datagridviewadmin.Location = new System.Drawing.Point(22, 134);
            this.datagridviewadmin.Name = "datagridviewadmin";
            this.datagridviewadmin.Size = new System.Drawing.Size(633, 272);
            this.datagridviewadmin.TabIndex = 26;
            this.datagridviewadmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewadmin_CellClick);
            this.datagridviewadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewadmin_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_admin";
            this.Column1.HeaderText = "Id Admin";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama";
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "alamat";
            this.Column3.HeaderText = "Alamat";
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
            this.buttonupdate.TabIndex = 54;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.kotatext);
            this.Controls.Add(this.alamattext);
            this.Controls.Add(this.labelkota);
            this.Controls.Add(this.labelalamat);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.idadmintext);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.labelidadmin);
            this.Controls.Add(this.buttonaddnew);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.datagridviewadmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(820, 450);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kotatext;
        private System.Windows.Forms.TextBox alamattext;
        private System.Windows.Forms.Label labelkota;
        private System.Windows.Forms.Label labelalamat;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.TextBox idadmintext;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelidadmin;
        private System.Windows.Forms.Button buttonaddnew;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView datagridviewadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonupdate;
    }
}
