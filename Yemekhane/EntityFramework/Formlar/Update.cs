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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            metinleriyazdırupdate();  // varsayılan dil'e gore text isimlerini ayarlıyoruz

        }
        ProductDal _productDal = new ProductDal();
        
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTradeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.eTradeDataSet.Products);
            LoadProducts();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try  //güncelle butonuna basdıgında butun bilgiler eklendiyse bunu veritabanına kaydet.
            {
                _productDal.Update(new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    CartId = Convert.ToInt64(tbxCartIdUpdate1.Text),
                    FirstName = tbxNameUpdate.Text,
                    LastName = tbxLastNameUpdate.Text,
                    CardType = (string)cbxTypeUpdate.Text,
                    Balance = Convert.ToDouble(tbxBalanceUpdate.Text),
                    FoodPrice = Convert.ToDouble(tbxFoodPriceUpdate.Text),
                    Gun= Math.Round(Convert.ToDouble(tbxBalanceUpdate.Text)/ Convert.ToDouble(tbxFoodPriceUpdate.Text),2),
                    MisafirUcreti=Convert.ToDouble(tbxUpdateMisUcr.Text)

                }); LoadProducts();  // guncellendikten sonra datagridview'inde guncellenmesini saglıyoruz
                MessageBox.Show("Updated!");
            }catch
            {  // bilgiler ya bos bırakılmıstır yada kurallara uyulmamıstır.
                MessageBox.Show("Belirtilen Kurallara Uyunuz");
            }
        }

        private void dgwProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {  // hangi hucre seçilmişse oradaki bilgileri alttaki textbox'lara atıyoruz
            tbxCartIdUpdate1.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxLastNameUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            cbxTypeUpdate.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxBalanceUpdate.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
            tbxFoodPriceUpdate.Text = dgwProducts.CurrentRow.Cells[6].Value.ToString();
        }
       

        private void btnGetByCartIdUpdateEkranı_Click(object sender, EventArgs e)
        {      // istenilen kart numarasını girip datagridview'den eşleştiriyoruz
            try
            {
                long value = Convert.ToInt64(tbxSearchCartIdUpdateEkranı.Text);
               dgwProducts.DataSource= _productDal.GetByCarttId(value);
            }catch
            {  // hataya dustuyse kart numarası girilmeden butona basılmıs demektir
                MessageBox.Show("Lütfen Bir Kart Id giriniz.");
            }

        }

        private void btnRefreshUpdateEkranı_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        internal void metinleriyazdırupdate()
        {
            //hangi dil seçili ise text isimlerini ona gore atıyoruz.
            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            btnGetByCartIdUpdateEkranı.Text = Localization.CartIdAl;
            btnRefreshUpdateEkranı.Text = Localization.yenile;
            lblaciklama3.Text = Localization.lblaciklama3;
            gbxUpdate.Text = Localization.groupBoxUpdateIsmi;
            lblUnitPriceUpdate.Text = Localization.addlblCartId;
            lblNameUpdate.Text = Localization.addlblFirstName;
            lblStockAmountUpdate.Text = Localization.addlblLastName;
            lblUpdateType.Text = Localization.addlblCartType;
            lblUpdateBalance.Text = Localization.addlblBalance;
            //lblUpdateAciklama1.Text = Localization.lblaciklama1;
            lblFoodPrice.Text = Localization.addlblFoodPrice;
            //lblUpdateAciklama2.Text = Localization.lblaciklama2;
            btnUpdate.Text = Localization.guncelleButonu;
            cbxTypeUpdate.Text = Localization.updateChoose;
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
