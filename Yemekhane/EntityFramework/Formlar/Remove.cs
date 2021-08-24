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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
            metinleriyazdırRemove();
        }
        ProductDal _productDal = new ProductDal();
        private void Remove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTradeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.eTradeDataSet.Products);

            LoadProducts();   //remove formu çalıstırıldıgında otomatik olarak veritabanındaki butun listeyi getir.
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();  //datagriview kaynagını productdalGettAll olarak ayarladık
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   // hangi satır secildiyse o satırı sil

            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();  //silindikten sonra tekrar datagridview'i güncelle.
            MessageBox.Show("Deleted!");
        }

        private void button1_Click(object sender, EventArgs e)
        {  //GetByCartId butonuna basıldıgında dene eger kart id si varsa onun bilgilerini ekrana getir
            try
            {
                long value = Convert.ToInt64(tbxGetByCartIdRemoveEkranı.Text);
                dgwProducts.DataSource= _productDal.GetByCarttId(value);
            }
            catch
            {
                MessageBox.Show("Lütfen Bir Kart Id giriniz.");
            }
        }

        private void refreshRemoveEkranı_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        internal void metinleriyazdırRemove()
        {  //varsayılan dile gore text isimlerini atıyoruz.

            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }

            button1.Text = Localization.CartIdAl;
            refreshRemoveEkranı.Text = Localization.yenile;
            lblAciklama4.Text = Localization.lblaciklama4;
            btnRemove.Text = Localization.btnRemove;
            dgwProducts.Columns[0].HeaderText = Localization.dgwId;
            dgwProducts.Columns[1].HeaderText = Localization.dgwKartNumarası;
            dgwProducts.Columns[2].HeaderText = Localization.dgwIsim;
            dgwProducts.Columns[3].HeaderText = Localization.dgwSoyisim;
            dgwProducts.Columns[4].HeaderText = Localization.dgwKartTipi;
            dgwProducts.Columns[5].HeaderText = Localization.dgwBakiye;
            dgwProducts.Columns[6].HeaderText = Localization.dgwYemekUcreti;
        }
    }
}
