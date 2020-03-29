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

        public string output = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userbar.Text;

            string path = @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";
            path += user;
            path += ".txt";

            if (File.Exists(path))
            {
                if (userbar.Text != "Admin")
                {
                    MessageBoxResult r = MessageBox.Show("Are you sure ??", "Delete this user", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (r == MessageBoxResult.Yes)
                    {
                        File.Delete(path);
                        MessageBox.Show("User deleted", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);
                        output = userbar.Text;
                        userbar.Text = "";
                        this.Close();
                    }
                    else
                    {
                        userbar.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("You can't remove your account .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
