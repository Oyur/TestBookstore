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
    /// Interaction logic for Booksearch.xaml
    /// </summary>
    public partial class Booksearch : Window
    {
        public Booksearch()
        {
            InitializeComponent();
        }

        private void SearchBookbtn_Click(object sender, RoutedEventArgs e)
        {
            string data = "";
            foreach (string isbn in BookData.GetData(BookSearchbox.Text))
            {
                data = data + isbn + "\n";
            }
            MessageBox.Show(data);
            //ปุ่มเรียกใช้method เพื่อค้นหาข้อมูลทั้งหมดจาก Booktable
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            BookData.DeleteBookData(BookSearchbox.Text);
            MessageBox.Show("Delete Complete");
            //ปุ่มเรียกใช้method เพื่อลบข้อมูลออกจากBooktable
        }

        private void Add_Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            BookAddDelete bookadddelete = new BookAddDelete();
            bookadddelete.Show();
            //ปุ่มกดเพื่อไปหน้าของ AddDelete
        }
    }
}
