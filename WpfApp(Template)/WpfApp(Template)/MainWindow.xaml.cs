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

namespace WpfApp_Template_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Products.Add(new Product
            {
                Name = "Tea",
                Price = 10,
                IsDiscounted = false
            });

            Products.Add(new Product
            {
                Name = "Coffee",
                Price = 20,
                IsDiscounted = true
            });
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsDiscounted { get; set; }
    }
}
