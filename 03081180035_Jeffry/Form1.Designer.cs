namespace _03081180035_Jeffry
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.btnBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxNomor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBest = new System.Windows.Forms.DataGridView();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(271, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(24, 59);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(100, 20);
            this.nudJumlah.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(24, 116);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 39);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambahkan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(439, 147);
            this.dgvPesanan.MultiSelect = false;
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.ReadOnly = true;
            this.dgvPesanan.Size = new System.Drawing.Size(243, 191);
            this.dgvPesanan.TabIndex = 5;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Red;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(573, 379);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(109, 43);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.btnTambah);
            this.grpbxPesan.Controls.Add(this.nudJumlah);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(271, 246);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 176);
            this.grpbxPesan.TabIndex = 7;
            this.grpbxPesan.TabStop = false;
            this.grpbxPesan.Text = "Pesanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nomor Meja";
            // 
            // cmbbxNomor
            // 
            this.cmbbxNomor.FormattingEnabled = true;
            this.cmbbxNomor.Location = new System.Drawing.Point(139, 17);
            this.cmbbxNomor.Name = "cmbbxNomor";
            this.cmbbxNomor.Size = new System.Drawing.Size(52, 21);
            this.cmbbxNomor.TabIndex = 8;
            this.cmbbxNomor.SelectedIndexChanged += new System.EventHandler(this.cmbbxNomor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Top 3 Best Seller";
            // 
            // dgvBest
            // 
            this.dgvBest.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgvBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBest.Location = new System.Drawing.Point(439, 42);
            this.dgvBest.MultiSelect = false;
            this.dgvBest.Name = "dgvBest";
            this.dgvBest.ReadOnly = true;
            this.dgvBest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBest.Size = new System.Drawing.Size(243, 90);
            this.dgvBest.TabIndex = 11;
            this.dgvBest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBest_CellClick);
            // 
            // dgvMenu
            // 
            this.dgvMenu.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(12, 90);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(242, 332);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Harga :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(544, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 17);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(693, 434);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.dgvBest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbbxNomor);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxNomor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBest;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}

