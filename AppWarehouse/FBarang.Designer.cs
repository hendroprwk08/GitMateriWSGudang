namespace AppWarehouse
{
    partial class FBarang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tambahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBarang = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxJenis = new System.Windows.Forms.ComboBox();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.tbMerek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRak = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem,
            this.simpanToolStripMenuItem,
            this.hapusToolStripMenuItem,
            this.toolStripTextBox1,
            this.cariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tambahToolStripMenuItem
            // 
            this.tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            this.tambahToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.tambahToolStripMenuItem.Text = "Tambah";
            this.tambahToolStripMenuItem.Click += new System.EventHandler(this.tambahToolStripMenuItem_Click);
            // 
            // simpanToolStripMenuItem
            // 
            this.simpanToolStripMenuItem.Name = "simpanToolStripMenuItem";
            this.simpanToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.simpanToolStripMenuItem.Text = "Simpan";
            this.simpanToolStripMenuItem.Click += new System.EventHandler(this.simpanToolStripMenuItem_Click);
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.hapusToolStripMenuItem.Text = "Hapus";
            this.hapusToolStripMenuItem.Click += new System.EventHandler(this.hapusToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.cariToolStripMenuItem.Text = "Cari";
            this.cariToolStripMenuItem.Click += new System.EventHandler(this.cariToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 168);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(486, 141);
            this.dgv.TabIndex = 15;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(85, 108);
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(68, 20);
            this.nudStok.TabIndex = 14;
            this.nudStok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok";
            // 
            // tbBarang
            // 
            this.tbBarang.Location = new System.Drawing.Point(85, 80);
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(216, 20);
            this.tbBarang.TabIndex = 12;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(85, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Barang";
            // 
            // cbxJenis
            // 
            this.cbxJenis.FormattingEnabled = true;
            this.cbxJenis.Items.AddRange(new object[] {
            "Makanan",
            "Minuman",
            "Bahan Pokok",
            "Perawatan Tubuh",
            "Perkakas",
            "Perabot"});
            this.cbxJenis.Location = new System.Drawing.Point(384, 53);
            this.cbxJenis.Name = "cbxJenis";
            this.cbxJenis.Size = new System.Drawing.Size(121, 21);
            this.cbxJenis.TabIndex = 16;
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.CustomFormat = "dd-MM-yyyy";
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiredDate.Location = new System.Drawing.Point(384, 134);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(121, 20);
            this.dtpExpiredDate.TabIndex = 17;
            // 
            // tbMerek
            // 
            this.tbMerek.Location = new System.Drawing.Point(85, 134);
            this.tbMerek.Name = "tbMerek";
            this.tbMerek.Size = new System.Drawing.Size(100, 20);
            this.tbMerek.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Merek";
            // 
            // tbSeri
            // 
            this.tbSeri.Location = new System.Drawing.Point(222, 134);
            this.tbSeri.Name = "tbSeri";
            this.tbSeri.Size = new System.Drawing.Size(79, 20);
            this.tbSeri.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Seri";
            // 
            // cbxRak
            // 
            this.cbxRak.FormattingEnabled = true;
            this.cbxRak.Location = new System.Drawing.Point(384, 80);
            this.cbxRak.Name = "cbxRak";
            this.cbxRak.Size = new System.Drawing.Size(121, 21);
            this.cbxRak.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Jenis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rak";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Exp Date";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(384, 108);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(121, 20);
            this.tbHarga.TabIndex = 24;
            // 
            // FBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 321);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxRak);
            this.Controls.Add(this.tbSeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMerek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExpiredDate);
            this.Controls.Add(this.cbxJenis);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBarang);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBarang";
            this.Load += new System.EventHandler(this.FBarang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tambahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBarang;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxJenis;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.TextBox tbMerek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHarga;

    }
}