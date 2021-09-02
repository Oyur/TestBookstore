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
    /// Interaction logic for BookAddDelete.xaml
    /// </summary>
    public partial class BookAddDelete : Window
    {
        public BookAddDelete()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            BookData.AddData(Titlebox.Text, Descriptionbox.Text, Pricebox.Text);
            MessageBox.Show("Add Information Complete");
            //ปุ่มกดเพื่อเพิ่มข้อมูลหนังสือลงใน Booktable
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            BookData.UpdateData(ISBNbox.Text, Titlebox.Text, Descriptionbox.Text, int.Parse(Pricebox.Text));
            MessageBox.Show("Update Information Complete");
            //ปุ่มกดเพื่อแก้ไขข้อมูลหนังสือ
        }
    }
}
