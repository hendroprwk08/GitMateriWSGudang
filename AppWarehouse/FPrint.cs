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
    public partial class FPrint : Form
    {
        public FPrint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cr = crystalReportViewer1;

            if (cb_jenis.SelectedIndex == 0){
                CRRak report = new CRRak();
                report.RecordSelectionFormula = "{rak.id_rak} >= '" + cb_filter_1.SelectedValue.ToString() + "' and "
                                                + "{rak.id_rak} <= '" + cb_filter_2.SelectedValue.ToString() + "'";
                cr.ReportSource = report;               
            }else{
                CRBarang report = new CRBarang();
                report.RecordSelectionFormula = "{barang.id_barang} >= '" + cb_filter_1.SelectedValue.ToString() + "' and  "
                                                + "{barang.id_barang} <= '" + cb_filter_2.SelectedValue.ToString() + "'";
                cr.ReportSource = report;   
            }

            cr.RefreshReport();
        }

        private void FPrint_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //manual
            cb_jenis.Items.Add("Rak");
            cb_jenis.Items.Add("Barang");
        }

        void loadBarang() {
            try
            {
                String sql = "select * from barang order by id_barang asc";
                DBClass db = new DBClass();

                DataTable dt = new DataTable();
                dt = db.read(sql);

                cb_filter_1.DataSource = new BindingSource(dt, null);
                cb_filter_1.DisplayMember = "barang"; //kolom harus sesuai dengan tabel
                cb_filter_1.ValueMember = "id_barang";

                cb_filter_2.DataSource = new BindingSource(dt, null);
                cb_filter_2.DisplayMember = "barang"; //kolom harus sesuai dengan tabel
                cb_filter_2.ValueMember = "id_barang";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }    
        }

        void loadRak() {
            try
            {
                String sql = "select * from rak order by id_rak asc";
                DBClass db = new DBClass();

                DataTable dt = new DataTable();
                dt = db.read(sql);

                cb_filter_1.DataSource = new BindingSource(dt, null);
                cb_filter_1.DisplayMember = "rak"; //kolom harus sesuai dengan tabel
                cb_filter_1.ValueMember = "id_rak";

                cb_filter_2.DataSource = new BindingSource(dt, null);
                cb_filter_2.DisplayMember = "rak"; //kolom harus sesuai dengan tabel
                cb_filter_2.ValueMember = "id_rak";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }        
        }

        private void cb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_jenis.SelectedIndex == 0)
            {
                loadRak();
            }
            else 
            {
                loadBarang();
            }
        }
    }
}
