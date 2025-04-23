using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
        public partial class Form1 : Form
        {
            private List<Musteri> musteriler = new List<Musteri>();

            public Form1()
            {
                InitializeComponent();
            }

            // ✅ MÜŞTERİ EKLEME METODU
            private void EkleMusteri(string ad, string soyad, string telefon, string adres)
            {
                Musteri yeniMusteri = new Musteri
                {
                    Ad = ad,
                    Soyad = soyad,
                    Telefon = telefon,
                    Adres = adres
                };

                musteriler.Add(yeniMusteri);
                cmbMusteriler.Items.Add(yeniMusteri);
                MessageBox.Show("Müşteri başarıyla eklendi.");
            }

            private void btnMusteriEkle_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    MessageBox.Show("Ad ve soyad alanları boş olamaz.");
                    return;
                }

                EkleMusteri(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtAdres.Text);

                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                txtAdres.Clear();
            }

            // ✅ HALI EKLEME METODU
            private void HaliEkle(Musteri musteri, double metrekare, DateTime alimTarihi, DateTime teslimTarihi)
            {
                Hali yeniHali = new Hali
                {
                    Metrekare = metrekare,
                    AlimTarihi = alimTarihi,
                    TahminiTeslimTarihi = teslimTarihi,
                    TeslimEdildi = false
                };

                musteri.Halilar.Add(yeniHali);
                MessageBox.Show("Halı başarıyla eklendi.");
            }

            private void btnHaliEkle_Click(object sender, EventArgs e)
            {
                if (cmbMusteriler.SelectedItem is Musteri musteri)
                {
                    HaliEkle(musteri, (double)nudMetrekare.Value, dtpAlimTarihi.Value, dtpTeslimTarihi.Value);
                }
                else
                {
                    MessageBox.Show("Lütfen halı eklenecek müşteriyi seçiniz.");
                }
            }

            // ✅ YIKAMADA HALILARI LİSTELE
            private void btnYikamadaListele_Click(object sender, EventArgs e)
            {
                lstYikamada.Items.Clear();

                var yikamadakiHalilar = musteriler
                    .SelectMany(m => m.Halilar)
                    .Where(h => !h.TeslimEdildi)
                    .ToList();

                foreach (var hali in yikamadakiHalilar)
                {
                    lstYikamada.Items.Add(hali);
                }
            }

            // ✅ TESLİM EDİLEN HALILARI LİSTELE
            private void btnTeslimListele_Click(object sender, EventArgs e)
            {
                lstTeslimEdilen.Items.Clear();

                var teslimEdilenler = musteriler
                    .SelectMany(m => m.Halilar)
                    .Where(h => h.TeslimEdildi)
                    .ToList();

                foreach (var hali in teslimEdilenler)
                {
                    lstTeslimEdilen.Items.Add(hali);
                }
            }

            // ✅ HALI DURUMUNU GÜNCELLE
            private void btnDurumuGuncelle_Click(object sender, EventArgs e)
            {
                if (lstYikamada.SelectedItem is Hali seciliHali)
                {
                    seciliHali.TeslimEdildi = true;
                    MessageBox.Show("Halı durumu 'Teslim Edildi' olarak güncellendi.");
                    btnYikamadaListele_Click(null, null); // Listeyi yenile
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek halıyı seçin.");
                }
            }
        }
    }