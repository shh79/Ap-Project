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
            if (loginpass.user != "Developer")
            {
                win.Access.IsEnabled = false;
            }
            win.ShowDialog();

            manageusers newform = new manageusers();

            string[] f;

            MainWindow.userlist(out f);

            for (int i = 0; i < f.Length; ++i)
            {
                if (f[i] == "Developer")
                {
                    continue;
                }

                newform.userlist.Items.Add(f[i]);

            }

            newform.ShowDialog();

            this.Close();

            /*string adduser = win.output;

            if (adduser != null)
            {
                Label ll = new Label();
                ll.Content = adduser;
                if (win.Access.IsChecked == true)
                {
                    ll.Foreground = Brushes.Green;
                }
                userlist.Items.Add(ll);
                
            }*/
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Remove_User_Click(object sender, RoutedEventArgs e)
        {
            

            string name = userlist.SelectedItem.ToString();


            if (name != loginpass.user)
            {

                string path = Environment.CurrentDirectory;
                path += @"\user\";

                path += name;
                path += ".txt";

                string check = "";

                StreamReader reader = new StreamReader(path);

                for (int i = 0; i < 3; ++i)
                {
                    check = reader.ReadLine();
                }

                reader.Close();


                if (check == "ACCESS" && loginpass.user != "Developer")
                {
                    MessageBox.Show("Only developer can remove admins .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBoxResult r = MessageBox.Show("Are you sure ??", "Delete this user", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (r == MessageBoxResult.Yes)
                    {
                        File.Delete(path);
                        MessageBox.Show("User deleted", "Succssful", MessageBoxButton.OK, MessageBoxImage.Information);

                        userlist.Items.Remove(name);
                    }
                }
            }
            else
            {
                MessageBox.Show("You can not remove yourself .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
        private void repeatedit(bool flag)
        {
            Edituser win = new Edituser();

            if (loginpass.user != "Developer")
            {
                win.Access.IsEnabled = false;
            }
              
            win.Access.IsChecked = flag;
                

            win.user = userlist.SelectedItem.ToString();

            win.ShowDialog();

            userlist.Items.Remove(userlist.SelectedItem);

            
            userlist.Items.Add(win.user);
            
        }

        private void Edit_User_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            path += @"\user\";

            path += userlist.SelectedItem.ToString();

            path += ".txt";

            string check = "";

            StreamReader reader = new StreamReader(path);

            for(int i = 0; i < 3; ++i)
            {
                check = reader.ReadLine();
            }

            reader.Close();

            if (check == "ACCESS")
            {
                if (loginpass.user == "Developer")
                {
                    repeatedit(true);
                }
                else
                {
                    MessageBox.Show("Only developer can change admins informations .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                repeatedit(false);
            }
        }
    }
}
