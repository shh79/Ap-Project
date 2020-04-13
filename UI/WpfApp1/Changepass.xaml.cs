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
    /// Interaction logic for Changepass.xaml
    /// </summary>
    public partial class Changepass : Window
    {
        public Changepass()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            string user = loginpass.user;
            string pass = "";

            string path = Environment.CurrentDirectory;
            path += @"\user\";

            path += user;

            path += ".txt";

            StreamReader reader = new StreamReader(path);

            pass = reader.ReadLine();
            reader.ReadLine();
            string check = reader.ReadLine();

            reader.Close();

            

            if (pass == Cpass.Password)
            {
                if (Npass.Password == RNpass.Password)
                {
                   
                    StreamWriter writer = new StreamWriter(path);

                    writer.WriteLine(Npass.Password);

                    writer.WriteLine();

                    writer.WriteLine(check);

                    writer.Close();

                    MessageBoxResult r = MessageBox.Show("The Password Changed .", "Successful", MessageBoxButton.OK, MessageBoxImage.Information);

                    if (r == MessageBoxResult.OK)
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Your new password is not match .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Current password is wrong .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Cpass.Password = "";
            Npass.Password = "";
            RNpass.Password = "";
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
