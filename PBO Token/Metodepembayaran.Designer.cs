namespace PBO_Token
{
    partial class Metodepembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metodepembayaran));
            this.diskontext = new System.Windows.Forms.TextBox();
            this.pajaktext = new System.Windows.Forms.TextBox();
            this.labeldiskon = new System.Windows.Forms.Label();
            this.labelpajak = new System.Windows.Forms.Label();
            this.namatext = new System.Windows.Forms.TextBox();
            this.metodetext = new System.Windows.Forms.TextBox();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelmetode = new System.Windows.Forms.Label();
            this.buttonaddnew = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.datametode = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.idmetodetext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datametode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // diskontext
            // 
            this.diskontext.Location = new System.Drawing.Point(513, 93);
            this.diskontext.Name = "diskontext";
            this.diskontext.Size = new System.Drawing.Size(189, 20);
            this.diskontext.TabIndex = 49;
            // 
            // pajaktext
            // 
            this.pajaktext.Location = new System.Drawing.Point(513, 45);
            this.pajaktext.Name = "pajaktext";
            this.pajaktext.Size = new System.Drawing.Size(189, 20);
            this.pajaktext.TabIndex = 48;
            // 
            // labeldiskon
            // 
            this.labeldiskon.AutoSize = true;
            this.labeldiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiskon.Location = new System.Drawing.Point(436, 93);
            this.labeldiskon.Name = "labeldiskon";
            this.labeldiskon.Size = new System.Drawing.Size(58, 20);
            this.labeldiskon.TabIndex = 47;
            this.labeldiskon.Text = "Diskon";
            // 
            // labelpajak
            // 
            this.labelpajak.AutoSize = true;
            this.labelpajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpajak.Location = new System.Drawing.Point(436, 45);
            this.labelpajak.Name = "labelpajak";
            this.labelpajak.Size = new System.Drawing.Size(48, 20);
            this.labelpajak.TabIndex = 46;
            this.labelpajak.Text = "Pajak";
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(158, 93);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(189, 20);
            this.namatext.TabIndex = 45;
            // 
            // metodetext
            // 
            this.metodetext.Location = new System.Drawing.Point(158, 45);
            this.metodetext.Name = "metodetext";
            this.metodetext.Size = new System.Drawing.Size(189, 20);
            this.metodetext.TabIndex = 44;
            this.metodetext.TextChanged += new System.EventHandler(this.nline);
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnama.Location = new System.Drawing.Point(35, 93);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(51, 20);
            this.labelnama.TabIndex = 43;
            this.labelnama.Text = "Nama";
            // 
            // labelmetode
            // 
            this.labelmetode.AutoSize = true;
            this.labelmetode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmetode.Location = new System.Drawing.Point(35, 45);
            this.labelmetode.Name = "labelmetode";
            this.labelmetode.Size = new System.Drawing.Size(63, 20);
            this.labelmetode.TabIndex = 42;
            this.labelmetode.Text = "Metode";
            // 
            // buttonaddnew
            // 
            this.buttonaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddnew.Location = new System.Drawing.Point(673, 134);
            this.buttonaddnew.Name = "buttonaddnew";
            this.buttonaddnew.Size = new System.Drawing.Size(125, 46);
            this.buttonaddnew.TabIndex = 41;
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
            this.buttondelete.TabIndex = 40;
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
            this.buttonexit.TabIndex = 39;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // datametode
            // 
            this.datametode.AllowUserToDeleteRows = false;
            this.datametode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datametode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datametode.Location = new System.Drawing.Point(22, 134);
            this.datametode.Name = "datametode";
            this.datametode.ReadOnly = true;
            this.datametode.Size = new System.Drawing.Size(633, 272);
            this.datametode.TabIndex = 38;
            this.datametode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datametode_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_metode";
            this.Column5.HeaderText = "Id Metode";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "metode";
            this.Column1.HeaderText = "Metode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama";
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pajak";
            this.Column3.HeaderText = "Pajak";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diskon";
            this.Column4.HeaderText = "Diskon";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 450);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(673, 186);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(125, 46);
            this.buttonupdate.TabIndex = 51;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // idmetodetext
            // 
            this.idmetodetext.Location = new System.Drawing.Point(455, 281);
            this.idmetodetext.Name = "idmetodetext";
            this.idmetodetext.Size = new System.Drawing.Size(10, 20);
            this.idmetodetext.TabIndex = 52;
            // 
            // Metodepembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.diskontext);
            this.Controls.Add(this.pajaktext);
            this.Controls.Add(this.labeldiskon);
            this.Controls.Add(this.labelpajak);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.metodetext);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.labelmetode);
            this.Controls.Add(this.buttonaddnew);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.datametode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.idmetodetext);
            this.Name = "Metodepembayaran";
            this.Size = new System.Drawing.Size(820, 450);
            ((System.ComponentModel.ISupportInitialize)(this.datametode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diskontext;
        private System.Windows.Forms.TextBox pajaktext;
        private System.Windows.Forms.Label labeldiskon;
        private System.Windows.Forms.Label labelpajak;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.TextBox metodetext;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelmetode;
        private System.Windows.Forms.Button buttonaddnew;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView datametode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.TextBox idmetodetext;
    }
}
