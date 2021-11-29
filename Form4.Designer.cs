
namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yolcutc = new System.Windows.Forms.TextBox();
            this.rezervasyonyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rezlistview = new System.Windows.Forms.ListView();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.odemeyap = new System.Windows.Forms.Button();
            this.odemerezid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kartisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hesapno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucret = new System.Windows.Forms.TextBox();
            this.odemelistview = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.geridon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yolcutc
            // 
            this.yolcutc.Location = new System.Drawing.Point(144, 78);
            this.yolcutc.Name = "yolcutc";
            this.yolcutc.Size = new System.Drawing.Size(100, 20);
            this.yolcutc.TabIndex = 0;
            // 
            // rezervasyonyap
            // 
            this.rezervasyonyap.Location = new System.Drawing.Point(89, 120);
            this.rezervasyonyap.Name = "rezervasyonyap";
            this.rezervasyonyap.Size = new System.Drawing.Size(140, 33);
            this.rezervasyonyap.TabIndex = 1;
            this.rezervasyonyap.Text = "Rezervasyon Yap";
            this.rezervasyonyap.UseVisualStyleBackColor = true;
            this.rezervasyonyap.Click += new System.EventHandler(this.rezervasyonyap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervasyon Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yolcu TC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rezlistview
            // 
            this.rezlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.rezlistview.HideSelection = false;
            this.rezlistview.Location = new System.Drawing.Point(278, 41);
            this.rezlistview.Name = "rezlistview";
            this.rezlistview.Size = new System.Drawing.Size(776, 143);
            this.rezlistview.TabIndex = 4;
            this.rezlistview.UseCompatibleStateImageBehavior = false;
            this.rezlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rez_id";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yolcu TC";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uçuş no";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kalkış";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Varış";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nereden";
            this.columnHeader7.Width = 127;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nererye";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bilet Fiyatı";
            this.columnHeader9.Width = 68;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Koltuk no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rezervasyon ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(141, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ödeme Yap";
            // 
            // odemeyap
            // 
            this.odemeyap.Location = new System.Drawing.Point(122, 411);
            this.odemeyap.Name = "odemeyap";
            this.odemeyap.Size = new System.Drawing.Size(140, 33);
            this.odemeyap.TabIndex = 6;
            this.odemeyap.Text = "Ödeme Yap";
            this.odemeyap.UseVisualStyleBackColor = true;
            this.odemeyap.Click += new System.EventHandler(this.odemeyap_Click);
            // 
            // odemerezid
            // 
            this.odemerezid.Enabled = false;
            this.odemerezid.Location = new System.Drawing.Point(166, 267);
            this.odemerezid.Name = "odemerezid";
            this.odemerezid.Size = new System.Drawing.Size(100, 20);
            this.odemerezid.TabIndex = 5;
            this.odemerezid.TextChanged += new System.EventHandler(this.odemerezid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Karttaki İsim";
            // 
            // kartisim
            // 
            this.kartisim.Location = new System.Drawing.Point(166, 293);
            this.kartisim.Name = "kartisim";
            this.kartisim.Size = new System.Drawing.Size(100, 20);
            this.kartisim.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hesap No";
            // 
            // hesapno
            // 
            this.hesapno.Location = new System.Drawing.Point(166, 319);
            this.hesapno.Name = "hesapno";
            this.hesapno.Size = new System.Drawing.Size(100, 20);
            this.hesapno.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CVV";
            // 
            // cvv
            // 
            this.cvv.Location = new System.Drawing.Point(166, 345);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(100, 20);
            this.cvv.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ücret";
            // 
            // ucret
            // 
            this.ucret.Location = new System.Drawing.Point(166, 372);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(100, 20);
            this.ucret.TabIndex = 15;
            // 
            // odemelistview
            // 
            this.odemelistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader20});
            this.odemelistview.HideSelection = false;
            this.odemelistview.Location = new System.Drawing.Point(309, 270);
            this.odemelistview.Name = "odemelistview";
            this.odemelistview.Size = new System.Drawing.Size(625, 143);
            this.odemelistview.TabIndex = 17;
            this.odemelistview.UseCompatibleStateImageBehavior = false;
            this.odemelistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Rez_id";
            this.columnHeader11.Width = 63;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Yolcu TC";
            this.columnHeader12.Width = 74;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Uçuş no";
            this.columnHeader13.Width = 69;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Karttaki İsim";
            this.columnHeader14.Width = 114;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Hesap no";
            this.columnHeader15.Width = 195;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Ödenen Ücret";
            this.columnHeader20.Width = 94;
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(20, 473);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(112, 26);
            this.geridon.TabIndex = 18;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 525);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.odemelistview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hesapno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kartisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odemeyap);
            this.Controls.Add(this.odemerezid);
            this.Controls.Add(this.rezlistview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervasyonyap);
            this.Controls.Add(this.yolcutc);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yolcutc;
        private System.Windows.Forms.Button rezervasyonyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView rezlistview;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button odemeyap;
        private System.Windows.Forms.TextBox odemerezid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kartisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hesapno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ucret;
        private System.Windows.Forms.ListView odemelistview;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Button geridon;
    }
}