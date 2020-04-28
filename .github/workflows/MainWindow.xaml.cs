# This is a basic workflow to help you get started with Actions

name: CI

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        void anathesi(int but_number)
        {
            string propaideia = "";
            var newForm = new προπαίδειες();
            newForm.label.Content = ": του "+ but_number;
            newForm.Title = "Προπαίδεια του " + but_number;
            if(but_number==1)
            {
                newForm.previous.Visibility = Visibility.Hidden;
            }
            else if(but_number==10)
            {
                newForm.next.Visibility = Visibility.Hidden;
            }
            else
            {
                newForm.previous.Visibility = Visibility.Visible;
                newForm.next.Visibility = Visibility.Visible;
            }
            for (int i = 1; i <= 10; i++)
            {
                propaideia += i + " x "+ but_number + " = " + i * but_number + "\n";
            }
            newForm.prop.Text = propaideia;
            newForm.i = but_number;
            newForm.Show();
         }
        public MainWindow()
        {
            InitializeComponent();
           
        }
              
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
           anathesi(1);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            anathesi(2);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            anathesi(3);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            anathesi(4);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            anathesi(5);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            anathesi(6);
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            anathesi(7);
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            anathesi(8);
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            anathesi(9);
        }
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            anathesi(10);
        }
      
    
    }
}
