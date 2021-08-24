using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekhane;

namespace EntityFramework.Formlar
{
    public partial class Topluİslemler : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True");
        public Topluİslemler()
        {
            InitializeComponent();
            metinleriyazdır();
        }

        private void btnMisUcrKaydet_Click(object sender, EventArgs e)
        {
            double MisafirÜcret = Convert.ToDouble(tbxMisUcr.Text);  // yazılan texti al double a donustur MisafirÜcret'e ata

            using (ETradeContext context = new ETradeContext())    //entityframework u kullanarak  Products veritabanına sorgu yollama
            {
                const string sql = "update Products set MisafirUcreti={0} ";
                context.Database.ExecuteSqlCommand(sql, MisafirÜcret);
                context.SaveChanges();
            }

            MessageBox.Show("Misafir Ücreti " + MisafirÜcret + " olarak değiştirildi");
        }

        private void btnYemUcrKaydet_Click(object sender, EventArgs e)
        {
            double YemekÜcret = Convert.ToDouble(tbxYemekUcret.Text);  // yazılan texti al double a donustur YemekÜcret'e ata , Müdür için

            using (ETradeContext context = new ETradeContext())     //entityframework u kullanarak  Products veritabanına sorgu yollama
            {
                const string sql = "update Products set FoodPrice={0} Where CardType='Müdür' ";   // tum mudurlerin FoodPrice'ını guncelle
                context.Database.ExecuteSqlCommand(sql, YemekÜcret);
                context.SaveChanges();
            }

            MessageBox.Show("Yemek Ücreti(Müdür) " + YemekÜcret + " olarak değiştirildi");

        }

        private void button1_Click(object sender, EventArgs e)
        {         // Log kayıtlarını silme işlemi 
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Delete From Logs ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            MessageBox.Show("Log Kayıtları Silinmistir");
        }

        private void btnMemurBkySifirla_Click(object sender, EventArgs e)
        {  //entityframeworku kullanarak tüm memurların bakiyesini sıfırlama işlemi
            using (ETradeContext context = new ETradeContext())
            {
                const string sql = "update Products set Balance={0} Where CardType='Memur' ";
                context.Database.ExecuteSqlCommand(sql, 0);
                context.SaveChanges();
            }

            MessageBox.Show("Tüm Memurların Bakiyesi Sıfırlandı!");
        }

        private void btnYemUcrKaydetMemur_Click(object sender, EventArgs e)
        {
            double YemekÜcret2 = Convert.ToDouble(tbxYemUcrMemur.Text);   // yazılan texti al double a donustur YemekÜcret'e ata , Memur için

            using (ETradeContext context = new ETradeContext())  //entityframework u kullanarak  Products veritabanına sorgu yollama
            {
                const string sql = "update Products set FoodPrice={0} Where CardType='Memur' ";    // tum memurların FoodPrice'ını guncelle
                context.Database.ExecuteSqlCommand(sql, YemekÜcret2);
                context.SaveChanges();
            }

            MessageBox.Show("Yemek Ücreti(Memur) " + YemekÜcret2 + " olarak değiştirildi");
        }
        internal void metinleriyazdır()
        {  // varsayılan dile gore text leri ayarlıyoruz.

            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            lblMisafirUcreti.Text = Localization.TopluİslemlblMisafirUcreti;
            lblYemekUcretMudur.Text = Localization.TopluİslemlblYemekUcretiMudur;
            lblYemUcrMemur.Text = Localization.TopluİslemlblYemekUcretiMemur;
            label2.Text = Localization.TopluİslemlblMemurBakiyeSifirla;
            label1.Text = Localization.TopluİslemlblLogKaydıSilme;
            btnMisUcrKaydet.Text = Localization.TopluİslembtnKaydet;
            btnYemUcrKaydet.Text=Localization.TopluİslembtnKaydet;
            btnYemUcrKaydetMemur.Text=Localization.TopluİslembtnKaydet;
            btnMemurBkySifirla.Text = Localization.TopluİslembtnBakiyeSifirlaMemur;
            button1.Text = Localization.TopluİslembtnKayitlariSil;

        }
    }
}
