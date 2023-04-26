namespace Etüt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            CmbDers = new ComboBox();
            MskTarih = new MaskedTextBox();
            label2 = new Label();
            MskSaat = new MaskedTextBox();
            CmbOgretmen = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            BtnEtutOlustur = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnEtutOlustur);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CmbOgretmen);
            groupBox1.Controls.Add(MskSaat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskTarih);
            groupBox1.Controls.Add(CmbDers);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(52, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 0;
            label1.Text = "Ders:";
            // 
            // CmbDers
            // 
            CmbDers.FormattingEnabled = true;
            CmbDers.Location = new Point(84, 24);
            CmbDers.Name = "CmbDers";
            CmbDers.Size = new Size(172, 26);
            CmbDers.TabIndex = 1;
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(84, 144);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(172, 26);
            MskTarih.TabIndex = 2;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 3;
            label2.Text = "Öğretmen:";
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(84, 187);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(172, 26);
            MskSaat.TabIndex = 4;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // CmbOgretmen
            // 
            CmbOgretmen.FormattingEnabled = true;
            CmbOgretmen.Location = new Point(84, 68);
            CmbOgretmen.Name = "CmbOgretmen";
            CmbOgretmen.Size = new Size(172, 26);
            CmbOgretmen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 6;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 195);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // BtnEtutOlustur
            // 
            BtnEtutOlustur.Location = new Point(84, 219);
            BtnEtutOlustur.Name = "BtnEtutOlustur";
            BtnEtutOlustur.Size = new Size(172, 42);
            BtnEtutOlustur.TabIndex = 8;
            BtnEtutOlustur.Text = "Etüt Oluştur";
            BtnEtutOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(464, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 34);
            label5.Name = "label5";
            label5.Size = new Size(34, 18);
            label5.TabIndex = 1;
            label5.Text = "Ad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 70);
            label6.Name = "label6";
            label6.Size = new Size(60, 18);
            label6.TabIndex = 2;
            label6.Text = "Soyad:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(147, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 22);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "İptal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 110);
            label7.Name = "label7";
            label7.Size = new Size(58, 18);
            label7.TabIndex = 4;
            label7.Text = "Durum";
            // 
            // button2
            // 
            button2.Location = new Point(116, 143);
            button2.Name = "button2";
            button2.Size = new Size(137, 31);
            button2.TabIndex = 5;
            button2.Text = "Etüt Detay";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 34);
            label8.Name = "label8";
            label8.Size = new Size(50, 18);
            label8.TabIndex = 6;
            label8.Text = "NULL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 70);
            label9.Name = "label9";
            label9.Size = new Size(50, 18);
            label9.TabIndex = 7;
            label9.Text = "NULL";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(52, 308);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(808, 172);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(802, 147);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 540);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnEtutOlustur;
        private Label label4;
        private Label label3;
        private ComboBox CmbOgretmen;
        private MaskedTextBox MskSaat;
        private Label label2;
        private MaskedTextBox MskTarih;
        private ComboBox CmbDers;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Button button2;
        private Label label7;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
    }
}