namespace PersonelApp
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            lbPersoneller = new ListBox();
            label6 = new Label();
            lblad = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtYas = new TextBox();
            label4 = new Label();
            txtTelefon = new TextBox();
            label5 = new Label();
            txtAdres = new TextBox();
            btnYeni = new Button();
            btnEkleGuncelle = new Button();
            btnSil = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 42);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_user;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 1;
            label1.Text = "Personel Takibi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(lbPersoneller);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 381);
            panel2.TabIndex = 1;
            // 
            // lbPersoneller
            // 
            lbPersoneller.BackColor = Color.Silver;
            lbPersoneller.FormattingEnabled = true;
            lbPersoneller.ItemHeight = 15;
            lbPersoneller.Location = new Point(3, 21);
            lbPersoneller.Name = "lbPersoneller";
            lbPersoneller.Size = new Size(195, 349);
            lbPersoneller.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 18);
            label6.TabIndex = 0;
            label6.Text = "Personel Listesi";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblad.Location = new Point(350, 81);
            lblad.Name = "lblad";
            lblad.Size = new Size(25, 17);
            lblad.TabIndex = 2;
            lblad.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(381, 80);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(185, 18);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(333, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(381, 104);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(185, 18);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(350, 129);
            label3.Name = "label3";
            label3.Size = new Size(28, 17);
            label3.TabIndex = 2;
            label3.Text = "Yas";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(381, 128);
            txtYas.Multiline = true;
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(36, 18);
            txtYas.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(331, 197);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 2;
            label4.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(388, 197);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(185, 18);
            txtTelefon.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(342, 222);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 2;
            label5.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(388, 221);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(185, 101);
            txtAdres.TabIndex = 3;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Yellow;
            btnYeni.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeni.Location = new Point(381, 355);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(75, 23);
            btnYeni.TabIndex = 4;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.BackColor = Color.Lime;
            btnEkleGuncelle.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkleGuncelle.Location = new Point(476, 355);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(145, 23);
            btnEkleGuncelle.TabIndex = 5;
            btnEkleGuncelle.Text = "Ekle/Guncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = false;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(287, 355);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.new_year_resolutions;
            pictureBox2.Location = new Point(204, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(666, 423);
            Controls.Add(pictureBox2);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnYeni);
            Controls.Add(txtAdres);
            Controls.Add(label5);
            Controls.Add(txtTelefon);
            Controls.Add(label4);
            Controls.Add(txtYas);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(lblad);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblad;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtYas;
        private Label label4;
        private TextBox txtTelefon;
        private Label label5;
        private TextBox txtAdres;
        private ListBox lbPersoneller;
        private Label label6;
        private Button btnYeni;
        private Button btnEkleGuncelle;
        private Button btnSil;
        private PictureBox pictureBox2;
    }
}