using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Αρχική.xaml
    /// </summary>
    public partial class Αρχική : Window
    {
        public Αρχική()
        {
            InitializeComponent();
            welcome.Content = "Καλώς ορίσατε!" + "\n" + "Για να μάθετε την προπαίδεια συνδεθείτε";

        }
        Boolean logIn = false;
        public static bool admin;
        public static string username;

        public static string Get_Username()
        {

            // MessageBox.Show(logged.ToString());
            return username;
        }
        public void Log_In(object sender, System.EventArgs e)
        {
            username = UsernameBox.Text;
            var newForm = new MainWindow();
           // string connStr = @"server=localhost;userid=root;password=;database=testdb";
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";
            MySqlConnection conn = new MySqlConnection(connStr);
             try
             {
                 Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                 conn.Open();

                 string sql_login = "select username,pass from testdb.users WHERE username=" + '"' + $"{ username }" + '"' + " AND pass=" + '"' + $"{ passwordBox.Password }" + '"';
                 Console.WriteLine(sql_login);
                 MySqlCommand cmd = new MySqlCommand(sql_login, conn);
                 MySqlDataReader rdr = cmd.ExecuteReader();
                 bool res = rdr.Read();
                 logIn = res;
                 Console.WriteLine(logIn); //this is used for debug purposes
                 Console.WriteLine(UsernameBox); //this is used for debug purposes
                 conn.Close();
                 //now get the admin status of the user
                 conn.Open();
                 string sql_admin = "select admin_status from testdb.users WHERE username=" + '"' + $"{ username }" + '"' + " AND pass=" + '"' + $"{ passwordBox.Password }" + '"';
                 MySqlCommand cmd_admin = new MySqlCommand(sql_admin, conn);
                 MySqlDataReader rdr_admin = cmd_admin.ExecuteReader();
                 rdr_admin.Read(); // this is a boolean showing if the query succedded
                                   // admin = rdr_admin.GetFieldValue<Boolean>("admin_status")==1;
                 admin = (bool)rdr_admin["admin_status"]; // this is the actual value in the database
                 Console.WriteLine(sql_admin); //debug
                 Console.WriteLine(admin); //debug if we have the admin value returned from the db
                 if (logIn == true)
                 {
                    MessageBox.Show("Σύνδεση επιτυχής");
                    newForm.admin = admin;
                    this.Close();
                     if (admin.Equals(true))
                     {
                        MessageBox.Show("Καλώς ήρθες καθηγητή!");
                        newForm.show_statues.Content = "Εμφάνιση μαθητών";
                        newForm.admin = true;
                        newForm.Show();
                     }
                     else if (admin.Equals(false))
                     {
                        MessageBox.Show("Καλώς ήρθες μαθητή!");
                        newForm.show_statues.Content= "Τα στοιχεία μου";
                        newForm.username = username;
                        newForm.admin = false;
                        newForm.Show();
                     }
                     conn.Close();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Σύνδεση ανεπιτυχής");
                this.Close();
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
                
             }
             conn.Close();
             Console.WriteLine("Done."); //this is used for debug purposes
         
            
         
        }
        private void Sign_Up(object sender, RoutedEventArgs e)
        {
            string usernameR = UsernameBoxR.Text;
            string passwordR = passwordBoxR.Password;
            string fullnameR = fullname.Text;
            string emailR = emailR.Text;
            bool admin_status = false;

            if (teacher.IsChecked == true && student.IsChecked == false)
            {
                admin_status = true;
            }
            else if (student.IsChecked == true && teacher.IsChecked == false)
            {
                admin_status = false;
            }
            else
            {
                MessageBox.Show("Πρέπει να επιλέξετε ανάμεσα σε μαθητής ή καθηγητής");
            }

           // string connStr = @"server=localhost;userid=root;password=;database=testdb";
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                
              Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();

                string sql_signup = "insert into testdb.users(username, pass, fullname,email, admin_status) values  (" + '"' + $"{ usernameR }" + '"' + "," + '"' + $"{ passwordR }" + '"' + "," + '"' + $"{ fullnameR }" + '"' + "," + '"' + $"{ emailR }" + '"' + "," + $"{ admin_status } )";
                Console.WriteLine(sql_signup);
                MySqlCommand cmd = new MySqlCommand(sql_signup, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                // also add in the stats table if student
                if (student.IsChecked == true && teacher.IsChecked == false)
                {
                    Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                    conn.Open(); 
                    string sql_stats = ("insert into testdb.stats(username,prop1,prop2,prop3,prop4,prop5,prop6,prop7,prop8,prop9,prop10) values(" + '"' + $"{ usernameR }" + '"' + ",0,0,0,0,0,0,0,0,0,0)");
                    Console.WriteLine(sql_stats);
                    MySqlCommand cmd_stats = new MySqlCommand(sql_stats, conn);
                    MySqlDataReader rdr_stats = cmd_stats.ExecuteReader();
                    MessageBox.Show("Εγγραφή επιτυχής");
                    conn.Close();
                }
                //and revision stats as well
                if (student.IsChecked == true && teacher.IsChecked == false)
                {
                    Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                    conn.Open();
                    string sql_rstats = ("insert into testdb.revision_stats(username,prop1,prop2,prop3,prop4,prop5,prop6,prop7,prop8,prop9,prop10) values(" + '"' + $"{ usernameR }" + '"' + ",0,0,0,0,0,0,0,0,0,0)");
                    Console.WriteLine(sql_rstats);
                    MySqlCommand cmd_rstats = new MySqlCommand(sql_rstats, conn);
                    MySqlDataReader rdr_rstats = cmd_rstats.ExecuteReader();
                    MessageBox.Show("Εγγραφή επιτυχής");
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Εγγραφή ανεπιτυχής");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
                this.Close();
            }
            //conn.Close();
            Console.WriteLine("signup done."); //this is used for debug purposes
        }
    }
}
