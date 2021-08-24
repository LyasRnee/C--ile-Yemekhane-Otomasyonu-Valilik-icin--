using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekhane
{
    public class Product
    {                                    //Bu sınıfta değişkenlerimizi tanımladık
        public int Id { get; set; }
        public long CartId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardType { get; set; }
        public double Balance { get; set; }
        public double FoodPrice { get; set; }
        public double Gun { get; set; }
        public double MisafirUcreti { get; set; }
    }
}
