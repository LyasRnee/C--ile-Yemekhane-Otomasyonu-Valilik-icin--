using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekhane;

namespace EntityFramework
{
    public partial class Turnike : Form
    {

        string[] portlar = SerialPort.GetPortNames();     //port isimlerini string dizisine ekle

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True"); //veritabanına baglantı actım

        public Turnike()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }
        Home anasayfa = (Home)Application.OpenForms["Home"];
        YemekhaneYöneticisi YemekYonet = (YemekhaneYöneticisi)Application.OpenForms["YemekhaneYöneticisi"];

        ProductDal productDal = new ProductDal();
     
        private void Turnike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTradeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.eTradeDataSet.Products);

            // bütün portları gezip combobox'a ekleme
            foreach (string port in portlar)
            {
                
                cbxPortlar.Items.Add(port);
                cbxPortlar.SelectedIndex = 0;
            }          
           
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {     //port açık degilse kontrol edip açma işlemi
            if(!serialPort1.IsOpen)
            {    //combobox'tan bağlı olan portu tanımlama 
                try
                {
                    serialPort1.PortName = cbxPortlar.Text;
                }
                catch { MessageBox.Show("Port Seçiniz"); }
                try
                {  //portu aç
                    serialPort1.Open();
                    lblPort.ForeColor = Color.Green;   //label rengini yeşil yapma işlemi
                    lblPort.Text = "Bağlantı Açık";
                    
                }
                catch(Exception)
                {
                    MessageBox.Show("Bağlantıda Sorun Var!");
                }
                
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //seriportdan gelen bilgiyi al

            }
            else
            {
                lblPort.Text = "Bağlantı Kurulu!";
            }
            
        }
        string[] gelenbilgi;
        string kartNumara, isim, soyisim, cartTipi, bakiyee, yemekucretii;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            Thread.Sleep(30);
            string data = serialPort1.ReadLine();   // seri porttan gelen verileri oku


            gelenbilgi = data.Split('/');      // slash işaretini gordugu an bilgiyi al tbxgelenid'ye yazdır.
            tbxGelenId.Text = gelenbilgi[0];

            formkontrol();    //rfidden okuttugumuz kartların id'sini hangi form açıksa oradaki cart ıd textbox'ına yazdır

            dgwTurnike.DataSource = productDal.GetByCarttId(Convert.ToInt64(gelenbilgi[0]));
            string satırSayısı =dgwTurnike.RowCount.ToString();



            if (satırSayısı == "1")
            {
                kartTipiKontrol();  // kart tipi mudur mu memur mu supervisior mu kontrol ediliyor

                          ////LOGLAMA KODLARI
                kartNumara = dgwTurnike.CurrentRow.Cells[1].Value.ToString();
                isim = dgwTurnike.CurrentRow.Cells[2].Value.ToString();
                soyisim = dgwTurnike.CurrentRow.Cells[3].Value.ToString();
                cartTipi = dgwTurnike.CurrentRow.Cells[4].Value.ToString();
                bakiyee = dgwTurnike.CurrentRow.Cells[5].Value.ToString();
                yemekucretii = dgwTurnike.CurrentRow.Cells[6].Value.ToString();

                if (kartTipi == "SuperVisior")
                {
                   serialPort1.Write("5");  //seriporta 5 rakamını gonder , yeşil led yakma işlemi

                    if (Application.OpenForms.OfType<YemekhaneYöneticisi>().Count() == 0)
                    {  // YemekhaneYonetici formu acık degilse Logs veritabanına bilgileri kaydet
                        using (ETradeContext context = new ETradeContext())
                        {
                            context.Database.ExecuteSqlCommand("Insert into Logs (Tarih, Saat, KartNumara, isim, Soyisim, KartTipi,Bakiye,YemekUcreti) Values({0},{1},{2},{3},{4},{5},{6},{7})",
                                dtt.Date, dtt.ToLongTimeString(), gelenbilgi[0].ToString(), isim, soyisim, cartTipi, bakiyee, yemekucretii);
                            context.SaveChanges();

                        }
                        //con.Open();  //bağlantı ac kartnumara ve tarihi eşleşen kayıtları getir
                        //SqlDataAdapter da = new SqlDataAdapter("Select * From Logs ", con);                        
                        //DataTable dt = new DataTable();
                        //da.Fill(dt);
                        //dgwToplamYemSay.DataSource = dt;
                        //int Topsatırsayı = dgwLog.RowCount;
                        ////Topsatırsayı = Topsatırsayı - 1;
                        //tbxTopYenYemSay.Text = Topsatırsayı.ToString();
                        //con.Close();  // bağlantı kapat
                    }
                    
                }
                else if(kartTipi == "Mudur")
                {
                    bilgiAl();

                }

                else if (kartTipi == "Memur")
                {
                    bilgiAl2();

                }
            }

            else
            {
                  serialPort1.Write("6");
                  //MessageBox.Show("Kartınız Tanımlı Değil..");
             }
            

        }

        private void Turnike_FormClosed(object sender, FormClosedEventArgs e)
        {   //formu kapatırken otomatik seriportun kapanmasını sağlıyoruz.

            if(serialPort1.IsOpen==true)
            {
                serialPort1.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)       // kapat butonuna basıldıgında eger port acıksa kapat
            {
                serialPort1.Close();
                lblPort.ForeColor = Color.Red;      // label rengini kırmızı yap
                lblPort.Text = "Bağlantı kapalı!";
            }
        }

        private void btnLedAc_Click(object sender, EventArgs e)
        {
            try
            { serialPort1.Write("1"); }
            catch
            {
                MessageBox.Show("Lütfen Seriport ile bağlantı kurunuz!");
            }
        }

        private void btnLedKapa_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch
            {
                MessageBox.Show("Lütfen Seriport ile bağlantı kurunuz!");
            }

        }
        private void formkontrol()
        {
            if (Application.OpenForms.OfType<Add>().Count() == 1)    //add formunun acık olup olmadıgı kontrol ediliyor. alttaki else if'lerde aynı mantık
            {
                anasayfa.yemekhaneYöneticisi.add.tbxCartId.Text = gelenbilgi[0];    //add formu acıksa cartid textine yazdır
            }
            else if (Application.OpenForms.OfType<Update>().Count() == 1)
            {
                anasayfa.yemekhaneYöneticisi.update.tbxSearchCartIdUpdateEkranı.Text = gelenbilgi[0];
            }
            else if (Application.OpenForms.OfType<Remove>().Count() == 1)
            {
                anasayfa.yemekhaneYöneticisi.remove.tbxGetByCartIdRemoveEkranı.Text = gelenbilgi[0];
            }
            else if(Application.OpenForms.OfType<YemekhaneYöneticisi>().Count() == 1)
            {
                anasayfa.yemekhaneYöneticisi.tbxSearchCartId.Text = gelenbilgi[0];
            }
        }


        double KalanBakiye,KalanGun,KalanBakiye2;
        private void bilgiAl()
        {
          if (Application.OpenForms.OfType<YemekhaneYöneticisi>().Count() == 0)
          {
            string Bakiye = dgwTurnike.CurrentRow.Cells[5].Value.ToString();   //dgwnin sütunundaki bilgieri çek
            string YemekFiyati = dgwTurnike.CurrentRow.Cells[6].Value.ToString();
            string gun= dgwTurnike.CurrentRow.Cells[7].Value.ToString();
            string MisafUcret = dgwTurnike.CurrentRow.Cells[8].Value.ToString();
            double doublebakiye =Convert.ToDouble(Bakiye);       //stringi double a donustur.
            double doubleYmkFiyti = Convert.ToDouble(YemekFiyati);
            double MisafUcretDouble = Convert.ToDouble(MisafUcret);
            double result = doublebakiye - doubleYmkFiyti;
            KalanGun =Convert.ToDouble(gun) - 1;
            KalanBakiye2 = doublebakiye - MisafUcretDouble;
            

            KalanBakiye = result;
            if (doublebakiye >= doubleYmkFiyti)  // bakiye yemekfiyatına eşit veya büyükse if' e gir
            {
                con.Open();  //bağlantı ac kartnumara ve tarihi eşleşen kayıtları getir
                SqlDataAdapter da = new SqlDataAdapter("Select * From Logs Where KartNumara=@kn and Tarih=@t ", con);
                da.SelectCommand.Parameters.AddWithValue("@kn", gelenbilgi[0].ToString());
                da.SelectCommand.Parameters.AddWithValue("@t", dtt.Date);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwLog.DataSource = dt;
                int satırsayı = dgwLog.RowCount;
                satırsayı = satırsayı - 1;
                con.Close();  // bağlantı kapat

                    if (satırsayı==0)  // log kaydı yoksa sorguları calıstır yeşil ledi yak (5)
                    {    //Eğer YemekhaneYöneticisi formu acık degilse producDal daki sqlSorgu methodunu calıstır
                        serialPort1.Write("5");
                        productDal.sqlSorgu(KalanBakiye, Convert.ToInt64(gelenbilgi[0]));
                        productDal.sqlSorgu2(KalanGun, Convert.ToInt64(gelenbilgi[0]));
                       
                        using (ETradeContext context = new ETradeContext())
                        {
                            context.Database.ExecuteSqlCommand("Insert into Logs (Tarih, Saat, KartNumara, isim, Soyisim, KartTipi,Bakiye,YemekUcreti) Values({0},{1},{2},{3},{4},{5},{6},{7})",
                                dtt.Date, dtt.ToLongTimeString(), gelenbilgi[0].ToString(), isim, soyisim, cartTipi, bakiyee, yemekucretii);
                            context.SaveChanges();
                        }
                        
                        
                    }
                    else if (satırsayı == 1)  // log kaydında 1 adet bilgi varsa  yeşili yak misafir ucretinden bakiyeyi kes
                    {
                        serialPort1.Write("5");
                        productDal.sqlSorgu(KalanBakiye2, Convert.ToInt64(gelenbilgi[0]));
                        //productDal.sqlSorgu2(KalanGun, Convert.ToInt64(gelenbilgi[0]));
                        
                        using (ETradeContext context = new ETradeContext())  // loga kayıt yapma
                        {
                             context.Database.ExecuteSqlCommand("Insert into Logs (Tarih, Saat, KartNumara, isim, Soyisim, KartTipi,Bakiye,YemekUcreti) Values({0},{1},{2},{3},{4},{5},{6},{7})",
                                 dtt.Date, dtt.ToLongTimeString(), gelenbilgi[0].ToString(), isim, soyisim, cartTipi, bakiyee, yemekucretii);
                             context.SaveChanges();
                        }
                        
                    }
                    else 
                    {  // 2'den fazla eşleşen bilgi varsa kırmızı ledi yak.
                       serialPort1.Write("6");
                        return;                                          
                    }

            }

            else
            {  // bakiye yetersiz ise kırmızı ledi yak 
                serialPort1.Write("6");
                MessageBox.Show("Bakiye yetersiz");
            }
          }
        }

        private void bilgiAl2()
        {   //Eğer YemekhaneYöneticisi formu acık degilse producDal daki sqlSorgu methodunu calıstır
          if (Application.OpenForms.OfType<YemekhaneYöneticisi>().Count() == 0)
          {
            string Bakiye = dgwTurnike.CurrentRow.Cells[5].Value.ToString();   //dgwnin sütunundaki bilgieri çek
            string YemekFiyati = dgwTurnike.CurrentRow.Cells[6].Value.ToString();
            string gun = dgwTurnike.CurrentRow.Cells[7].Value.ToString();
            double doublebakiye = Convert.ToDouble(Bakiye);       //stringi double a donustur.
            double doubleYmkFiyti = Convert.ToDouble(YemekFiyati);
            double result = doublebakiye - doubleYmkFiyti;
            KalanGun = Convert.ToDouble(gun) - 1;


            KalanBakiye = result;
            if (doublebakiye >= doubleYmkFiyti)   // bakiye yemekfiyatına eşit veya büyükse if' e gir
                {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Logs Where KartNumara=@kn and Tarih=@t ", con);
                da.SelectCommand.Parameters.AddWithValue("@kn", gelenbilgi[0].ToString());
                da.SelectCommand.Parameters.AddWithValue("@t", dtt.Date);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwLog.DataSource = dt;
                int satırsayı = dgwLog.RowCount;
                satırsayı = satırsayı - 1;
                con.Close();

                
                    if (satırsayı == 0)  // log kaydı yoksa sorguları calıstır yeşil ledi yak (5)
                    {                      
                        //log tablosuna bak kayıt yoksa işlemler aynen devam edecek. b:
                        productDal.sqlSorgu(KalanBakiye, Convert.ToInt64(gelenbilgi[0]));
                        productDal.sqlSorgu2(KalanGun, Convert.ToInt64(gelenbilgi[0]));
                        //b: log kaydı varsa memursa kırmızı led yanacak , amir ise (misafir_yemegi_tutari=15) bakiye 15 tl olarak düşecek

                        using (ETradeContext context = new ETradeContext())
                        {
                            context.Database.ExecuteSqlCommand("Insert into Logs (Tarih, Saat, KartNumara, isim, Soyisim, KartTipi,Bakiye,YemekUcreti) Values({0},{1},{2},{3},{4},{5},{6},{7})",
                                dtt.Date, dtt.ToLongTimeString(), gelenbilgi[0].ToString(), isim, soyisim, cartTipi, bakiyee, yemekucretii);
                            context.SaveChanges();
                        }
                    
                    serialPort1.Write("5");
                    }
                
                    else
                    {
                    serialPort1.Write("6");
                    // MessageBox.Show("Yemek Limiti aşıldı");
                    
                    }
            }

            else
            {  // bakiye yetersiz ise kırmızı ledi yak
                serialPort1.Write("6");
                MessageBox.Show("Bakiye yetersiz");
            }

          }
        }


        private void btnBypass_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)  //manul olarak geçis izni vermek işin buton ekledim. yeşili yaK(Bağlantı açıksa)
            {
                serialPort1.Write("5");
            }
            else
            {
                MessageBox.Show("Seriport Kapalı!");
            }
            
        }
        

        DateTime dtt;  //global olması icin dısarıda tanımladım
        
        private void timer1_Tick(object sender, EventArgs e)
        {
             dtt = DateTime.Now;  // anlık tarihi alıyoruz
            
        }

        string kartTipi;

        private void kartTipiKontrol()
        {
            kartTipi = dgwTurnike.CurrentRow.Cells[4].Value.ToString();  //dgw nin 5.sutunundakı bilgiyi alıyoruz(kart tipini)
        }
    }
}
