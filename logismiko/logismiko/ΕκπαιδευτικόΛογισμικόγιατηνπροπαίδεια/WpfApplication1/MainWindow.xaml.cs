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

        
        void anathesi(int but_number,string tips)
        {
            
           
            //files = directory.GetFiles("2.txt");
            string propaideia = "";
            var newForm = new προπαίδειες();
            if (admin.Equals(true))
            {
                newForm.prop.IsEnabled = true;
                newForm.prop.IsReadOnly = false;
                newForm.prop.Cursor = Cursors.Pen;
                newForm.tips.IsEnabled = true;
                newForm.tips.IsReadOnly = false;
                newForm.tips.Cursor = Cursors.Pen;
                newForm.test.Visibility = Visibility.Hidden;
                if(but_number==10)
                {
                    newForm.test_all.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                newForm.prop.IsEnabled = false;
                newForm.prop.IsReadOnly = true;
                newForm.prop.Cursor = Cursors.None;
                newForm.tips.IsEnabled = true;
                newForm.tips.IsReadOnly = true;
                newForm.tips.Cursor = Cursors.Arrow;
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
            newForm.tips.Text = tips;
            this.Close();
            newForm.Show();
         }
        //Boolean ifprop1, ifprop2, ifprop3,ifprop4, ifprop5, ifprop6, ifprop7, ifprop8, ifprop9, ifprop10;
        public MainWindow()
        {
            InitializeComponent();
            tipsarray[0] = "Το αποτέλεσμα είναι ο ίδιος ο αριθμός που πολλαπλασιάζεται με το 1";
            tipsarray[1] = "Πρόσθεσε τον αριθμό με τον εαυτό του,δηλαδή διπλασιασέ τον.Για παράδειγμα 2x9 = 9 + 9 = 18";
            tipsarray[2] = "Πολλαπλασόασε τον αριθμό με το 2 και μετά πρόσθεσε τον αριθμό στο αποτέλεσμα";
            tipsarray[3] = "Διπλασίασε τον αριθμό και ξανά διπλασίασε τον.Για παράδειγμα 4×9:το διπλάσιο του 9 είναι 18, το διπλάσιο του 18 είναι 36";
            tipsarray[4]= "Κόψε το στην μέση και μετά πολλαπλασίασε με το δέκα.Για παράδειγμα  5x6: το μισό του 6 είναι 3,επί 10=30.";
            tipsarray[5]= "Όταν πολλαπλασιάζεις το έξι με ζυγό αριθμό,το αποτέλεσμα τελειώνει στο ίδιο ψηφίο με τον αριθμό.Για παράδειγμα:6×2=12, 6×4=24, 6×6=36";
            tipsarray[6]= "Σκέψου 5,6,7,8.Για παράδειγμα 56=7x8";
            tipsarray[7]= "Διπλασίασε τον αριθμό τρείς φορές.Για παράδειγμα 8×6: το διπλάσιο του 6 είναι 12,το διπλάσιο του 12 είναι 24,το διπλάσιο του 24 είναι 48";
            tipsarray[8]= "Πολλαπλασίασε τον αριθμό με το δέκα και μετά αφαίρεσαι τον αριθμό.Για παράδειγμα 9×6 = 10×6−6 = 60−6 = 54";
            tipsarray[9]="Το αποτέλεσμα είναι ο αριθμός που πολλαπλασιάζεται με ένα μηδενικό δίπλα του";
            /*if (ifprop==true)//2.3 ημιτελειωμενο
             {
              MessageBoxResult retry = MessageBox.Show("Δεν έχεις μάθει καλά την προπαίδεια του 1.Πρέπει να την ξαναδιαβάσεις",  MessageBoxButton.YesNo);
              switch (exit)
               {
                case MessageBoxResult.Yes:
                    var newprop = new προπαιδειες();
                     anathesi(1, tipsarray[0]);
                    newprop.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;

               }
              MessageBox.Show="
             }
             else if()
             {
             
             }*/
        }
        Boolean logIn = false;
        
      static  public string[] tipsarray = new string[10];
       
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
           
           anathesi(1, tipsarray[0]);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
          anathesi(2,tipsarray[1]);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            anathesi(3,tipsarray[2]);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            anathesi(4,tipsarray[3]);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            anathesi(5,tipsarray[4]);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            anathesi(6,tipsarray[5]);
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            anathesi(7,tipsarray[6]);
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            anathesi(8,tipsarray[7]);
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            anathesi(9,tipsarray[8]);
        }
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            anathesi(10,tipsarray[9]);
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
