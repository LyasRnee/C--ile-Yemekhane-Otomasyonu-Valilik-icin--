using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Yemekhane
{

    public class ProductDal
    {  
        public List<Product> GetAll()  //burada entityframework ile Porudcts'taki butun bilgileri alıyoruz
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
                
            }

        }
        public List<Product> GetByCarttId(long cartid)
        {  // dısarıdan gonderdigimiz cartid ile arama yapıp geri donderiyoruz

            return GetAll().Where(p => p.CartId == cartid).ToList();
            
        }

        
        public void Add(Product product)
        {  //veritabanına product ekleme metodu
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Added;

                ProductValidator productvalidator = new ProductValidator(); //eklenen bilgiler kurallara uygunmu kontrol ediyoruz
                var result=productvalidator.Validate(product);
                if(result.Errors.Count>0)
                {
                    throw new ValidationException(result.Errors);
                }
                context.SaveChanges(); // kurallara uyulmuşsa kaydediyoruz
                
            }
        }

        public void Update(Product product)
        {  // herhangi bir ürünü güncelleme metodu
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                
                context.SaveChanges();

            }
        }

        public void Delete(Product product)
        {// herhangi bir urunu silme işlemi
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public void sqlSorgu(double kalanBakiye,long id)
        {  //sorgu ile bakiye güncelleme işlemi
            using (ETradeContext context = new ETradeContext())
            {
                const string sql= "update Products set Balance={0} Where CartId={1}";
                context.Database.ExecuteSqlCommand(sql,kalanBakiye,id);
                context.SaveChanges();
            }
        }

        public void sqlSorgu2(double gun, long id)
        { // sorgu ile gün güncelleme işemi
            using (ETradeContext context = new ETradeContext())
            {
                const string sql = "update Products set Gun={0} Where CartId={1}";
                context.Database.ExecuteSqlCommand(sql, gun, id);
                context.SaveChanges();
            }
        }


    }
}
