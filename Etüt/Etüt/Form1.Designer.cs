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
            CmdDers = new ComboBox();
            MskTarih = new MaskedTextBox();
            label2 = new Label();
            CmbOgretmen = new ComboBox();
            MskSaat = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            BtnEtut = new Button();
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
            groupBox1.Controls.Add(BtnEtut);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MskSaat);
            groupBox1.Controls.Add(CmbOgretmen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskTarih);
            groupBox1.Controls.Add(CmdDers);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Ders:";
            // 
            // CmdDers
            // 
            CmdDers.FormattingEnabled = true;
            CmdDers.Location = new Point(106, 35);
            CmdDers.Name = "CmdDers";
            CmdDers.Size = new Size(182, 28);
            CmdDers.TabIndex = 1;
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(106, 133);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(182, 27);
            MskTarih.TabIndex = 2;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Öğretmen:";
            // 
            // CmbOgretmen
            // 
            CmbOgretmen.FormattingEnabled = true;
            CmbOgretmen.Location = new Point(106, 78);
            CmbOgretmen.Name = "CmbOgretmen";
            CmbOgretmen.Size = new Size(182, 28);
            CmbOgretmen.TabIndex = 4;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(106, 166);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(182, 27);
            MskSaat.TabIndex = 5;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 140);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 173);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // BtnEtut
            // 
            BtnEtut.Location = new Point(120, 204);
            BtnEtut.Name = "BtnEtut";
            BtnEtut.Size = new Size(137, 43);
            BtnEtut.TabIndex = 8;
            BtnEtut.Text = "Etüt Oluştur";
            BtnEtut.UseVisualStyleBackColor = true;
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
            groupBox2.Location = new Point(400, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 23);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 1;
            label5.Text = "Ad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 60);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 2;
            label6.Text = "Soyad:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(79, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "İptal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 98);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 4;
            label7.Text = "Durum:";
            // 
            // button2
            // 
            button2.Location = new Point(72, 198);
            button2.Name = "button2";
            button2.Size = new Size(182, 49);
            button2.TabIndex = 5;
            button2.Text = "Etüt Detay";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(98, 23);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 6;
            label8.Text = "NULL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 60);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 7;
            label9.Text = "NULL";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(8, 284);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(795, 233);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(789, 207);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(865, 577);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button BtnEtut;
        private Label label4;
        private Label label3;
        private MaskedTextBox MskSaat;
        private ComboBox CmbOgretmen;
        private Label label2;
        private MaskedTextBox MskTarih;
        private ComboBox CmdDers;
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