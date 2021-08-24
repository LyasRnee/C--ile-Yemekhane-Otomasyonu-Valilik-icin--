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
using System.Threading;

namespace EntityFramework
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
         public YemekhaneYöneticisi yemekhaneYöneticisi;

        Turnike frm2;
        Add addFormu;

        private void metinleriYazdırTurnikeYönet()
        {   //Turnike formunda varsayılan dil ingilizce ise kültürü en-US olarak aç. Değilse Türkçe olarak devam et.
            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            //Localization'dan türkçe ingilizce karşılıklarını text'e atama işlemleri
            frm2.lblBağlantıDurumu.Text = Localization.baglantiDurumu;
            frm2.lblPort.Text = Localization.port;
            frm2.btnBaglan.Text = Localization.bağlan;
            frm2.btnKapat.Text = Localization.kapat;
            frm2.btnBypass.Text = Localization.btnBYPASS;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yemekhaneYöneticisi = new YemekhaneYöneticisi();    //yemekhane formunu bellekte aç

            //metinleriYazdırYemekYönet();  //istenilen dil'e göre textleri ayarlama metodu 

            yemekhaneYöneticisi.Show();   // yemekhane formunu  ekranda goster
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2 = new Turnike();    //turnike formunu bellekte ac
            frm2.Owner = this;

            metinleriYazdırTurnikeYönet();     //istenilen dil'e göre textleri ayarlama metodu 

            frm2.Show();    // yemekhane formunu  ekranda goster

        }
     
        private void metinleriYazdir()
        {   // uygulama çalıştırıldıgında hangi dil varsayılan secilmişse ona gore text isimlerini ayarla.
            if(Settings.Default.dil=="İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            
            btnKullanıcıSistemi.Text = Localization.KullanıcıSistemi;
            btnTurnike.Text = Localization.Turnike;
            lblYemekhaneOtomasyonu.Text = Localization.YemekhaneOtomasyonu;
            dilSeçimiToolStripMenuItem.Text = Localization.menu;
            
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            metinleriYazdir();  //Home formu açıldıgında mentinleri yazdır metodunu çalıştır

        }
        public string dil;
        public void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("");
            Settings.Default.dil = "Türkçe";   //varsayılan dil türkçe olarak seçilmişse settingse ata
            Settings.Default.Save();     // varsayılan dili kaydet
            metinleriYazdir();           // varsayılan dile gore text isimlerini ayarla
            dil = "türkçe";
        }

        public void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("en-US");
            Settings.Default.dil = "İngilizce";      //varsayılan dil ingilizce olarak seçilmişse settingse ata
            Settings.Default.Save();                 // varsayılan dili kaydet
            metinleriYazdir();                       // varsayılan dile gore text isimlerini ayarla
            dil = "ingilizce";

        }
        
    }
}
