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
    /// Interaction logic for CustomerAddDelete.xaml
    /// </summary>
    public partial class CustomerAddDelete : Window
    {
        public CustomerAddDelete()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerData.AddData(CustomerIDbox.Text, CustomerNamebox.Text, CustomerAddressbox.Text, CustomerEmailbox.Text);
            MessageBox.Show("Add Information Complete");
            //เรียกใช้methodเพื่อเพิ่มข้อมูลลงใน Customertable
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerData.UpdateData(CustomerIDbox.Text, CustomerNamebox.Text, CustomerAddressbox.Text, CustomerEmailbox.Text);
            MessageBox.Show("Update Information Complete");
            //เรียกใช้ข้อมูลmethodเพื่อแก้ไขข้อมูลใน Cusotmertable
        }
    }
}
