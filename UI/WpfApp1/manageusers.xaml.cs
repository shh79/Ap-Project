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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for manageusers.xaml
    /// </summary>
    public partial class manageusers : Window
    {
        public manageusers()
        {
            InitializeComponent();
        }

        private void Add_User_Click(object sender, RoutedEventArgs e)
        {
            adduser win = new adduser();

            win.ShowDialog();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Remove_User_Click(object sender, RoutedEventArgs e)
        {
            removeuser win = new removeuser();

            win.ShowDialog();
        }
    }
}
