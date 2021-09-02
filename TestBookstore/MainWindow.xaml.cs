using System;
using System.Collections.Generic;
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

namespace TestBookstore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //สร้างตาราง Customertable, Booktable, Transaction
            CustomerData.InitializeDatabase();
            BookData.InitializeDatabase();
            TransactionData.InitializeDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ปุ่มกดเข้าMENU Customers
            Customersearch customersearch = new Customersearch();
            customersearch.Show();
        }

        private void Booksbtn_Click(object sender, RoutedEventArgs e)
        {
            //ปุ่มกดเข้าMENU BOOKS
            Booksearch booksearch = new Booksearch();
            booksearch.Show();
        }

        private void Transactionbtn_Click(object sender, RoutedEventArgs e)
        {
            //ปุ่มกดเข้าMENU Transaction
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            //ปุ่มสำหรับกดLOG-IN
            MessageBox.Show("Wellcome to book store");
        }
    }
}
