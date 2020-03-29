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
    /// Interaction logic for changename.xaml
    /// </summary>
    public partial class changename : Window
    {
        public changename()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";

            string name = loginpass.user;

            path += name;
            path += ".txt";

            string path2 = @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";
            path2 += userbar.Text;
            path2 += ".txt";

            string pass = "";
            string check = "";

            StreamReader reader = new StreamReader(path);
            pass = reader.ReadLine();
            reader.ReadLine();
            check = reader.ReadLine();
            reader.Close();

            if (passbar.Password == pass)
            {
                if (File.Exists(path2))
                {
                    MessageBox.Show("This name is already exist .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    System.IO.File.Move(path, path2);
                    loginpass.user = userbar.Text;
                    MessageBox.Show("Your username is changed .", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
