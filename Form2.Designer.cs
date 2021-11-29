
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.ucusdetay = new System.Windows.Forms.Button();
            this.ucusnosorgula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucusdetaylistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.geridon = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ucusdetay
            // 
            this.ucusdetay.Location = new System.Drawing.Point(103, 134);
            this.ucusdetay.Name = "ucusdetay";
            this.ucusdetay.Size = new System.Drawing.Size(120, 29);
            this.ucusdetay.TabIndex = 0;
            this.ucusdetay.Text = "Uçuş Detayı Gör";
            this.ucusdetay.UseVisualStyleBackColor = true;
            this.ucusdetay.Click += new System.EventHandler(this.ucusdetay_Click);
            // 
            // ucusnosorgula
            // 
            this.ucusnosorgula.Location = new System.Drawing.Point(156, 73);
            this.ucusnosorgula.Name = "ucusnosorgula";
            this.ucusnosorgula.Size = new System.Drawing.Size(100, 20);
            this.ucusnosorgula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uçuş No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(131, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UÇUŞ SORGULA";
            // 
            // ucusdetaylistview
            // 
            this.ucusdetaylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12});
            this.ucusdetaylistview.HideSelection = false;
            this.ucusdetaylistview.Location = new System.Drawing.Point(12, 210);
            this.ucusdetaylistview.Name = "ucusdetaylistview";
            this.ucusdetaylistview.Size = new System.Drawing.Size(987, 245);
            this.ucusdetaylistview.TabIndex = 4;
            this.ucusdetaylistview.UseCompatibleStateImageBehavior = false;
            this.ucusdetaylistview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uçuş no";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nereden";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nereye";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kalkış";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Varış";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pilot Ad Soyad";
            this.columnHeader7.Width = 95;
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(33, 461);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(75, 23);
            this.geridon.TabIndex = 5;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pilot TC";
            this.columnHeader8.Width = 61;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Pilot Tel no";
            this.columnHeader10.Width = 83;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Havayolu Şirketi";
            this.columnHeader9.Width = 97;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Uçak Kapasite";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Uçak Marka";
            this.columnHeader12.Width = 85;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 511);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.ucusdetaylistview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucusnosorgula);
            this.Controls.Add(this.ucusdetay);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ucusdetay;
        private System.Windows.Forms.TextBox ucusnosorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ucusdetaylistview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}