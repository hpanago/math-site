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
using MySql.Data.MySqlClient;
using System.Data;//math

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

        public static int stats1;
        public static int stats2;
        public static int stats3;
        public static int stats4;
        public static int stats5;
        public static int stats6;
        public static int stats7;
        public static int stats8;
        public static int stats9;
        public static int stats10;
        public static int Rstats1;
        public static int Rstats2;
        public static int Rstats3;
        public static int Rstats4;
        public static int Rstats5;
        public static int Rstats6;
        public static int Rstats7;
        public static int Rstats8;
        public static int Rstats9;
        public static int Rstats10;

        public void Get_Rev(string search_name)
        {
            string connStr1 = @"server=localhost;userid=root;password=root;database=testdb";
            MySqlConnection conn1 = new MySqlConnection(connStr1);
            try
            {
                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                try
                {
                    conn1.Open();
                }
                catch
                {
                    MessageBox.Show("error in opening socket");
                }

                string sql_1 = "select * from testdb.revision_stats where username=" + '"' + $"{ search_name }" + '"';
                Console.WriteLine(sql_1);
                MySqlCommand cmd1 = new MySqlCommand(sql_1, conn1);
                MySqlDataReader rdr1 = cmd1.ExecuteReader();
                while (rdr1.Read())
                {
                    // prop1.Content = "propaideia tou 1=" + (rdr["prop1"].ToString());

                    Rstats1 = Int32.Parse(rdr1["prop1"].ToString());
                    Rstats2 = Int32.Parse(rdr1["prop2"].ToString());
                    Rstats3 = Int32.Parse(rdr1["prop3"].ToString());
                    Rstats4 = Int32.Parse(rdr1["prop4"].ToString());
                    Rstats5 = Int32.Parse(rdr1["prop5"].ToString());
                    Rstats6 = Int32.Parse(rdr1["prop6"].ToString());
                    Rstats7 = Int32.Parse(rdr1["prop7"].ToString());
                    Rstats8 = Int32.Parse(rdr1["prop8"].ToString());
                    Rstats9 = Int32.Parse(rdr1["prop9"].ToString());
                    Rstats10 = Int32.Parse(rdr1["prop10"].ToString());
                    conn1.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Υπήρξε πρόβλημα σύνδεσης1");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
                conn1.Close();
            }
            MessageBox.Show("Υπήρξε πρόβλημα σύνδεσης1");
        }
        public string Compute(int one, int two)
        {
            string value = "Not Found";
            try
            {
                int math = (one + two) / 11;

                value = math.ToString();
            }
            catch
            {
                value = "Not Found";
            }
            return value;
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
                    // prop1.Content = "propaideia tou 1=" + (rdr["prop1"].ToString());

                    stats1 = Int32.Parse(rdr["prop1"].ToString());
                    Console.Write(stats1);
                    stats2 = Int32.Parse(rdr["prop2"].ToString());
                    stats3 = Int32.Parse(rdr["prop3"].ToString());
                    stats4 = Int32.Parse(rdr["prop4"].ToString());
                    stats5 = Int32.Parse(rdr["prop5"].ToString());
                    stats6 = Int32.Parse(rdr["prop6"].ToString());
                    stats7 = Int32.Parse(rdr["prop7"].ToString());
                    stats8 = Int32.Parse(rdr["prop8"].ToString());
                    stats9 = Int32.Parse(rdr["prop9"].ToString());
                    stats10 = Int32.Parse(rdr["prop10"].ToString());
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Υπήρξε πρόβλημα σύνδεσης");
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
                conn.Close();
            }

            Get_Rev(search_name);

            string result1 = Compute(stats1, Rstats1);
            string result2 = Compute(stats2, Rstats2);
            string result3 = Compute(stats3, Rstats3);
            string result4 = Compute(stats4, Rstats4);
            string result5 = Compute(stats5, Rstats5);
            string result6 = Compute(stats6, Rstats6);
            string result7 = Compute(stats7, Rstats7);
            string result8 = Compute(stats8, Rstats8);
            string result9 = Compute(stats9, Rstats9);
            string result10 = Compute(stats10, Rstats10);

            prop1.Content = "Αποτελέσματα στην προπαίδεια του 1: " + result1.ToString();
            prop2.Content = "Αποτελέσματα στην προπαίδεια του 2: " + result2.ToString();
            prop3.Content = "Αποτελέσματα στην προπαίδεια του 3: " + result3.ToString();
            prop4.Content = "Αποτελέσματα στην προπαίδεια του 4: " + result4.ToString();
            prop5.Content = "Αποτελέσματα στην προπαίδεια του 5: " + result5.ToString();
            prop6.Content = "Αποτελέσματα στην προπαίδεια του 6: " + result6.ToString();
            prop7.Content = "Αποτελέσματα στην προπαίδεια του 7: " + result7.ToString();
            prop8.Content = "Αποτελέσματα στην προπαίδεια του 8: " + result8.ToString();
            prop9.Content = "Αποτελέσματα στην προπαίδεια του 9: " + result9.ToString();
            prop10.Content = "Αποτελέσματα στην προπαίδεια του 10: " + result10.ToString();
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