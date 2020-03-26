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

        public string pass = "";

        public loginpass()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("pass.txt");

            pass = reader.ReadLine();

            reader.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
