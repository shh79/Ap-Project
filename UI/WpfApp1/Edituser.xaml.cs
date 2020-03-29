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
    /// Interaction logic for Edituser.xaml
    /// </summary>
    public partial class Edituser : Window
    {
        public string user = "";

        public Edituser()
        {
            InitializeComponent();
            
        }

        private string file(string path)
        {
            StreamReader reader = new StreamReader(path);

            string pass = reader.ReadLine();

            reader.Close();

            return pass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"E:\IUST\Term2\AP Project\UI\WpfApp1\bin\Debug\user\";

            string path2 = path;
            path2 += user;
            path2 += ".txt";

            string path3 = path;
            path3 += userbar.Text;
            path3 += ".txt";

            string pass = file(path2);
            StreamWriter writer = new StreamWriter(path2);

            if (Access.IsChecked == true)
            {
                writer.WriteLine(pass);
                writer.WriteLine();
                writer.WriteLine("ACCESS");
                MessageBox.Show("This user is Administertor Now .", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                writer.WriteLine(pass);
                MessageBox.Show("This user is not Administertor yet .", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            writer.Close();

            if (userbar.Text.Length != 0)
            {
               
                if (File.Exists(path3))
                {
                    MessageBox.Show("This username is already exist .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    System.IO.File.Move(path2, path3);

                    if (passbar.Password.Length != 0)
                    {
                        StreamWriter write = new StreamWriter(path3);
                        write.WriteLine(passbar.Password);
                        write.Close();

                        MessageBox.Show("This user edited succssfuly", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);

                        user = userbar.Text;

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Username is changed .", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);

                        user = userbar.Text;

                        this.Close();
                    }
                }

            }
            else
            {
                if (passbar.Password.Length != 0)
                {
                    StreamWriter write = new StreamWriter(path2);
                    write.WriteLine(passbar.Password);
                    write.Close();

                    MessageBox.Show("Password of this user changed .", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username and pass of this user not changed .", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    this.Close();
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Access_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
