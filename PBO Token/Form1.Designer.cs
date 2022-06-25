namespace PBO_Token
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BG1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonmetodepembayaran = new System.Windows.Forms.Button();
            this.buttonsupplier = new System.Windows.Forms.Button();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.buttonproduk = new System.Windows.Forms.Button();
            this.buttoncustomer = new System.Windows.Forms.Button();
            this.labelutama = new System.Windows.Forms.Label();
            this.BG2 = new System.Windows.Forms.Panel();
            this.BG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BG1
            // 
            this.BG1.BackColor = System.Drawing.SystemColors.Highlight;
            this.BG1.Controls.Add(this.button1);
            this.BG1.Controls.Add(this.pictureBox1);
            this.BG1.Controls.Add(this.buttonmetodepembayaran);
            this.BG1.Controls.Add(this.buttonsupplier);
            this.BG1.Controls.Add(this.buttonadmin);
            this.BG1.Controls.Add(this.buttonproduk);
            this.BG1.Controls.Add(this.buttoncustomer);
            this.BG1.Controls.Add(this.labelutama);
            this.BG1.Location = new System.Drawing.Point(0, 1);
            this.BG1.Name = "BG1";
            this.BG1.Size = new System.Drawing.Size(168, 449);
            this.BG1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 22;
            this.button1.Text = "Transaksi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonmetodepembayaran
            // 
            this.buttonmetodepembayaran.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonmetodepembayaran.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmetodepembayaran.Location = new System.Drawing.Point(23, 317);
            this.buttonmetodepembayaran.Name = "buttonmetodepembayaran";
            this.buttonmetodepembayaran.Size = new System.Drawing.Size(121, 53);
            this.buttonmetodepembayaran.TabIndex = 7;
            this.buttonmetodepembayaran.Text = "Metode\r\nPembayaran\r\n";
            this.buttonmetodepembayaran.UseVisualStyleBackColor = false;
            this.buttonmetodepembayaran.Click += new System.EventHandler(this.buttonmetodepembayaran_Click);
            // 
            // buttonsupplier
            // 
            this.buttonsupplier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonsupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupplier.Location = new System.Drawing.Point(23, 258);
            this.buttonsupplier.Name = "buttonsupplier";
            this.buttonsupplier.Size = new System.Drawing.Size(121, 53);
            this.buttonsupplier.TabIndex = 8;
            this.buttonsupplier.Text = "Supplier";
            this.buttonsupplier.UseVisualStyleBackColor = false;
            this.buttonsupplier.Click += new System.EventHandler(this.buttonsupplier_Click);
            // 
            // buttonadmin
            // 
            this.buttonadmin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonadmin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadmin.Location = new System.Drawing.Point(23, 140);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(121, 53);
            this.buttonadmin.TabIndex = 6;
            this.buttonadmin.Text = "Admin";
            this.buttonadmin.UseVisualStyleBackColor = false;
            this.buttonadmin.Click += new System.EventHandler(this.buttonadmin_Click);
            // 
            // buttonproduk
            // 
            this.buttonproduk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonproduk.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonproduk.Location = new System.Drawing.Point(23, 199);
            this.buttonproduk.Name = "buttonproduk";
            this.buttonproduk.Size = new System.Drawing.Size(121, 53);
            this.buttonproduk.TabIndex = 5;
            this.buttonproduk.Text = "Produk";
            this.buttonproduk.UseVisualStyleBackColor = false;
            this.buttonproduk.Click += new System.EventHandler(this.buttonproduk_Click);
            // 
            // buttoncustomer
            // 
            this.buttoncustomer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttoncustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncustomer.Location = new System.Drawing.Point(23, 84);
            this.buttoncustomer.Name = "buttoncustomer";
            this.buttoncustomer.Size = new System.Drawing.Size(121, 50);
            this.buttoncustomer.TabIndex = 4;
            this.buttoncustomer.Text = "Customer";
            this.buttoncustomer.UseVisualStyleBackColor = false;
            this.buttoncustomer.Click += new System.EventHandler(this.buttoncustomer_Click);
            // 
            // labelutama
            // 
            this.labelutama.AutoSize = true;
            this.labelutama.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelutama.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelutama.Location = new System.Drawing.Point(90, 20);
            this.labelutama.Name = "labelutama";
            this.labelutama.Size = new System.Drawing.Size(68, 44);
            this.labelutama.TabIndex = 2;
            this.labelutama.Text = "Fast\r\nToken\r\n";
            // 
            // BG2
            // 
            this.BG2.BackColor = System.Drawing.SystemColors.Highlight;
            this.BG2.Location = new System.Drawing.Point(987, 1);
            this.BG2.Name = "BG2";
            this.BG2.Size = new System.Drawing.Size(47, 449);
            this.BG2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.BG2);
            this.Controls.Add(this.BG1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BG1.ResumeLayout(false);
            this.BG1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BG1;
        private System.Windows.Forms.Label labelutama;
        private System.Windows.Forms.Button buttoncustomer;
        private System.Windows.Forms.Button buttonproduk;
        private System.Windows.Forms.Button buttonadmin;
        private System.Windows.Forms.Button buttonsupplier;
        private System.Windows.Forms.Button buttonmetodepembayaran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BG2;
        private System.Windows.Forms.Button button1;
    }
}

