using System;
using System.Collections;
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
    /// Interaction logic for Customersearch.xaml
    /// </summary>
    public partial class Customersearch : Window
    {
        public Customersearch()
        {
            InitializeComponent();
            
        }

        private void csidsearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cssearchbtn_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            foreach (string name in CustomerData.GetData(csidsearch.Text))
            {
                data = data + name + "\n";
            }
            MessageBox.Show(data);
            //เรียกใช้methodแสดงข้อมูลทั้งหมดจากCustomer_id
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerData.DeleteCustomerData(csidsearch.Text);
            MessageBox.Show("Delete ID" + csidsearch.Text + "Complete");
            //เรียกใช้methodเพื่อลบข้อมูล จากCustomer_id
        }

        private void Add_or_Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerAddDelete customeradddelete = new CustomerAddDelete();
            customeradddelete.Show();
            //ปุ่มกดเพื่อเข้าไปสู่หน้า Add or Update ข้อมูล
        }
    }
}
