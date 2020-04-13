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
    /// Interaction logic for adduser.xaml
    /// </summary>
    public partial class adduser : Window
    {
        public adduser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public string output = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = userbar.Text;


            if (user.Length != 0)
            {

                string path = Environment.CurrentDirectory;
                path += @"\user\";
                path += user;
                path += ".txt";

                if (File.Exists(path))
                {
                    MessageBox.Show("This user is already exist .", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    userbar.Text = "";
                    passbar.Password = "";
                }
                else
                {

                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(passbar.Password);

                    if (Access.IsChecked == true)
                    {
                        writer.WriteLine();
                        writer.WriteLine("ACCESS");
                    }


                    writer.Close();

                    output = userbar.Text;


                    MessageBox.Show("New user added .", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);

                    userbar.Text = "";
                    passbar.Password = "";

                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Username can not be empty .", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Access_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
