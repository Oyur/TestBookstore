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
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
            
        }
        
        private void Confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            TransactionData.AddData(ISBNbox2.Text, CustomerIDbox.Text, int.Parse(Quantitybox.Text), int.Parse(Totalpricebox.Text));
            MessageBox.Show("Confirm" + "\n" + "List : " + TransactionData.Getlastlist()[0] + "\n" + "CustomerID : " + CustomerIDbox.Text + "\n" + "ISBN : " + ISBNbox2.Text + "\n" + "Quantity : " + Quantitybox.Text + "\n" + "TotalPrice : " + Totalpricebox.Text);
            //ปุ่มกดเพื่อยืนยันคำสั่งซื้อพร้อมแสดงข้อมูลทั้งหมดในการสั่งซื้อ
        }

        private void BookInfobox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
        int totalprice = 0;
        private void Totalpricebox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void CheckTotalPricebtn_Click(object sender, RoutedEventArgs e)
        {
            string information = "";
            foreach (string isbn in BookData.GetData(ISBNbox2.Text))
            {
                information = information + isbn + "\n";
            }
            BookInfobox.Text = information;
            string data = "";
            foreach (string isbn in BookData.GetPrice(int.Parse(ISBNbox2.Text)))
            {
                data = data + isbn;
            }
            totalprice = int.Parse(Quantitybox.Text) * int.Parse(data);
            Totalpricebox.Text = totalprice.ToString();
            //ปุ่มกดเพื่อเช็คราคาการซื้อหนังสือทั้งหมด พร้อมแสดงข้อมูลหนังสือลงในช่อง Bookinfobox
        }
    }
}
