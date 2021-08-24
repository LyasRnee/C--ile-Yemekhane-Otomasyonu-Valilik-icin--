using EntityFramework.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekhane;



namespace EntityFramework
{
    public partial class YemekhaneYöneticisi : Form
    {  // form isimlerini tanımladık
        public Add add;
        public Update update;
        public Remove remove;
        public Topluİslemler topluİslemler;
        public YemekhaneYöneticisi()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();  // productdal sınıfından baglantı actık
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTradeDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter2.Fill(this.eTradeDataSet2.Products);
            // TODO: This line of code loads data into the 'eTradeDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.eTradeDataSet1.Products);
            // TODO: This line of code loads data into the 'eTradeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.eTradeDataSet.Products);

            metinleriYazdırYemekYönet();  // seçilen dile gore text isimlerini ayarlıyoruz
            LoadProducts();  // form acıldıgında datagridview'a veritabanındaki bilgileri çekiyoruz
        }

        private void metinleriYazdırYemekYönet()
        {   //yemekhaneformunda varsayılan dil ingilizce ise kültürü en-US olarak aç. Değilse Türkçe olarak devam et.
            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            //Localization'dan türkçe ingilizce karşılıklarını text'e atama işlemleri

            btnGetByCartId.Text = Localization.CartIdAl;
            AddGit.Text = Localization.KullanıcıEkle;
            btnUpdateGit.Text = Localization.KullanıcıDüzenle;
            btnRemoveGit.Text = Localization.KullanıcıSil;
            lblSearch.Text = Localization.isimAra;
            btnrefresh.Text = Localization.yenile;
            btnTopluİslemler.Text = Localization.YemekhaneYöneticiTopluİslemlerButon;
            dgwProducts.Columns[0].HeaderText = Localization.dgwId;
            dgwProducts.Columns[1].HeaderText = Localization.dgwKartNumarası;
            dgwProducts.Columns[2].HeaderText = Localization.dgwIsim;
            dgwProducts.Columns[3].HeaderText = Localization.dgwSoyisim;
            dgwProducts.Columns[4].HeaderText = Localization.dgwKartTipi;
            dgwProducts.Columns[5].HeaderText = Localization.dgwBakiye;
            dgwProducts.Columns[6].HeaderText = Localization.dgwYemekUcreti;
            dgwProducts.Columns[7].HeaderText = Localization.dgwGun;

        }
        private void LoadProducts()
        {   //datagridview'in kaynaıgı veritabanından al diyoruz
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {  // isme gore arama yapılıyor
            var result = _productDal.GetAll().Where(p=>p.FirstName.ToLower().Contains(key.ToLower())).ToList();
            //var result= _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);  // hangi isim girildiyse ona gore arama  yapıyoruz
        }

        private void AddGit_Click(object sender, EventArgs e)
        {
            add = new Add();  // add butonunabasıldıgında o formu ac
            add.ShowDialog();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();  // yenile butonuna basıldıgında datagirview'deki bilgileri yenile
        }

        private void btnUpdateGit_Click(object sender, EventArgs e)
        {
            update = new Update(); // update butonunabasıldıgında o formu ac
            update.ShowDialog();
        }

        private void btnRemoveGit_Click(object sender, EventArgs e)
        {
            remove = new Remove();  // remove butonunabasıldıgında o formu ac
            remove.ShowDialog();
        }       

        private void btnGetByCartId_Click(object sender, EventArgs e)
        {   // istenilen kart numarasına gore arama yapma işlemi
            try
            {
                long value = Convert.ToInt64(tbxSearchCartId.Text);
                dgwProducts.DataSource = _productDal.GetByCarttId(value);
            }
            catch
            {
                MessageBox.Show("Lütfen Bir Kart Id giriniz.");
            }

        }

        private void btnTopluİslemler_Click(object sender, EventArgs e)
        {
            topluİslemler = new Topluİslemler();   // topluişlemler butonunabasıldıgında o formu ac
            topluİslemler.ShowDialog();
        }
    }
}
