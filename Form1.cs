
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
    public partial class Form1 : Form
    {
        string koli_no = "";
        string urun_kodu = "";
        int kolideki_sayac_sayisi;
        ImageSources images = new ImageSources();
        int label_action_index = 0;
        public Form1()
        {
            InitializeComponent();
            #region Test için örnek kayıt oluşturur
            /* for (int i = 0; i < 50; i++)
             {
                 using (var db = new Meter_PackageContext())
                 {
                     db.Database.CreateIfNotExists();

                     Package paket = new Package();

                     paket.Meter_ID = "123456" + i.ToString("D2");
                     paket.Meter_Count_In_Box = 5;
                     paket.Package_Code = "DENEME1004" + (i/5).ToString("D2");
                     paket.Product_Code = "WRD - ..";
                     paket.Transferred_Public = "0";
                     paket.Packing_Date = DateTime.Now.AddDays((i / 5) * -1);

                     db.packages.Add(paket);
                     db.SaveChanges();
                 }
             }*/
            #endregion
        }

        private void textBox_barkod_Click(object sender, EventArgs e)
        {
            textBox_barkod.Text = "";
        }

        private void textBox_barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Data_Isleme();
            }
        }

        private void Data_Isleme()
        {
            bool seri_no_okutuldu = false;
            bool error = false;
            if (!String.IsNullOrEmpty(textBox_barkod.Text) && textBox_barkod.Text.Length > 7)
            {
                string[] datas = textBox_barkod.Text.Split('|');
                if (datas.Length > 2)   //Kare Barkod okutulmuş
                {
                    if (!Listeye_Ekle(datas))
                    {
                        MessageBox.Show("Okutulan barkod yanlış. Lütfen kutu üzerindeki Kare Kodu okutunuz!");
                    }
                    kolideki_sayac_sayisi = datas.Length;
                }
                else
                {
                    seri_no_okutuldu = true;
                    string mesaj = "";
                    timer_label_action.Enabled = false;
                    switch (Listede_Ara_ve_Guncelle(textBox_barkod.Text))
                    {
                        case 0:
                            mesaj = "ÜRÜN BULUNAMADI" + Environment.NewLine + "(ÜRÜN KUTUYA AİT DEĞİL!)";
                            error = true;
                            break;
                        case 1:
                            mesaj = "MÜKERRER KAYIT BULUNDU!";
                            error = true;
                            break;
                        case 2:
                            mesaj = "Sıradaki barkodu okutunuz";
                            DB_Kayit_Ekle(textBox_barkod.Text);
                            pictureBox_info.Image = images.check;
                            label_bilgi.ForeColor = Color.DarkGreen;
                            break;
                        case 3:
                            mesaj = "Paketlemeye Hazır.";
                            Paket_Hazir();
                            DB_Kayit_Ekle(textBox_barkod.Text);
                            break;
                    }
                    label_bilgi.Text = mesaj;
                    if (error)
                    {
                        label_bilgi.ForeColor = Color.DarkRed;
                        pictureBox_info.Image = images.warning_gif;
                        timer_label_action.Enabled = true;
                        label_action_index = 0;
                    }
                    else
                        timer_label_action.Enabled = false;
                }
                List_Eleman_Sayisi_Yazdirma();
                List_Sira_Numalarini_Guncelle();
                if ((error == false) && (Paket_Hazir_Mi()))
                {
                    Paket_Hazir();
                }
                else if (seri_no_okutuldu == false)
                {
                    label_bilgi.Text = "EKSİK SAYAÇLAR BEKLENİYOR...";
                    pictureBox_info.Image = null;
                    label_box_state.Text = "EKSİK SAYAÇLAR BEKLENİYOR...";
                    label_box_state.ForeColor = Color.DarkBlue;
                    pictureBox_box_state.Image = images.waiting_gif;
                    pictureBox_box.Image = images.box_opened;
                }
            }
            textBox_barkod.Text = "";
        }
        private void List_Eleman_Sayisi_Yazdirma()
        {
            label_kontrol_edilen.Text = "Kontrol Edilen: " + listView_kontrol_edilen.Items.Count;
            label_kontrol_edilmeyen.Text = "Kontrol Edilmeyen: " + listView_kontrol_edilmeyen.Items.Count;
        }
        private void List_Sira_Numalarini_Guncelle()
        {
            for (int i = 0; i < listView_kontrol_edilen.Items.Count; i++)
            {
                listView_kontrol_edilen.Items[i].SubItems[1].Text = (i + 1).ToString();
            }
            for (int i = 0; i < listView_kontrol_edilmeyen.Items.Count; i++)
            {
                listView_kontrol_edilmeyen.Items[i].SubItems[1].Text = (i + 1).ToString();
            }
        }
        private bool Paket_Hazir_Mi()
        {
            if ((listView_kontrol_edilen.Items.Count > 0) && (listView_kontrol_edilmeyen.Items.Count == 0))
                return true;
            else
                return false;
        }
        private void Paket_Hazir()
        {
            label_bilgi.Text = "Paketlemeye Hazır.";
            label_bilgi.ForeColor = Color.DarkGreen;
            label_box_state.Text = "MÜKERRER KONTROLÜ BAŞARILI" + Environment.NewLine + "KOLİYİ KAPATINIZ";
            label_box_state.ForeColor = Color.DarkGreen;
            pictureBox_box.Image = images.box_closed;
            pictureBox_box_state.Image = images.check_gif;
            pictureBox_info.Image = images.check;
        }
        private void DB_Kayit_Ekle(string sayac_no)
        {
            using (var db = new Meter_PackageContext())
            {
                Package paket = new Package();
                paket.Meter_ID = sayac_no;
                paket.Meter_Count_In_Box = kolideki_sayac_sayisi;
                paket.Package_Code = koli_no;
                paket.Product_Code = urun_kodu;
                paket.Transferred_Public = "0";
                paket.Packing_Date = DateTime.Now;
                db.packages.Add(paket);
                db.SaveChanges();
            }
        }
        private bool Listeye_Ekle(string[] list_datas)
        {
            if (list_datas.Length > 2)
            {
                listView_kontrol_edilen.Items.Clear();
                listView_kontrol_edilmeyen.Items.Clear();

                label_koli_no_value.Text = list_datas[0];
                label_model_no_value.Text = list_datas[1];

                koli_no = list_datas[0];
                urun_kodu = list_datas[1];
                DB_Tara_ve_Listeye_Ekle(koli_no);

                for (int i = 2; i < list_datas.Length; i++)
                {
                    if (list_datas[i].Length > 0)
                    {
                        if (Liste_Tarama(list_datas[i], listView_kontrol_edilen) == false)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems.Add((listView_kontrol_edilmeyen.Items.Count + 1).ToString());
                            item.SubItems.Add(list_datas[i]);
                            listView_kontrol_edilmeyen.Items.Add(item);
                        }
                    }
                }
                return true;
            }
            return false;
        }

        private bool Liste_Tarama(string _meter_id, ListView _listview)
        {
            for (int i = 0; i < _listview.Items.Count; i++)
            {
                if (_listview.Items[i].SubItems[2].Text == _meter_id)
                    return true;
            }
            return false;
        }
        private void DB_Tara_ve_Listeye_Ekle(string kod)
        {
            using (var db = new Meter_PackageContext())
            {
                var data = db.packages.AsQueryable();
                data = data.Where(x => x.Package_Code == kod);
                int index = 1;
                foreach (Package okunan_data in data)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(index.ToString());
                    item.SubItems.Add(okunan_data.Meter_ID);
                    listView_kontrol_edilen.Items.Add(item);
                    index++;
                }
            }
        }
        private int Listede_Ara_ve_Guncelle(string list_datas)
        {
            for (int i = 0; i < listView_kontrol_edilen.Items.Count; i++)
            {
                if (listView_kontrol_edilen.Items[i].SubItems[2].Text == list_datas)
                {
                    return 1;
                }
            }
            for (int i = 0; i < listView_kontrol_edilmeyen.Items.Count; i++)
            {
                if (listView_kontrol_edilmeyen.Items[i].SubItems[2].Text == list_datas)
                {
                    listView_kontrol_edilmeyen.Items[i].Remove();
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add((listView_kontrol_edilen.Items.Count + 1).ToString());
                    item.SubItems.Add(list_datas);
                    listView_kontrol_edilen.Items.Add(item);

                    if (Pakete_Hazir_Mi())
                        return 3;
                    else
                        return 2;
                }
            }
            return 0;
        }

        private bool Pakete_Hazir_Mi()
        {
            if ((listView_kontrol_edilen.Items.Count > 0) && (listView_kontrol_edilmeyen.Items.Count == 0))
                return true;
            return false;
        }
        private void button_Kayitlari_Listele_Click(object sender, EventArgs e)
        {
            Kayitlari_Listele form2 = new Kayitlari_Listele();
            form2.Show();
        }

        class ImageSources
        {
            public Image check_gif = Paket_Barkod_Kontrol.Properties.Resources.Check_gif;
            public Image cancel = Paket_Barkod_Kontrol.Properties.Resources.Cancel;
            public Image warning_gif = Paket_Barkod_Kontrol.Properties.Resources.Warning_gif;
            public Image waiting_gif = Paket_Barkod_Kontrol.Properties.Resources.Spinner_gif;
            public Image check = Paket_Barkod_Kontrol.Properties.Resources.Checked;
            public Image box_opened = Paket_Barkod_Kontrol.Properties.Resources.OpenBox;
            public Image box_closed = Paket_Barkod_Kontrol.Properties.Resources.ClosedBox;
        }

        private void timer_label_action_Tick(object sender, EventArgs e)
        {
            label_action_index++;
            if (label_action_index % 2 == 0)
            {
                label_bilgi.Font = new System.Drawing.Font("Microsoft Himalaya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label_bilgi.ForeColor = Color.Maroon;
            }
            else
            {
                label_bilgi.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label_bilgi.ForeColor = Color.Red;
            }
        }
    }
}
