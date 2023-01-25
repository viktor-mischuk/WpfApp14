using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Арбуз",
                Price = 50,
                Image = "Image/watermelon.jpg",
                Product_Category = Product_Category.Food
            }); 
            products.Add(new Product()
            {
                Name = "Спаржа",
                Price = 100,
                Image = "Image/asparagus.jpg",
                Product_Category = Product_Category.Food
            }); 
            products.Add(new Product()
            {
                Name = "Авокадо",
                Price = 70,
                Image = "Image/avocado.jpg",
                Product_Category = Product_Category.Food
            });            
            products.Add(new Product()
            {
                Name = "Микроволновка",
                Price = 70,
                Image = "Image/microwave.jpg",
                Product_Category = Product_Category.Appliances
            }); 
            products.Add(new Product()
            {
                Name = "Мультиварка",
                Price = 200,
                Image = "Image/slow_cooker.jpg",
                Product_Category = Product_Category.Appliances
            }); 
            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 150,
                Image = "Image/spot.jpg",
                Product_Category = Product_Category.Appliances
            });   
            products.Add(new Product()
            {
                Name = "Стиральная машина",
                Price = 400,
                Image = "Image/washer.jpg",
                Product_Category = Product_Category.Appliances
            });
            products.Add(new Product()
            {
                Name = "Миндаль",
                Price = 10,
                Image = "Image/almond.jpg",
                Product_Category = Product_Category.Food
            });
            listBox.ItemsSource = products;
        }
    }
}
