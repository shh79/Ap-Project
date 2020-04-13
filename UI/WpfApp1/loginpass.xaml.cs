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
    /// Interaction logic for loginpass.xaml
    /// </summary>
    public partial class loginpass : Window
    {
        static public string user = "";
        static public string pass = "";

        public loginpass()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user = userbar.Text;

            string path = Environment.CurrentDirectory;
            path += @"\user\";
            path += user;
            path += ".txt";
            //MessageBox.Show(pathtemp);

            /*string path= @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";
            path += user;
            path += ".txt";*/

            try
            {
                StreamReader reader = new StreamReader(path);
                pass = reader.ReadLine();

                reader.Close();
            }
            catch
            {
                MessageBox.Show("There isn't this username !!!", "Ops !", MessageBoxButton.OK, MessageBoxImage.Warning);

                userbar.Text = "";
                passbar.Password = "";

                goto end;
            }

            if (passbar.Password == pass)
            {

                MainWindow main = new MainWindow();
                this.Close();
                main.ShowDialog();

            }
            else
            {
                MessageBoxResult r = MessageBox.Show("Wrong Password", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                passbar.Password = "";
                if (r == MessageBoxResult.Cancel)
                {
                    this.Close();
                }
            }

        end:
            ;
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (r == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Minimize_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


    }
}
