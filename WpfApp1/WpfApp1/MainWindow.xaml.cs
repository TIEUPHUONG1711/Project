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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Database1Entities db = new Database1Entities();
        private SACH svchon;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            tablee.ItemsSource = db.SACHes.ToList();
            theloai.ItemsSource = db.THELOAIs.ToList();
            theloai.DisplayMemberPath = "TenTL";
            theloai.SelectedValuePath = "MaTL";
        }

        private int Laytheloai()
        {
            if (theloai.SelectedValue != null) return int.Parse(theloai.SelectedValue.ToString());
            return 0;
        }

        private void xoatrang()
        {
            masach.Text = null;
            tacgia.Text = null;
            theloai.SelectedIndex = -1;
            tensach.Text = null;
            namxb.Text = null;

        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {

            SACH sach = new SACH()
            {
             
                TacGia = tacgia.Text.Trim(),
                TuaSach = tensach.Text.Trim(),
                NamXB = int.Parse(namxb.Text.Trim()),
                MaTL = Laytheloai()

            };
            db.SACHes.Add(sach);
            db.SaveChanges();
            MessageBox.Show("đã thêm sách mới vào!");
            LoadData();
            xoatrang();
        }

        private void Sua_Click(object sender, RoutedEventArgs e)
        {
            if(svchon == null)
            {
                MessageBox.Show("Vui lòng chọn 1 sách!");
            }
            else
            {
                SACH sach = db.SACHes.Find(svchon.MaSach);
                
                sach.TacGia = tacgia.Text.Trim();
                sach.MaTL = Laytheloai();
                sach.TuaSach = tensach.Text.Trim();
                sach.NamXB = int.Parse(namxb.Text.Trim());

                db.SaveChanges();
                MessageBox.Show("đã sửa!");
              
            }
            LoadData();
            xoatrang();
        }

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TimKiem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {

        }

        private void grid_table(object sender, SelectionChangedEventArgs e)
        {
            svchon = tablee.SelectedItem as SACH;
            if(svchon != null)
            {
                masach.Text = svchon.MaSach.ToString();
                tacgia.Text = svchon.TacGia;
                theloai.SelectedValue = svchon.MaTL;
                tensach.Text = svchon.TuaSach;
                namxb.Text = svchon.NamXB.ToString();
            }
        }
    }
}
