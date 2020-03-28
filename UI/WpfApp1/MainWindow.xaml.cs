﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (r == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void tabcontrol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nextpg_Click(object sender, RoutedEventArgs e)
        {
            tabcontrol.SelectedItem = tab2;
        }

        private void prepg_Click(object sender, RoutedEventArgs e)
        {
            tabcontrol.SelectedItem = tab1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.txt");
            writer.WriteLine(textbox1.Text);

            writer.Close();
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {

        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";

            cb1.IsChecked = false;
            cb2.IsChecked = false;
            cb3.IsChecked = false;
            cb4.IsChecked = false;
            cb5.IsChecked = false;
            cb6.IsChecked = false;

            doc1.Text = "";

            
        }

        private void Minimize_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Run_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Changepass(object sender, RoutedEventArgs e)
        {
            Changepass win = new Changepass();

            win.ShowDialog();
        }

       

        private void def(object sender, RoutedEventArgs e)
        {
            MainWindow newform = new MainWindow();

            newform.Show();

            this.Close();
        }

        private void changetogray(object sender, RoutedEventArgs e)
        {
            BackGrnd.Background = Brushes.Gray;
            clr2.IsChecked = false;
            clr3.IsChecked = false;
            clr4.IsChecked = false;
            clr5.IsChecked = false;
        }

        private void changetoyellow(object sender, RoutedEventArgs e)
        {
            BackGrnd.Background = Brushes.LightYellow;
            clr1.IsChecked = false;
            clr3.IsChecked = false;
            clr4.IsChecked = false;
            clr5.IsChecked = false;
        }

        private void changetowhite(object sender, RoutedEventArgs e)
        {
            BackGrnd.Background = Brushes.White;
            clr1.IsChecked = false;
            clr2.IsChecked = false;
            clr4.IsChecked = false;
            clr5.IsChecked = false;
        }

        private void changetoBlue(object sender, RoutedEventArgs e)
        {
            BackGrnd.Background = Brushes.LightBlue;
            clr1.IsChecked = false;
            clr2.IsChecked = false;
            clr3.IsChecked = false;
            clr5.IsChecked = false;
        }

        private void changeto(object sender, RoutedEventArgs e)
        {


            BackGrnd.Background = Brushes.LightGreen;
            clr1.IsChecked = false;
            clr2.IsChecked = false;
            clr3.IsChecked = false;
            clr4.IsChecked = false;
        }
    }
}
