using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paket_Barkod_Kontrol
{

    public partial class Kayitlari_Listele : Form
    {

        public class Kayit_Data_Type
        {
            public string filename { get; set; }
            public string data { get; set; }
        }

        Kayit_Data_Type kayit = new Kayit_Data_Type();
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
            gridview_sira_no_ekleme_ve_headerlari_duzeltme();
        }

        private void gridview_sira_no_ekleme_ve_headerlari_duzeltme()
        {
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Sayı";
            dataGridView1.Columns[1].HeaderText = "Sayaç No";
            dataGridView1.Columns[2].HeaderText = "Kutudaki Sayaç Sayısı";
            dataGridView1.Columns[3].HeaderText = "Koli No";
            dataGridView1.Columns[4].HeaderText = "Model No";
            dataGridView1.Columns[5].HeaderText = "Kayıt Tarihi";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            dataGridView1.AutoResizeColumns();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Width += 20;
        }

//TODO: eksiklere göre aratma kısmı sayaç no ve koli no için ortak bir fonksiyonla yapılacak
        private void btn_sayac_no_ara_Click(object sender, EventArgs e)
        {
            if ((tb_sayac_no_baslangic.Text.Length > 0) && (tb_sayac_no_bitis.Text.Length > 0))
            {
                List<Package> _list;
                using (var db = new Meter_PackageContext())
                {
                    var data = db.packages.AsQueryable();
                    data = data.Where(x => x.Meter_ID.CompareTo(tb_sayac_no_baslangic.Text) >= 0 && x.Meter_ID.CompareTo(tb_sayac_no_bitis.Text) <= 0);
                    dataGridView1.DataSource = data.ToList();
                    _list = data.ToList();
                    gridview_sira_no_ekleme_ve_headerlari_duzeltme();
                }
                label_info.Text = tb_sayac_no_baslangic.Text + " - " + tb_sayac_no_bitis.Text + "  Aralığındaki Kayıtlar Gösteriliyor   |   Gösterilen Kayıt Sayısı: " + dataGridView1.Rows.Count.ToString();
                if (checkBox_eksikleri_goster.Checked)
                {
                    string sayac_no_bas_kismi;
                    long seri_no_baslangic, seri_no_bitis;
                    listBox_eksik_sayaclar.Items.Clear();
                    Split_String_And_Number(tb_sayac_no_baslangic.Text, out sayac_no_bas_kismi, out seri_no_baslangic);
                    Split_String_And_Number(tb_sayac_no_bitis.Text, out sayac_no_bas_kismi, out seri_no_bitis);
                    long eksik_sayac_sayisi = 0;
                    label_araliktaki_sayac_sayisi.Text = "Aralıktaki sayaç sayısı: " + (seri_no_bitis - seri_no_baslangic).ToString();
                    kayit.data = "";
                    kayit.filename = tb_sayac_no_baslangic.Text + "-" + tb_sayac_no_bitis.Text + "_Arasindaki_Eksik_Sayac_Kayitlari.csv";
                    for (long i = seri_no_baslangic; i < seri_no_bitis; i++)
                    {
                        List<Package> _result = _list.FindAll(x => x.Meter_ID == sayac_no_bas_kismi + i.ToString());
                        if (_result.Count == 0)
                        {
                            listBox_eksik_sayaclar.Items.Add(sayac_no_bas_kismi + i.ToString());
                            eksik_sayac_sayisi++;
                            kayit.data += eksik_sayac_sayisi.ToString() + ";" + sayac_no_bas_kismi + i.ToString() + Environment.NewLine;
                        }
                    }
                    panel_eksik_sayac_listele.Visible = true;
                    if (eksik_sayac_sayisi > 0)
                    {
                        panel_eksikleri_goster.Visible = true;
                        label_eksik_sayac_sayisi.Text = "Eksik Sayaç Sayısı: " + eksik_sayac_sayisi.ToString();
                    }
                    else
                    {
                        panel_eksik_sayac_yok.Visible = true;
                    }
                    label_info.Text += "  |  Eksik Sayaç Sayısı: " + eksik_sayac_sayisi.ToString();
                }
            }
            else
            {
                Tum_Database_Goruntule();
            }
        }

        private void Split_String_And_Number(string data, out string harflerden_onceki_data, out long harflerden_sonraki_data)
        {
            int harf_index = 0;
            string rakamlar = "0123456789";
            char[] data_char = data.ToCharArray();
            for (int i = data_char.Length - 1; i > 0; i--)
            {
                if (rakamlar.IndexOf(data_char[i]) != -1)
                {
                    harf_index++;
                }
                else
                    break;
            }
            harflerden_onceki_data = data.Substring(0, data.Length - harf_index);
            harflerden_sonraki_data = Convert.ToInt64(data.Substring(data.Length - harf_index, harf_index));
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
            gridview_sira_no_ekleme_ve_headerlari_duzeltme();
        }

        private void btn_kutu_no_ara_Click(object sender, EventArgs e)
        {
            List<Package> _list;
            if ((tb_kutu_no_baslangic.Text.Length > 0) && (tb_kutu_no_bitis.Text.Length > 0))
            {
                using (var db = new Meter_PackageContext())
                {
                    var data = db.packages.AsQueryable();
                    data = data.Where(x => x.Package_Code.CompareTo(tb_kutu_no_baslangic.Text) >= 0 && x.Package_Code.CompareTo(tb_kutu_no_bitis.Text) <= 0);
                    dataGridView1.DataSource = data.ToList();
                    _list = data.ToList();
                }
                label_info.Text = tb_kutu_no_baslangic.Text + " - " + tb_kutu_no_bitis.Text + "  Aralığındaki Kayıtlar Gösteriliyor";
                if (checkBox_eksikleri_goster_koli.Checked)
                {
                    string koli_no_bas_kismi;
                    long koli_no_baslangic, koli_no_bitis;
                    Split_String_And_Number(tb_kutu_no_baslangic.Text, out koli_no_bas_kismi, out koli_no_baslangic);
                    Split_String_And_Number(tb_kutu_no_bitis.Text, out koli_no_bas_kismi, out koli_no_bitis);
                    long eksik_koli_sayisi = 0;
                    if (checkBox_eksikleri_goster_koli.Checked)
                    {
                        listBox_eksik_sayaclar.Items.Clear();
                        label_araliktaki_sayac_sayisi.Text = "Aralıktaki koli sayısı: " + (koli_no_bitis - koli_no_baslangic).ToString();
                        kayit.data = "";
                        kayit.filename = tb_kutu_no_baslangic.Text + "-" + tb_kutu_no_bitis.Text + "_Arasindaki_Eksik_Koli_Kayitlari.csv";
                        for (long i = koli_no_baslangic; i <= koli_no_bitis; i++)
                        {
                            List<Package> _result = _list.FindAll(x => x.Package_Code == koli_no_bas_kismi + i.ToString());
                            if (_result.Count == 0)
                            {
                                listBox_eksik_sayaclar.Items.Add(koli_no_bas_kismi + i.ToString());
                                eksik_koli_sayisi++;
                                kayit.data += eksik_koli_sayisi.ToString() + ";" + koli_no_bas_kismi + i.ToString() + Environment.NewLine;
                            }
                        }
                        panel_eksik_sayac_listele.Visible = true;
                        if (eksik_koli_sayisi > 0)
                        {
                            panel_eksikleri_goster.Visible = true;
                            label_eksik_sayac_sayisi.Text = "Eksik Koli Sayısı: " + eksik_koli_sayisi.ToString();
                        }
                        else
                        {
                            panel_eksik_sayac_yok.Visible = true;
                        }
                        label_info.Text = tb_kutu_no_baslangic.Text + " - " + tb_kutu_no_bitis.Text + "  Aralığındaki Kayıtlar Gösteriliyor   |   Gösterilen Koli Sayısı: " + (koli_no_bitis - koli_no_baslangic).ToString() + "  |  Eksik Koli Sayısı: " + eksik_koli_sayisi.ToString();
                    }
                }
                gridview_sira_no_ekleme_ve_headerlari_duzeltme();
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
                gridview_sira_no_ekleme_ve_headerlari_duzeltme();
            }
            else
            {
                MessageBox.Show("Lütfen model kodunu tam olarak giriniz");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            panel_eksikleri_goster.Visible = false;
            panel_eksik_sayac_yok.Visible = false;
            panel_eksikleri_goster.Visible = false;
        }

        private void button_eksikleri_kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lütfen kayıt yerini seçiniz.";
            saveFileDialog.Filter = "Csv file (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.FileName = kayit.filename;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                using (StreamWriter SW = File.CreateText(path))
                {
                    SW.WriteLine(kayit.data);
                    SW.Close();
                }
            }
        }
    }
}
