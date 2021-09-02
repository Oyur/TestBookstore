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
    /// Interaction logic for TransactionSearch.xaml
    /// </summary>
    public partial class TransactionSearch : Window
    {
        public TransactionSearch()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("ISBN : " + TransactionData.GetData(Listbox.Text)[1].ToString() + "\n" + "Customer : " + TransactionData.GetData(Listbox.Text)[2].ToString() + "\n" + "Quantity : " + TransactionData.GetData(Listbox.Text)[3].ToString() + "\n" + "Price : " + TransactionData.GetData(Listbox.Text)[4].ToString()); 
            //ปุ่มกดเพื่อค้นหาข้อมูลของ Transaction
        }
    }
}
