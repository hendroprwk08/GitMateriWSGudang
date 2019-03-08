using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWarehouse
{
    public partial class FBarang : Form
    {
        String sql;
 
        public FBarang()
        {
            InitializeComponent();
        }

        private void FBarang_Load(object sender, EventArgs e)
        {
            showGrid();
            loadRak();
        }

        private void loadRak()
        {
            try
            {
                String sql = "select * from rak order by id_rak desc";
                DBClass db = new DBClass();

                DataTable dt = new DataTable();
                dt = db.read(sql);

                cbxRak.DataSource = new BindingSource(dt, null);
                cbxRak.DisplayMember = "rak"; //kolom harus sesuai dengan tabel
                cbxRak.ValueMember = "id_rak";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbID.ReadOnly = false;

            tbBarang.Text = "";
            tbHarga.Text = "";
            tbMerek.Text = "";
            tbSeri.Text = "";
            nudStok.Value = 0;
            cbxJenis.SelectedIndex = -1;
            cbxRak.SelectedIndex = 0; //karena sudah berisi data dari rak
        }

        private void simpanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double harga = double.Parse(tbHarga.Text);

                if (tbID.ReadOnly == false)
                {                  
                    //khusus rak, yang diambil ID (value member)-nya, bukan Text (Display Member)-nya 
                    String id_rak = cbxRak.SelectedValue.ToString();
 
                    sql = "insert into barang values ('" + tbID.Text + "', '" + tbBarang.Text + "', "
                            + "" + nudStok .Value + ", '"+ tbMerek.Text +"', '"+ tbSeri.Text +"', "
                            + "'" + cbxJenis.Text + "',  '" + id_rak + "', "+ harga +", '"+ dtpExpiredDate.Value +"')";
                }
                else
                {
                    sql = "update barang set barang = '" + tbBarang.Text + "',  stok = " + nudStok.Value + ", "
                            + "merek = '" + tbMerek.Text + "', seri = '" + tbSeri.Text + "', jenis = '" + cbxJenis.Text + "', "
                            + "id_rak =  '" + cbxRak.ValueMember.ToString() + "', harga = " + harga + ", "
                            + "expired_date = '" + dtpExpiredDate.Value + "' where id_barang = '" + tbID.Text + "'";                           
                }

                DBClass db = new DBClass(); //panggil class DB
                db.execute(sql);

                showGrid();
                tambahToolStripMenuItem_Click(null, null); //panggil tombol tambah
                MessageBox.Show(tbBarang.Text + " tersimpan"); //message box
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void showGrid()
        {
            try
            {
                String sql = "select * from barang order by id_barang desc";
                DBClass db = new DBClass(); //panggil class DB
                dgv.DataSource = db.read(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;

            try
            {
                tbID.Text = dgv.Rows[i].Cells[0].Value.ToString();
                tbID.ReadOnly = false;
                tbBarang.Text = dgv.Rows[i].Cells[1].Value.ToString();
                nudStok.Value = Int32.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                tbMerek.Text = dgv.Rows[i].Cells[3].Value.ToString();
                tbSeri.Text = dgv.Rows[i].Cells[4].Value.ToString();
                cbxJenis.Text = dgv.Rows[i].Cells[5].Value.ToString();
                cbxRak.SelectedValue = dgv.Rows[i].Cells[6].Value.ToString();

                //buang 5 digit terakhir
                tbHarga.Text = dgv.Rows[i].Cells[7].Value.ToString().Remove(dgv.Rows[i].Cells[7].Value.ToString().Length-5);
                
                //konversi ke format tanggal
                dtpExpiredDate.Value = DateTime.Parse(dgv.Rows[i].Cells[8].Value.ToString());
               
                tbID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void hapusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.ReadOnly == true)
                {
                    DialogResult res = MessageBox.Show("Hapus " + tbBarang.Text + "?", "Perhatian", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (res == DialogResult.OK)
                    {
                        sql = "delete from barang where id_barang = '" + tbID.Text + "'";

                        DBClass db = new DBClass(); //panggil class DB
                        db.execute(sql);

                        showGrid();
                        MessageBox.Show(tbBarang.Text + " dihapus");
                        tambahToolStripMenuItem_Click(null, null);

                    }
                    else if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Penghapusan data " + tbBarang.Text + " dibatalkan");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "select * from barang where barang like '%" + toolStripTextBox1.Text + "%' order by id_barang desc";
                DBClass db = new DBClass(); //panggil class DB
                dgv.DataSource = db.read(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
