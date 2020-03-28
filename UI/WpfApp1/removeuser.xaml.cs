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
    /// Interaction logic for removeuser.xaml
    /// </summary>
    public partial class removeuser : Window
    {
        public removeuser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userbar.Text;

            string path = @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";
            path += user;
            path += ".txt";

            if (File.Exists(path))
            {
                MessageBoxResult r = MessageBox.Show("Are you sure ??", "Delete this user", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (r == MessageBoxResult.Yes)
                {
                    File.Delete(path);
                    MessageBox.Show("User deleted", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);
                    userbar.Text = "";
                }
                else
                {
                    userbar.Text = "";
                }
            }
            else
            {

                MessageBox.Show("There isn't this user .", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
                userbar.Text = "";
                

            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
