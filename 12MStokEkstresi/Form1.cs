using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace _12MStokEkstresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MO5HLC4\\SQLEXPRESS;Initial catalog=Test;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // sayfa açıldığında otomatik olarak startDate ve endDate datepicker leri false yapıyoruz
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;

           
            cb_Seciniz.Items.Add("10081 SİEMENS");
            cb_Seciniz.Items.Add("10082 SİEMENS");
            cb_Seciniz.Items.Add("10083 SİEMENS");
            cb_Seciniz.Items.Add("10084 SİEMENS");
            cb_Seciniz.Items.Add("10085 SİEMENS");
            cb_Seciniz.Items.Add("10086 SİEMENS");
            cb_Seciniz.Items.Add("10087 SİEMENS");
            cb_Seciniz.Items.Add("10088 SİEMENS");
            cb_Seciniz.Items.Add("10089 SİEMENS");
            cb_Seciniz.Items.Add("10090 SİEMENS");
            cb_Seciniz.Items.Add("10091 SİEMENS");

            cb_Seciniz.SelectedIndex = 0;

          

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MO5HLC4\\SQLEXPRESS;Initial catalog=Test;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

           

            SqlBaglanti serverAccess = new SqlBaglanti();
            int bitisTarihi = Convert.ToInt32((new DateTime(this.dateTimePicker2.Value.Year, this.dateTimePicker2.Value.Month, this.dateTimePicker2.Value.Day, this.dateTimePicker2.Value.Hour, this.dateTimePicker2.Value.Minute, this.dateTimePicker2.Value.Second)).ToOADate());
            int baslangicTarihi = Convert.ToInt32((new DateTime(this.dateTimePicker1.Value.Year, this.dateTimePicker1.Value.Month, this.dateTimePicker1.Value.Day, this.dateTimePicker1.Value.Hour, this.dateTimePicker1.Value.Minute, this.dateTimePicker1.Value.Second)).ToOADate());


            List<STI> sorgu = serverAccess.GetAll(cb_Seciniz.Text, baslangicTarihi, bitisTarihi);
            for (int i = 0; i < sorgu.Count; i++)
            {




                dt_VeriAktar.Rows.Add();
                dt_VeriAktar.Rows[i].Cells[0].Value = sorgu[i].SiraNumarasi;
                dt_VeriAktar.Rows[i].Cells[1].Value = sorgu[i].IslemTuru;
                dt_VeriAktar.Rows[i].Cells[2].Value = sorgu[i].EvrakNumarasi;
                dt_VeriAktar.Rows[i].Cells[3].Value = sorgu[i].Tarihi;
                dt_VeriAktar.Rows[i].Cells[4].Value = sorgu[i].GirisAdedi;
                dt_VeriAktar.Rows[i].Cells[5].Value = sorgu[i].CikisAdedi;
                dt_VeriAktar.Rows[i].Cells[6].Value = sorgu[i].StokAdedi;




            }




        }

        private void dt_VeriAktar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Csv_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < dt_VeriAktar.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dt_VeriAktar.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dt_VeriAktar.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dt_VeriAktar.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt_VeriAktar.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}



