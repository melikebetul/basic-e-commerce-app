
namespace WindowsFormsApp1
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
            this.ucusgor = new System.Windows.Forms.Button();
            this.nereden = new System.Windows.Forms.ComboBox();
            this.nereye = new System.Windows.Forms.ComboBox();
            this.ucuslistview = new System.Windows.Forms.ListView();
            this.ucusl0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucusl1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucusl2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucusl3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucusl4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.hes = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ucusno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ucusgoster = new System.Windows.Forms.Button();
            this.yolculistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnsyt = new System.Windows.Forms.ComboBox();
            this.iptal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tciptal = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.form2gec = new System.Windows.Forms.Button();
            this.biletsorgula = new System.Windows.Forms.Button();
            this.rezervasyon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucusgor
            // 
            this.ucusgor.Location = new System.Drawing.Point(119, 272);
            this.ucusgor.Name = "ucusgor";
            this.ucusgor.Size = new System.Drawing.Size(93, 29);
            this.ucusgor.TabIndex = 0;
            this.ucusgor.Text = "Uçuşları Gör";
            this.ucusgor.UseVisualStyleBackColor = true;
            this.ucusgor.Click += new System.EventHandler(this.ucusgor_Click);
            // 
            // nereden
            // 
            this.nereden.Items.AddRange(new object[] {
            "Ankara Esenboğa Havaalanı",
            "İstanbul Havaalanı"});
            this.nereden.Location = new System.Drawing.Point(129, 146);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(170, 21);
            this.nereden.TabIndex = 1;
            // 
            // nereye
            // 
            this.nereye.FormattingEnabled = true;
            this.nereye.Items.AddRange(new object[] {
            "Almanya Münih Havaalanı",
            "Almanya Berlin Havaalanı",
            "Hollanda Amsterdam Havaalanı",
            "Fransa Paris Havaalanı"});
            this.nereye.Location = new System.Drawing.Point(129, 187);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(170, 21);
            this.nereye.TabIndex = 2;
            // 
            // ucuslistview
            // 
            this.ucuslistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ucusl0,
            this.ucusl1,
            this.ucusl2,
            this.ucusl3,
            this.ucusl4});
            this.ucuslistview.HideSelection = false;
            this.ucuslistview.Location = new System.Drawing.Point(12, 325);
            this.ucuslistview.Name = "ucuslistview";
            this.ucuslistview.Size = new System.Drawing.Size(400, 155);
            this.ucuslistview.TabIndex = 3;
            this.ucuslistview.UseCompatibleStateImageBehavior = false;
            this.ucuslistview.View = System.Windows.Forms.View.Details;
            // 
            // ucusl0
            // 
            this.ucusl0.Text = "Uçuş No";
            this.ucusl0.Width = 72;
            // 
            // ucusl1
            // 
            this.ucusl1.Text = "Nereden";
            this.ucusl1.Width = 84;
            // 
            // ucusl2
            // 
            this.ucusl2.Text = "Nereye";
            this.ucusl2.Width = 102;
            // 
            // ucusl3
            // 
            this.ucusl3.Text = "Tarih";
            this.ucusl3.Width = 77;
            // 
            // ucusl4
            // 
            this.ucusl4.Text = "Saat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(151, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "UÇUŞ BUL";
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(129, 234);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(170, 20);
            this.tarih.TabIndex = 10;
            this.tarih.Text = "1.07.2021";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(614, 49);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(111, 20);
            this.ad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(614, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "BİLET AL";
            this.label5.UseCompatibleTextRendering = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dg
            // 
            this.dg.Location = new System.Drawing.Point(614, 75);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(111, 20);
            this.dg.TabIndex = 13;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(614, 127);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(111, 20);
            this.tel.TabIndex = 15;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(614, 153);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(111, 20);
            this.tc.TabIndex = 16;
            // 
            // hes
            // 
            this.hes.Location = new System.Drawing.Point(614, 179);
            this.hes.Name = "hes";
            this.hes.Size = new System.Drawing.Size(111, 20);
            this.hes.TabIndex = 17;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(614, 205);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(111, 20);
            this.email.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cinsiyet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefon no";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "TC no";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "HES Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "email adresi";
            // 
            // ucusno
            // 
            this.ucusno.Enabled = false;
            this.ucusno.Location = new System.Drawing.Point(614, 231);
            this.ucusno.Name = "ucusno";
            this.ucusno.Size = new System.Drawing.Size(111, 20);
            this.ucusno.TabIndex = 26;
            this.ucusno.TextChanged += new System.EventHandler(this.ucusno_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(544, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Uçuş no";
            // 
            // ucusgoster
            // 
            this.ucusgoster.Location = new System.Drawing.Point(586, 257);
            this.ucusgoster.Name = "ucusgoster";
            this.ucusgoster.Size = new System.Drawing.Size(93, 29);
            this.ucusgoster.TabIndex = 28;
            this.ucusgoster.Text = "Bilet Al";
            this.ucusgoster.UseVisualStyleBackColor = true;
            this.ucusgoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // yolculistview
            // 
            this.yolculistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.yolculistview.HideSelection = false;
            this.yolculistview.Location = new System.Drawing.Point(462, 292);
            this.yolculistview.Name = "yolculistview";
            this.yolculistview.Size = new System.Drawing.Size(631, 188);
            this.yolculistview.TabIndex = 29;
            this.yolculistview.UseCompatibleStateImageBehavior = false;
            this.yolculistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doğum Tarihi";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon no";
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TC";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "HES Kodu";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Uçuş no";
            this.columnHeader8.Width = 34;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nereden";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nereye";
            // 
            // cnsyt
            // 
            this.cnsyt.FormattingEnabled = true;
            this.cnsyt.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cnsyt.Location = new System.Drawing.Point(614, 100);
            this.cnsyt.Name = "cnsyt";
            this.cnsyt.Size = new System.Drawing.Size(111, 21);
            this.cnsyt.TabIndex = 30;
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(803, 82);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(93, 29);
            this.iptal.TabIndex = 31;
            this.iptal.Text = "İptal Et";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(803, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "BİLET İPTALİ";
            this.label14.UseCompatibleTextRendering = true;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(761, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "TC No";
            // 
            // tciptal
            // 
            this.tciptal.Location = new System.Drawing.Point(820, 45);
            this.tciptal.Name = "tciptal";
            this.tciptal.Size = new System.Drawing.Size(111, 20);
            this.tciptal.TabIndex = 34;
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(706, 257);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(93, 29);
            this.guncelle.TabIndex = 35;
            this.guncelle.Text = "Bileti Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // form2gec
            // 
            this.form2gec.Location = new System.Drawing.Point(35, 52);
            this.form2gec.Name = "form2gec";
            this.form2gec.Size = new System.Drawing.Size(124, 27);
            this.form2gec.TabIndex = 36;
            this.form2gec.Text = "Uçus Detayları";
            this.form2gec.UseVisualStyleBackColor = true;
            this.form2gec.Click += new System.EventHandler(this.form2gec_Click);
            // 
            // biletsorgula
            // 
            this.biletsorgula.Location = new System.Drawing.Point(35, 14);
            this.biletsorgula.Name = "biletsorgula";
            this.biletsorgula.Size = new System.Drawing.Size(124, 29);
            this.biletsorgula.TabIndex = 37;
            this.biletsorgula.Text = "Bilet Sorgula";
            this.biletsorgula.UseVisualStyleBackColor = true;
            this.biletsorgula.Click += new System.EventHandler(this.biletsorgula_Click);
            // 
            // rezervasyon
            // 
            this.rezervasyon.Location = new System.Drawing.Point(186, 14);
            this.rezervasyon.Name = "rezervasyon";
            this.rezervasyon.Size = new System.Drawing.Size(124, 29);
            this.rezervasyon.TabIndex = 38;
            this.rezervasyon.Text = "Rezervasyon Yap";
            this.rezervasyon.UseVisualStyleBackColor = true;
            this.rezervasyon.Click += new System.EventHandler(this.rezervasyon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 523);
            this.Controls.Add(this.rezervasyon);
            this.Controls.Add(this.biletsorgula);
            this.Controls.Add(this.form2gec);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.tciptal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.cnsyt);
            this.Controls.Add(this.yolculistview);
            this.Controls.Add(this.ucusgoster);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ucusno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.hes);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucuslistview);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.nereden);
            this.Controls.Add(this.ucusgor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ucusgor;
        private System.Windows.Forms.ComboBox nereden;
        private System.Windows.Forms.ComboBox nereye;
        private System.Windows.Forms.ListView ucuslistview;
        private System.Windows.Forms.ColumnHeader ucusl0;
        private System.Windows.Forms.ColumnHeader ucusl1;
        private System.Windows.Forms.ColumnHeader ucusl2;
        private System.Windows.Forms.ColumnHeader ucusl3;
        private System.Windows.Forms.ColumnHeader ucusl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dg;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox hes;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ucusno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ucusgoster;
        private System.Windows.Forms.ListView yolculistview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cnsyt;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tciptal;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button form2gec;
        private System.Windows.Forms.Button biletsorgula;
        private System.Windows.Forms.Button rezervasyon;
    }
}

