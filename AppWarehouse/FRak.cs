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
    public partial class FRak : Form
    {
        String sql;

        public FRak()
        {
            InitializeComponent();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbID.ReadOnly = false;
            tbRak.Text = ""; 
            nudBaris.Value = 1;
        }

        private void simpanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.ReadOnly == false) {
                    sql = "insert into rak values ('" + tbID.Text + "', " +
                            "'" + tbRak.Text + "', " + nudBaris.Value + ")";                    
                }else{
                    sql = "update rak set rak = '" + tbRak.Text + "', baris = " + nudBaris.Value + " " +
                            "where id_rak = '" + tbID.Text + "'";  
                }

                DBClass db = new DBClass(); //panggil class DB
                db.execute(sql);

                showGrid();
                tambahToolStripMenuItem_Click(null, null); //panggil tombol tambah
                MessageBox.Show(tbRak.Text + " tersimpan"); //message box
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showGrid();
        }

        private void showGrid()
        {
            try
            {
                String sql = "select * from rak order by id_rak desc";
                DBClass db = new DBClass(); 
                dgv.DataSource = db.read(sql); //set datagridview
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
                tbRak.Text = dgv.Rows[i].Cells[1].Value.ToString();
                nudBaris.Value = Int32.Parse(dgv.Rows[i].Cells[2].Value.ToString());

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
                    DialogResult res = MessageBox.Show("Hapus "+ tbRak.Text + "?", 
                                                        "Perhatian", 
                                                        MessageBoxButtons.OKCancel, 
                                                        MessageBoxIcon.Information);
                    
                    if (res == DialogResult.OK)
                    {
                        sql = "delete from rak where id_rak = '" + tbID.Text + "'"; 
                        
                        DBClass db = new DBClass(); //panggil class DB
                        db.execute(sql);        
                        
                        showGrid();
                        MessageBox.Show(tbRak.Text + " dihapus");
                        tambahToolStripMenuItem_Click(null, null);                         
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Penghapusan data " + tbRak.Text + " dibatalkan"); 
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
                String sql = "select * from rak where rak " + 
                                "like '%" + toolStripTextBox1.Text + "%' " +
                                "order by id_rak desc";

                DBClass db = new DBClass();
                dgv.DataSource = db.read(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
