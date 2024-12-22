using Chua_De_07.Models;
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

namespace Chua_De_07
{
    /// <summary>
    /// Interaction logic for Manhinh2.xaml
    /// </summary>
    public partial class Manhinh2 : Window
    {
        public Manhinh2()
        {
            InitializeComponent();
        }
        QlduocPhamContext db = new QlduocPhamContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dgThuoc.ItemsSource = (from x in db.Thuocs
            //                       join y in db.DanhMucThuocs
            //                       on x.MaDm equals y.MaDm
            //                       group new { x, y } by x.MaDm into LspGroup
            //                       select new
            //                       {
            //                           MaDm = LspGroup.Key,
            //                           TenDm = LspGroup.FirstOrDefault().y.TenDm,
            //                           Tong = LspGroup.Sum(g => g.x.SoLuong*g.x.GiaBan)
            //                       }).ToList();


        }
    }
}
