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
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
      
        public Account()
        {
            InitializeComponent();
            usernameS.IsReadOnly = true;
            passwordS.IsReadOnly = true;
            emailS.IsReadOnly = true;
            fullnameS.IsReadOnly = true;
            if (Αρχική.admin == true)
            {
                search_box.Visibility = Visibility.Visible;
                search.Visibility = Visibility.Visible;
            };
            Populate_from_db();
            if (Αρχική.admin == false) {
              Populate_List(username);
            }
        }

        string username = Αρχική.Get_Username();
        bool hasBeenClicked = false;

        private void TextBox_Focus(object sender, RoutedEventArgs e)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }


        private void Populate_from_db()
        {
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();

                string sql_signup = "select * from testdb.users where username=" + '"' + $"{ username }" + '"';
                Console.WriteLine(sql_signup);
                MySqlCommand cmd = new MySqlCommand(sql_signup, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    usernameS.Text = (rdr["username"].ToString());
                    passwordS.Text = (rdr["pass"].ToString());
                    emailS.Text = (rdr["email"].ToString());
                    fullnameS.Text = (rdr["fullname"].ToString());
                }
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Υπήρξε πρόβλημα σύνδεσης");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
               
            }
            //conn.Close();
            Console.WriteLine("signup done."); //this is used for debug purposes
        }

        private void change_status(object sender, RoutedEventArgs e)
        {
            usernameS.IsReadOnly = true;
            passwordS.IsReadOnly = false;
            fullnameS.IsReadOnly = false;
            emailS.IsReadOnly = false;
        }

        private void Change_in_DB(object sender, RoutedEventArgs e)//ενημέρωση βάσης
        {
            MessageBox.Show("accepted");
            usernameS.IsReadOnly = true;
            passwordS.IsReadOnly = true;
            emailS.IsReadOnly = true;
            fullnameS.IsReadOnly = true;
            //now show the new values from the database

            // string connStr = @"server=localhost;userid=root;password=;database=testdb";
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();

                // Den mporei o xrhsths na allaksei to username, giati den mporei na allaxthei sth vash
                // opws kai se kathe site pou yparxei dld. giati einai single source of truth (foreign key)
                string sql_signup = "update testdb.users set pass=" + '"' + $"{ passwordS.Text }" + '"' + ",fullname=" + '"' + $"{ fullnameS.Text }" + '"' + ",email=" + '"' + $"{ emailS.Text }" + '"' + " where username=" + '"' + $"{ username }" + '"';
                Console.WriteLine(sql_signup);
                MySqlCommand cmd = new MySqlCommand(sql_signup, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();

                // also add in the stats table if student
                /*
                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();
                string sql_stats = ("update testdb.stats set username=" + '"' + $"{ username }" + '"' + ")");
                Console.WriteLine(sql_stats);
                MySqlCommand cmd_stats = new MySqlCommand(sql_stats, conn);
                MySqlDataReader rdr_stats = cmd_stats.ExecuteReader();
                conn.Close();


                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();
                string sql_rstats = ("update testdb.revision_stats set username=" + '"' + $"{ username }" + '"' + ")");
                Console.WriteLine(sql_rstats);
                MySqlCommand cmd_rstats = new MySqlCommand(sql_rstats, conn);
                MySqlDataReader rdr_rstats = cmd_rstats.ExecuteReader();
                conn.Close();
                */
                MessageBox.Show("Ανανέωση επιτυχής");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ανανέωση ανεπιτυχής, δοκιμάστε ξανά");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
                passwordS.IsReadOnly = false;
                fullnameS.IsReadOnly = false;
                emailS.IsReadOnly = false;
                this.Close();
            }
            //conn.Close();
            Console.WriteLine("populating user info done."); //this is used for debug purposes
        }
    
    
        private void Populate_List(string search_name)
        {
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();

                string sql_signup = "select * from testdb.stats where username=" + '"' + $"{ search_name }" + '"';
                Console.WriteLine(sql_signup);
                MySqlCommand cmd = new MySqlCommand(sql_signup, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    prop1.Content = "propaideia tou 1=" + (rdr["prop1"].ToString());
                    prop2.Content = "propaideia tou 2=" + (rdr["prop2"].ToString());
                    prop3.Content = "propaideia tou 3=" + (rdr["prop3"].ToString());
                    prop4.Content = "propaideia tou 4=" + (rdr["prop4"].ToString());
                    prop5.Content = "propaideia tou 5=" + (rdr["prop5"].ToString());
                    prop6.Content = "propaideia tou 6=" + (rdr["prop6"].ToString());
                    prop7.Content = "propaideia tou 7=" + (rdr["prop7"].ToString());
                    prop8.Content = "propaideia tou 8=" + (rdr["prop8"].ToString());
                    prop9.Content = "propaideia tou 9=" + (rdr["prop9"].ToString());
                    prop10.Content = "propaideia tou 10=" + (rdr["prop10"].ToString());
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Υπήρξε πρόβλημα σύνδεσης");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes

            }
            //conn.Close();
            Console.WriteLine("populating done."); //this is used for debug purposes
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

        private void Search(object sender, RoutedEventArgs e)
        {
            string name = search_box.Text;
            MessageBox.Show(name);
            Populate_List(name);
        }

       
        private void Go_back(object sender, MouseButtonEventArgs e)
        {
            var newform = new MainWindow();
            newform.username = username;
            if(change.IsVisible)
            {
                newform.show_statues.Content = "Τα στοιχεία μου";
            }
            else
            {
                newform.show_statues.Content = "Εμφάνιση μαθητών";
            }
            this.Close();
            newform.Show();
        }

    }   

}