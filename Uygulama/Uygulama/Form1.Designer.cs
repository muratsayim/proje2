namespace Uygulama
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.nudMetrekare = new System.Windows.Forms.NumericUpDown();
            this.dtpAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHaliEkle = new System.Windows.Forms.Button();
            this.lstYikamada = new System.Windows.Forms.ListBox();
            this.lstTeslimEdilen = new System.Windows.Forms.ListBox();
            this.btnDurumuGuncelle = new System.Windows.Forms.Button();
            this.btnYikamadaListele = new System.Windows.Forms.Button();
            this.btnTeslimListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetrekare)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(12, 41);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "Soyad";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(12, 70);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(12, 99);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 22);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.Text = "Adres";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 128);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(150, 23);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.Location = new System.Drawing.Point(200, 12);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(200, 24);
            this.cmbMusteriler.TabIndex = 5;
            // 
            // nudMetrekare
            // 
            this.nudMetrekare.DecimalPlaces = 1;
            this.nudMetrekare.Location = new System.Drawing.Point(200, 41);
            this.nudMetrekare.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMetrekare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMetrekare.Name = "nudMetrekare";
            this.nudMetrekare.Size = new System.Drawing.Size(200, 22);
            this.nudMetrekare.TabIndex = 6;
            this.nudMetrekare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpAlimTarihi
            // 
            this.dtpAlimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlimTarihi.Location = new System.Drawing.Point(200, 70);
            this.dtpAlimTarihi.Name = "dtpAlimTarihi";
            this.dtpAlimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpAlimTarihi.TabIndex = 7;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(200, 99);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpTeslimTarihi.TabIndex = 8;
            // 
            // btnHaliEkle
            // 
            this.btnHaliEkle.Location = new System.Drawing.Point(200, 128);
            this.btnHaliEkle.Name = "btnHaliEkle";
            this.btnHaliEkle.Size = new System.Drawing.Size(200, 23);
            this.btnHaliEkle.TabIndex = 9;
            this.btnHaliEkle.Text = "Halı Ekle";
            this.btnHaliEkle.Click += new System.EventHandler(this.btnHaliEkle_Click);
            // 
            // lstYikamada
            // 
            this.lstYikamada.ItemHeight = 16;
            this.lstYikamada.Location = new System.Drawing.Point(12, 180);
            this.lstYikamada.Name = "lstYikamada";
            this.lstYikamada.Size = new System.Drawing.Size(300, 100);
            this.lstYikamada.TabIndex = 10;
            // 
            // lstTeslimEdilen
            // 
            this.lstTeslimEdilen.ItemHeight = 16;
            this.lstTeslimEdilen.Location = new System.Drawing.Point(12, 310);
            this.lstTeslimEdilen.Name = "lstTeslimEdilen";
            this.lstTeslimEdilen.Size = new System.Drawing.Size(300, 100);
            this.lstTeslimEdilen.TabIndex = 11;
            // 
            // btnDurumuGuncelle
            // 
            this.btnDurumuGuncelle.Location = new System.Drawing.Point(330, 180);
            this.btnDurumuGuncelle.Name = "btnDurumuGuncelle";
            this.btnDurumuGuncelle.Size = new System.Drawing.Size(208, 23);
            this.btnDurumuGuncelle.TabIndex = 12;
            this.btnDurumuGuncelle.Text = "Durumu Teslim Edildi Yap";
            this.btnDurumuGuncelle.Click += new System.EventHandler(this.btnDurumuGuncelle_Click);
            // 
            // btnYikamadaListele
            // 
            this.btnYikamadaListele.Location = new System.Drawing.Point(330, 210);
            this.btnYikamadaListele.Name = "btnYikamadaListele";
            this.btnYikamadaListele.Size = new System.Drawing.Size(208, 23);
            this.btnYikamadaListele.TabIndex = 13;
            this.btnYikamadaListele.Text = "Yıkamadaki Halılar";
            this.btnYikamadaListele.Click += new System.EventHandler(this.btnYikamadaListele_Click);
            // 
            // btnTeslimListele
            // 
            this.btnTeslimListele.Location = new System.Drawing.Point(330, 240);
            this.btnTeslimListele.Name = "btnTeslimListele";
            this.btnTeslimListele.Size = new System.Drawing.Size(208, 23);
            this.btnTeslimListele.TabIndex = 14;
            this.btnTeslimListele.Text = "Teslim Edilen Halılar";
            this.btnTeslimListele.Click += new System.EventHandler(this.btnTeslimListele_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.cmbMusteriler);
            this.Controls.Add(this.nudMetrekare);
            this.Controls.Add(this.dtpAlimTarihi);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.btnHaliEkle);
            this.Controls.Add(this.lstYikamada);
            this.Controls.Add(this.lstTeslimEdilen);
            this.Controls.Add(this.btnDurumuGuncelle);
            this.Controls.Add(this.btnYikamadaListele);
            this.Controls.Add(this.btnTeslimListele);
            this.Name = "Form1";
            this.Text = "Halı Yıkama Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.nudMetrekare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            private System.Windows.Forms.TextBox txtAd;
            private System.Windows.Forms.TextBox txtSoyad;
            private System.Windows.Forms.TextBox txtTelefon;
            private System.Windows.Forms.TextBox txtAdres;
            private System.Windows.Forms.Button btnMusteriEkle;
            private System.Windows.Forms.ComboBox cmbMusteriler;
            private System.Windows.Forms.NumericUpDown nudMetrekare;
            private System.Windows.Forms.DateTimePicker dtpAlimTarihi;
            private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
            private System.Windows.Forms.Button btnHaliEkle;
            private System.Windows.Forms.ListBox lstYikamada;
            private System.Windows.Forms.ListBox lstTeslimEdilen;
            private System.Windows.Forms.Button btnDurumuGuncelle;
            private System.Windows.Forms.Button btnYikamadaListele;
            private System.Windows.Forms.Button btnTeslimListele;
        }
    }