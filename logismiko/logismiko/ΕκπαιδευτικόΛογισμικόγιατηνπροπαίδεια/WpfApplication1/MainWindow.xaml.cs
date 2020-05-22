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
using MySql.Data.MySqlClient;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool admin;
        public static int prop_number;
        public string username;

        OpenFileDialog openFileDialog1 = new OpenFileDialog();

       
    void anathesi(int but_number)
        {
            string propaideia = "";
           
            var newForm = new προπαίδειες();
            if(admin.Equals(1))
            {
                newForm.prop.IsEnabled = true;
                newForm.prop.IsReadOnly = false;
                newForm.prop.Cursor = Cursors.Pen;
                newForm.tips.IsEnabled = true;
                newForm.tips.IsReadOnly = false;
                newForm.tips.Cursor = Cursors.Pen;
            }
            else
            {
                newForm.prop.IsEnabled = false;
                newForm.prop.IsReadOnly = true;
                newForm.prop.Cursor = Cursors.Pen;
                newForm.tips.IsEnabled = true;
                newForm.tips.IsReadOnly = false;
                newForm.tips.Cursor = Cursors.Pen;
            }
            newForm.label.Content = "του "+ but_number;
            newForm.Title = "Προπαίδεια του " + but_number;
            if (but_number==1)
            {
                newForm.previous.Visibility = Visibility.Hidden;
            }
            else if(but_number==10)
            {
                newForm.next.Visibility = Visibility.Hidden;
                newForm.test_all.Visibility = Visibility.Visible;
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
            prop_number = but_number;
            this.Close();
            newForm.Show();
         }
        public MainWindow()
        {
            InitializeComponent();
           
        }
        Boolean logIn = false;     
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
        private void Log_out(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show("Θέλετε να αποσυνδεθείτε", "Αποσύνδεση", MessageBoxButton.YesNo);
            switch (exit)
            {
                case MessageBoxResult.Yes:
                    var arx = new Αρχική();
                    arx.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;

            }
        }

    

        private void Show_Stats(object sender, MouseButtonEventArgs e)
        {
            Account newacc = new Account();
           
            this.Close();
            newacc.Show();
        }
        
       
    }
}
