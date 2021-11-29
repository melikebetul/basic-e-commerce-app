
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.geridon = new System.Windows.Forms.Button();
            this.biletdetay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lBWEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.ucusno = new System.Windows.Forms.TextBox();
            this.biletlistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(21, 415);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(75, 23);
            this.geridon.TabIndex = 0;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // biletdetay
            // 
            this.biletdetay.Location = new System.Drawing.Point(372, 164);
            this.biletdetay.Name = "biletdetay";
            this.biletdetay.Size = new System.Drawing.Size(75, 23);
            this.biletdetay.TabIndex = 1;
            this.biletdetay.Text = "Bilet Detaylarını gör";
            this.biletdetay.UseVisualStyleBackColor = true;
            this.biletdetay.Click += new System.EventHandler(this.biletdetay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(376, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilet Detayları";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lBWEL
            // 
            this.lBWEL.AutoSize = true;
            this.lBWEL.Location = new System.Drawing.Point(299, 85);
            this.lBWEL.Name = "lBWEL";
            this.lBWEL.Size = new System.Drawing.Size(36, 13);
            this.lBWEL.TabIndex = 3;
            this.lBWEL.Text = "TC no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uçuş no";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(360, 82);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 20);
            this.tc.TabIndex = 6;
            // 
            // ucusno
            // 
            this.ucusno.Location = new System.Drawing.Point(360, 113);
            this.ucusno.Name = "ucusno";
            this.ucusno.Size = new System.Drawing.Size(100, 20);
            this.ucusno.TabIndex = 7;
            // 
            // biletlistview
            // 
            this.biletlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.biletlistview.HideSelection = false;
            this.biletlistview.Location = new System.Drawing.Point(131, 209);
            this.biletlistview.Name = "biletlistview";
            this.biletlistview.Size = new System.Drawing.Size(554, 175);
            this.biletlistview.TabIndex = 8;
            this.biletlistview.UseCompatibleStateImageBehavior = false;
            this.biletlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC no";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uçuş No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nereden";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nereye";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kilo Kapasitesi";
            this.columnHeader6.Width = 88;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.biletlistview);
            this.Controls.Add(this.ucusno);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBWEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.biletdetay);
            this.Controls.Add(this.geridon);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button biletdetay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBWEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox ucusno;
        private System.Windows.Forms.ListView biletlistview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}