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
    public partial class Add : Form
    {
        Home home = (Home)Application.OpenForms["Home"];
        public Add()
        {
            InitializeComponent();
            metinleriyazdır();   // Burada hangi dil seçildiyse onu aktif ediyor.
            
        }
        ProductDal _productDal = new ProductDal();
        private void btnAdd_Click(object sender, EventArgs e)
        {        // ekle butonuna basıldıgında bütün bilgiler doldurulduysa o bilgileri veritabanına ekliyor.
            try
            {
                _productDal.Add(new Product
                {
                    CartId = Convert.ToInt64(tbxCartId.Text),
                    FirstName = tbxName.Text,
                    LastName = tbxLastName.Text,
                    CardType = (string)comboBox1.SelectedItem,
                    Balance = Convert.ToDouble(tbxBalance.Text),
                    FoodPrice = Convert.ToDouble(tbxFoodPrice.Text),
                    Gun= Math.Round(Convert.ToDouble(tbxBalance.Text) / Convert.ToDouble(tbxFoodPrice.Text), 2),
                    MisafirUcreti=Convert.ToDouble(tbxAddMisUcr.Text)

                });
                MessageBox.Show("Added!");
            }
            catch
            {
                MessageBox.Show("Belirtilen Kurallara Uyunuz!(Boş Bırakmayınız..)");  //butun bilgiler doldurulmamıs veya kurallara uyulmamıs.
            }
            
            
        }
        internal void metinleriyazdır()
        {  // varsayılan dile gore text leri ayarlıyoruz.
            
            if (Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            btnAdd.Text = Localization.addButonu;
            gbxAdd.Text = Localization.groupBoxIsmi;
            lblCartId.Text = Localization.addlblCartId;
            lblName.Text = Localization.addlblFirstName;
            lblLastName.Text = Localization.addlblLastName;
            lblType.Text = Localization.addlblCartType;
            lblBalance.Text = Localization.addlblBalance;
            lblaciklama1.Text = Localization.lblaciklama1;
            lblFoodPrice.Text = Localization.addlblFoodPrice;
            lblaciklama2.Text = Localization.lblaciklama2;
            comboBox1.Text = Localization.updateChoose;
        }

    }
}
