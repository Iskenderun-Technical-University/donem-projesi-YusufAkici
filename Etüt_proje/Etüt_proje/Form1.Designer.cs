namespace Etüt_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdDers = new System.Windows.Forms.ComboBox();
            this.CmdOgretmen = new System.Windows.Forms.ComboBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.BtnEtut = new System.Windows.Forms.Button();
            this.LblOgrenci = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextOgrenciid = new System.Windows.Forms.TextBox();
            this.TxtEtutId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EtutuId = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txtsoyad1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTlef = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtMa = new System.Windows.Forms.Label();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnFotoraf = new System.Windows.Forms.Button();
            this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnOgretmenKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtut);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmdOgretmen);
            this.groupBox1.Controls.Add(this.CmdDers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EtutuId);
            this.groupBox2.Controls.Add(this.TextOgrenciid);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LblOgrenci);
            this.groupBox2.Location = new System.Drawing.Point(422, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(15, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1113, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat:";
            // 
            // CmdDers
            // 
            this.CmdDers.FormattingEnabled = true;
            this.CmdDers.Location = new System.Drawing.Point(112, 25);
            this.CmdDers.Name = "CmdDers";
            this.CmdDers.Size = new System.Drawing.Size(191, 26);
            this.CmdDers.TabIndex = 4;
            this.CmdDers.SelectedIndexChanged += new System.EventHandler(this.CmdDers_SelectedIndexChanged);
            // 
            // CmdOgretmen
            // 
            this.CmdOgretmen.FormattingEnabled = true;
            this.CmdOgretmen.Location = new System.Drawing.Point(112, 57);
            this.CmdOgretmen.Name = "CmdOgretmen";
            this.CmdOgretmen.Size = new System.Drawing.Size(191, 26);
            this.CmdOgretmen.TabIndex = 5;
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(109, 109);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(193, 26);
            this.MskTarih.TabIndex = 6;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(109, 148);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(193, 26);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // BtnEtut
            // 
            this.BtnEtut.BackColor = System.Drawing.Color.Tomato;
            this.BtnEtut.Location = new System.Drawing.Point(124, 189);
            this.BtnEtut.Name = "BtnEtut";
            this.BtnEtut.Size = new System.Drawing.Size(148, 47);
            this.BtnEtut.TabIndex = 8;
            this.BtnEtut.Text = "Etüt Oluştur:";
            this.BtnEtut.UseVisualStyleBackColor = false;
            this.BtnEtut.Click += new System.EventHandler(this.BtnEtut_Click);
            // 
            // LblOgrenci
            // 
            this.LblOgrenci.AutoSize = true;
            this.LblOgrenci.Location = new System.Drawing.Point(29, 60);
            this.LblOgrenci.Name = "LblOgrenci";
            this.LblOgrenci.Size = new System.Drawing.Size(71, 18);
            this.LblOgrenci.TabIndex = 1;
            this.LblOgrenci.Text = "Öğrenci:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 4;
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.Location = new System.Drawing.Point(122, 98);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(152, 37);
            this.BtnEtutVer.TabIndex = 6;
            this.BtnEtutVer.Text = "Etüt Ver:";
            this.BtnEtutVer.UseVisualStyleBackColor = true;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1107, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TextOgrenciid
            // 
            this.TextOgrenciid.Location = new System.Drawing.Point(122, 56);
            this.TextOgrenciid.Name = "TextOgrenciid";
            this.TextOgrenciid.Size = new System.Drawing.Size(158, 26);
            this.TextOgrenciid.TabIndex = 7;
            // 
            // TxtEtutId
            // 
            this.TxtEtutId.Enabled = false;
            this.TxtEtutId.Location = new System.Drawing.Point(122, 20);
            this.TxtEtutId.Name = "TxtEtutId";
            this.TxtEtutId.Size = new System.Drawing.Size(158, 26);
            this.TxtEtutId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 9;
            // 
            // EtutuId
            // 
            this.EtutuId.AutoSize = true;
            this.EtutuId.Location = new System.Drawing.Point(29, 24);
            this.EtutuId.Name = "EtutuId";
            this.EtutuId.Size = new System.Drawing.Size(62, 18);
            this.EtutuId.TabIndex = 8;
            this.EtutuId.Text = "Etüt id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtTelefon);
            this.groupBox4.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox4.Controls.Add(this.TxtMail);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TxtMa);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TxtTlef);
            this.groupBox4.Controls.Add(this.TxtSinif);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label);
            this.groupBox4.Controls.Add(this.Txtsoyad1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TxtSoyad);
            this.groupBox4.Controls.Add(this.TxtAd);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(846, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 258);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnFotoraf);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(1152, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 233);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnOgretmenKaydet);
            this.groupBox6.Controls.Add(this.CmbDers);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.TxtOgretmenSoyad);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.TxtOgretmenAd);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(1152, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 255);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(105, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(160, 26);
            this.TxtAd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ad:";
            // 
            // Txtsoyad1
            // 
            this.Txtsoyad1.Location = new System.Drawing.Point(107, 64);
            this.Txtsoyad1.Name = "Txtsoyad1";
            this.Txtsoyad1.Size = new System.Drawing.Size(158, 26);
            this.Txtsoyad1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 15;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Location = new System.Drawing.Point(14, 68);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(60, 18);
            this.TxtSoyad.TabIndex = 14;
            this.TxtSoyad.Text = "Soyad:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(105, 96);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(158, 26);
            this.TxtSinif.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 18);
            this.label.TabIndex = 17;
            this.label.Text = "Sınıf:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 21;
            // 
            // TxtTlef
            // 
            this.TxtTlef.AutoSize = true;
            this.TxtTlef.Location = new System.Drawing.Point(14, 132);
            this.TxtTlef.Name = "TxtTlef";
            this.TxtTlef.Size = new System.Drawing.Size(68, 18);
            this.TxtTlef.TabIndex = 20;
            this.TxtTlef.Text = "Telefon:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(105, 161);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(158, 26);
            this.TxtMail.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 18);
            this.label15.TabIndex = 24;
            // 
            // TxtMa
            // 
            this.TxtMa.AutoSize = true;
            this.TxtMa.Location = new System.Drawing.Point(12, 165);
            this.TxtMa.Name = "TxtMa";
            this.TxtMa.Size = new System.Drawing.Size(46, 18);
            this.TxtMa.TabIndex = 23;
            this.TxtMa.Text = "Mail:";
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(107, 199);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(152, 37);
            this.BtnOgrenciEkle.TabIndex = 26;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = false;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(107, 128);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(156, 26);
            this.TxtTelefon.TabIndex = 27;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.TxtDers);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(422, 176);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(405, 107);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(98, 44);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(152, 26);
            this.TxtDers.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ders Adı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Location = new System.Drawing.Point(270, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnFotoraf
            // 
            this.BtnFotoraf.BackColor = System.Drawing.Color.Sienna;
            this.BtnFotoraf.Location = new System.Drawing.Point(57, 191);
            this.BtnFotoraf.Name = "BtnFotoraf";
            this.BtnFotoraf.Size = new System.Drawing.Size(152, 37);
            this.BtnFotoraf.TabIndex = 27;
            this.BtnFotoraf.Text = "Fotoraf Yükle";
            this.BtnFotoraf.UseVisualStyleBackColor = false;
            this.BtnFotoraf.Click += new System.EventHandler(this.BtnFotoraf_Click);
            // 
            // TxtOgretmenSoyad
            // 
            this.TxtOgretmenSoyad.Location = new System.Drawing.Point(82, 54);
            this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
            this.TxtOgretmenSoyad.Size = new System.Drawing.Size(158, 26);
            this.TxtOgretmenSoyad.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 18);
            this.label16.TabIndex = 20;
            this.label16.Text = "Soyad:";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.Location = new System.Drawing.Point(80, 21);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(160, 26);
            this.TxtOgretmenAd.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 18);
            this.label17.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 18);
            this.label18.TabIndex = 17;
            this.label18.Text = "Ad:";
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(82, 89);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(158, 26);
            this.CmbDers.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 18);
            this.label19.TabIndex = 23;
            this.label19.Text = "Ders:";
            // 
            // BtnOgretmenKaydet
            // 
            this.BtnOgretmenKaydet.BackColor = System.Drawing.Color.Turquoise;
            this.BtnOgretmenKaydet.Location = new System.Drawing.Point(88, 136);
            this.BtnOgretmenKaydet.Name = "BtnOgretmenKaydet";
            this.BtnOgretmenKaydet.Size = new System.Drawing.Size(152, 37);
            this.BtnOgretmenKaydet.TabIndex = 28;
            this.BtnOgretmenKaydet.Text = "Öğretmen Ekle";
            this.BtnOgretmenKaydet.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1581, 593);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEtut;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.ComboBox CmdOgretmen;
        private System.Windows.Forms.ComboBox CmdDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblOgrenci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextOgrenciid;
        private System.Windows.Forms.TextBox TxtEtutId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EtutuId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TxtMa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TxtTlef;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Txtsoyad1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnFotoraf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnOgretmenKaydet;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtOgretmenSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtDers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

