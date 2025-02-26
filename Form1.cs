
using System.ComponentModel;

namespace PersonelApp
{
    public partial class Form1 : Form
    {
        BindingList<Personel> liste = new(); 
        Personel gosterilenPersonel;

        public Form1()
        {
            InitializeComponent();

           
            lbPersoneller.DataSource = liste;
            lbPersoneller.DisplayMember = "AdSoyad";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            YeniEkle();
        }

        void YeniEkle()
        {
            Personel yeniPers = new();
            
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Yas = Convert.ToInt32(txtYas.Text);
            yeniPers.Tel = txtTelefon.Text;
            yeniPers.Adres = txtAdres.Text;

            
            liste.Add(yeniPers);
            
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            
            txtAd.Focus();
        }

        private void lbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Personel pers = lbPersoneller.SelectedItem as Personel;

            if (pers != null)
            {
                
                txtAd.Text = pers.Ad;
                txtSoyad.Text = pers.Soyad;
                txtYas.Text = pers.Yas.ToString();
                txtTelefon.Text = pers.Tel;
                txtAdres.Text = pers.Adres;

                gosterilenPersonel = pers;
            }

        }
    }
}