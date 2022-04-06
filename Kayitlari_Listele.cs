using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paket_Barkod_Kontrol
{
    public partial class Kayitlari_Listele : Form
    {
        public Kayitlari_Listele()
        {
            InitializeComponent();

            Tum_Database_Goruntule();
        }

        private void Tum_Database_Goruntule()
        {
            using (var db = new Meter_PackageContext())
            {
                var data = db.packages.AsQueryable();
                dataGridView1.DataSource = data.ToList();
            }
            label_info.Text = "Tüm Kayıtlar Gösteriliyor";
        }

        private void btn_sayac_no_ara_Click(object sender, EventArgs e)
        {
            if ((tb_sayac_no_baslangic.Text.Length > 0) && (tb_sayac_no_bitis.Text.Length > 0))
            {
                using (var db = new Meter_PackageContext())
                {
                    var data = db.packages.AsQueryable();
                    data = data.Where(x => x.Meter_ID.CompareTo(tb_sayac_no_baslangic.Text) >= 0 && x.Meter_ID.CompareTo(tb_sayac_no_bitis.Text) <= 0);
                    dataGridView1.DataSource = data.ToList();
                }
                label_info.Text = tb_sayac_no_baslangic.Text + " - " + tb_sayac_no_bitis.Text + "  Aralığındaki Kayıtlar Gösteriliyor";
            }
            else
            {
                Tum_Database_Goruntule();
            }
        }

        private void btn_tarih_ara_Click(object sender, EventArgs e)
        {
            using (var db = new Meter_PackageContext())
            {
                var data = db.packages.AsQueryable();
                data = data.Where(x => x.Packing_Date > dateTimePicker_baslangic.Value && x.Packing_Date < dateTimePicker_bitis.Value);
                dataGridView1.DataSource = data.ToList();

                label_info.Text = dateTimePicker_baslangic.Value + " - " + dateTimePicker_bitis.Value + "  Aralığındaki Kayıtlar Gösteriliyor";
            }
        }

        private void btn_kutu_no_ara_Click(object sender, EventArgs e)
        {
            if ((tb_kutu_no_baslangic.Text.Length > 0) && (tb_kutu_no_bitis.Text.Length > 0))
            {
                using (var db = new Meter_PackageContext())
                {
                    var data = db.packages.AsQueryable();
                    data = data.Where(x => x.Package_Code.CompareTo(tb_kutu_no_baslangic.Text) >= 0 && x.Package_Code.CompareTo(tb_kutu_no_bitis.Text) <= 0);
                    dataGridView1.DataSource = data.ToList();
                }
                label_info.Text = tb_kutu_no_baslangic.Text + " - " + tb_kutu_no_bitis.Text + "  Aralığındaki Kayıtlar Gösteriliyor";
            }
            else
            {
                Tum_Database_Goruntule();
            }
        }

        private void btn_model_ara_Click(object sender, EventArgs e)
        {
            if (tb_model.Text.Length > 0)
            {
                using (var db = new Meter_PackageContext())
                {
                    var data = db.packages.AsQueryable();
                    data = data.Where(x => x.Product_Code == tb_model.Text);
                    dataGridView1.DataSource = data.ToList();
                }
                label_info.Text = tb_model.Text + " Kodlu Kayıtlar Gösteriliyor";
            }
            else
            {
                MessageBox.Show("Lütfen model kodunu tam olarak giriniz");
            }
        }
    }
}
