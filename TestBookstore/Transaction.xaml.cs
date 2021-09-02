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
using System.Windows.Shapes;

namespace TestBookstore
{
    /// <summary>
    /// Interaction logic for Transaction.xaml
    /// </summary>
    public partial class Transaction : Window
    {
        public Transaction()
        {
            InitializeComponent();
            
        }

        private void Searchtbn_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            foreach (string isbn in BookData.GetData(ISBNbox.Text))
            {
                data = data + isbn + "\n";
            }
            MessageBox.Show(data);
            Order order = new Order();
            order.Show();
            //ปุ่่มกดเพื่อค้นหา ISBN จาก Booktable แล้วเข้าสู่หน้าการสั่งซื้อ Order
        }

        private void Listbtn_Click(object sender, RoutedEventArgs e)
        {
            TransactionSearch transactionsearch = new TransactionSearch();
            transactionsearch.Show();
            //ปุ่มกดเพื่อเข้าสู่หน้าต่างค้นหาข้อมูล Transaction
        }
    }
}
