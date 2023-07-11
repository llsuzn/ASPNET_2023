using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Watermelon
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void 딸기우유_Click(object sender, RoutedEventArgs e)
        {
            var login = new login();
            login.Owner = this;
            login.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            login.ShowDialog();
        }

        private void 사이다_Click(object sender, RoutedEventArgs e)
        {
            var login = new login();
            login.Owner = this;
            login.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            login.ShowDialog();
        }

        private void 요구르트_Click(object sender, RoutedEventArgs e)
        {
            var login = new login();
            login.Owner = this;
            login.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            login.ShowDialog();
        }

        private void 밀키스_Click(object sender, RoutedEventArgs e)
        {
            var login = new login();
            login.Owner = this;
            login.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            login.ShowDialog();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            var result = new result();
            result.Owner = this;
            result.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            result.ShowDialog();
        }
    }
}
