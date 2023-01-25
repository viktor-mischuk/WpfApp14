using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum Product_Category
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public Product_Category Product_Category { get; set; }
    }
}
