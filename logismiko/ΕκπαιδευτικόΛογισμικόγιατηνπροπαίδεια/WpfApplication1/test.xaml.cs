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
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        public test()
        {           
            InitializeComponent();
        }
         public int right_answer1;
         public int right_answer2;
         public int right_answer3;
         public int right_answer4;
         public int right_answer5;
         public int right_answer6;
         public int right_answer7;
         public int right_answer8;
         public int right_answer9;
         public int right_answer10;
         public int i;
         int an,apotelesmata,erwthseis;
        
        private void Answer1(object sender, KeyEventArgs e)
         {
            string answer1 = an1.Text;
            if((e.Key == System.Windows.Input.Key.Enter))
            {
                if (String.IsNullOrEmpty(an1.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if(!int.TryParse(an1.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer1);
                    if (right_answer1 == an)
                    {
                        an1.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q1] += 1;
                       // προπαίδειες.revision_quest[προπαίδειες.q1] += 1;
                    }
                    else
                    {
                        an1.Background = Brushes.Red;
                    }
                    an1.IsEnabled = false;
                }
            }
         }
        private void Answer2(object sender, KeyEventArgs e)
        {
            string answer2 = an2.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an2.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an2.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer2);
                    if (right_answer2 == an)
                    {
                        an2.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q2] += 1;
                       // προπαίδειες.revision_quest[προπαίδειες.q2] += 1;
                    }
                    else
                    {
                        an2.Background = Brushes.Red;
                    }
                    an2.IsEnabled = false;
                }
            }
        }
        private void Answer3(object sender, KeyEventArgs e)
        {
            string answer3 = an3.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an3.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an3.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer3);
                    if (right_answer3 == an)
                    {
                        an3.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q3] += 1;
                        //προπαίδειες.revision_quest[προπαίδειες.q3] += 1;

                    }
                    else
                    {
                        an3.Background = Brushes.Red;
                    }
                    an3.IsEnabled = false;
                }
            }
        }
        private void Answer4(object sender, KeyEventArgs e)
        {
            string answer4 = an4.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an4.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an4.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer4);
                    if (right_answer4 == an)
                    {
                        an4.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q4] += 1;
                       // προπαίδειες.revision_quest[προπαίδειες.q4] += 1;

                    }
                    else
                    {
                        an4.Background = Brushes.Red;
                    }
                    an4.IsEnabled = false;
                }
            }
        }
        private void Answer5(object sender, KeyEventArgs e)
        {
            string answer5 = an5.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an5.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an5.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer5);
                    if (right_answer5 == an)
                    {
                        an5.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q5] += 1;
                      //  προπαίδειες.revision_quest[προπαίδειες.q5] += 1;
                    }
                    else
                    {
                        an5.Background = Brushes.Red;
                    }
                    an5.IsEnabled = false;
                }
            }
        }
        private void Answer6(object sender, KeyEventArgs e)
        {
            string answer6 = an6.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an6.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an6.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer6);
                    if (right_answer6 == an)
                    {
                        an6.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                        //προπαίδειες.revision_stats[προπαίδειες.q6] += 1;
                        //προπαίδειες.revision_quest[προπαίδειες.q6] += 1;
                    }
                    else
                    {
                        an6.Background = Brushes.Red;
                    }
                    an6.IsEnabled = false;
                }
            }
        }
        private void Answer7(object sender, KeyEventArgs e)
        {
            string answer7 = an7.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an7.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an7.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer7);
                    if (right_answer7 == an)
                    {
                        an7.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q7] += 1;
                       // προπαίδειες.revision_quest[προπαίδειες.q7] += 1;
                    }
                    else
                    {
                        an7.Background = Brushes.Red;
                    }
                    an7.IsEnabled = false;
                }
            }
        }
        private void Answer8(object sender, KeyEventArgs e)
        {
            string answer8 = an8.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an8.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an8.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer8);
                    if (right_answer8 == an)
                    {
                        an8.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                      //  προπαίδειες.revision_stats[προπαίδειες.q8] += 1;
                       // προπαίδειες.revision_quest[προπαίδειες.q8] += 1;
                    }
                    else
                    {
                        an8.Background = Brushes.Red;
                    }
                    an8.IsEnabled = false;
                }
            }
        }
        private void Answer9(object sender, KeyEventArgs e)
        {
            string answer9 = an9.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an9.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an9.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer9);
                    if (right_answer9 == an)
                    {
                        an9.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                       // προπαίδειες.revision_stats[προπαίδειες.q9] += 1;
                     //   προπαίδειες.revision_quest[προπαίδειες.q9] += 1;
                    }
                    else
                    {
                        an9.Background = Brushes.Red;
                    }
                    an9.IsEnabled = false;
                }
            }
        }
        private void Answer10(object sender, KeyEventArgs e)
        {
            string answer10 = an10.Text;
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (String.IsNullOrEmpty(an10.Text))
                {
                    MessageBox.Show("Πληκτρολόγησε την απάντηση σου!");
                }
                else if (!int.TryParse(an10.Text, out an))
                {
                    MessageBox.Show("Η απάντηση πρέπει να είναι αριθμός!!");
                }
                else
                {
                    erwthseis += 1;
                    an = int.Parse(answer10);
                    if (right_answer10 == an)
                    {
                        an10.Background = Brushes.Green;
                        progressBar1.Value += 10;
                        apotelesmata += 1;
                        //προπαίδειες.revision_stats[προπαίδειες.q10] += 1;
                        //προπαίδειες.revision_quest[προπαίδειες.q10] += 1;
                    }
                    else
                    {
                        an10.Background = Brushes.Red;
                    }
                    an10.IsEnabled = false;
                }
            }
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

     

        private void Store_Results(object sender, System.EventArgs e)
        {
            if (erwthseis != 10)
            { 
                MessageBox.Show("Δεν έχεις απαντήσει κάποιες ερωτήσεις");

            }
            //we define i in the propaideies class
            //and we need to pass it through to test()
            //so as to save progress data in the database
            //related to the specific number for which 
            //we are doing the test -> Store_InDB(int number)
            int number = MainWindow.prop_number;
           // this is for debugging MessageBox.Show(number.ToString());
          if (προπαίδειες.revision == true)
            {
                //Store_Revision();
                MessageBox.Show("error");
            }
          else
            {
               Store_InDB(number);

            }
          }
        static Random random = new Random();
        int RandomNumber1, RandomNumber2, RandomNumber3, RandomNumber4, RandomNumber5;

        private void Hoverr(object sender, MouseEventArgs e)
        {
            if (erwthseis == 10)
            {
                results.Cursor = Cursors.Hand;
            }
        }

        int RandomNumber6, RandomNumber7, RandomNumber8, RandomNumber9, RandomNumber10;
        int Q1, Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10;
        private void Retake(object sender, RoutedEventArgs e)
        {
            int[] myIntArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myIntArray2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            RandomNumber1 = random.Next(1, 11);
            Q1 = random.Next(1, 11);
            q1.Content = "1) " + RandomNumber1 + " x " + Q1;
            right_answer1 = RandomNumber1 * Q1;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber1)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q1)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber2 = random.Next(1, 11);
            } while (RandomNumber2 == RandomNumber1);
            do
            {
                Q2 = random.Next(1, 11);
            } while (Q2 == Q1);
            q2.Content = "2) " + RandomNumber2 + " x " + Q2;
            right_answer2 = RandomNumber2 * Q2;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber2)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q2)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber3 = random.Next(1, 11);
            } while ((RandomNumber3 == RandomNumber1) || (RandomNumber3 == RandomNumber2));
            do
            {
                Q3 = random.Next(1, 11);
            } while ((Q3 == Q1) || (Q3 == Q2));
            q3.Content = "3) " + RandomNumber3 + " x " + Q3;
            right_answer3 = RandomNumber3 * Q3;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber3)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q3)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber4 = random.Next(1, 11);
            } while ((RandomNumber4 == RandomNumber1) || (RandomNumber4 == RandomNumber2) || (RandomNumber4 == RandomNumber3));
            do
            {
                Q4 = random.Next(1, 11);
            } while ((Q4 == Q1) || (Q4 == Q2) || (Q4 == Q3));
            q4.Content = "4) " + RandomNumber4 + " x " + Q4;
            right_answer4 = RandomNumber4 * Q4;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber4)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q4)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber5 = random.Next(1, 11);
            } while ((RandomNumber5 == RandomNumber1) || (RandomNumber5 == RandomNumber2) || (RandomNumber5 == RandomNumber3) || (RandomNumber5 == RandomNumber4));
            do
            {
                Q5 = random.Next(1, 11);
            } while ((Q5 == Q1) || (Q5 == Q2) || (Q5 ==Q3) || (Q5 == Q4));
            q5.Content = "5) " + RandomNumber5 + " x " + Q5;
            right_answer5 = RandomNumber5 * Q5;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber5)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q5)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber6 = random.Next(1, 11);
            } while ((RandomNumber6 == RandomNumber1) || (RandomNumber6 == RandomNumber2) || (RandomNumber6 == RandomNumber3) || (RandomNumber6 == RandomNumber4) || (RandomNumber6 == RandomNumber5));
            do
            {
                Q6 = random.Next(1, 11);
            } while ((Q6 == Q1) || (Q6 == Q2) || (Q6 == Q3) || (Q6 == Q4) || (Q6 == Q5));
            q6.Content = "6) " + RandomNumber6 + " x " + Q6;
            right_answer6 = RandomNumber6 * Q6;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber6)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q6)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber7 = random.Next(1, 11);
            } while ((RandomNumber7 == RandomNumber1) || (RandomNumber7 == RandomNumber2) || (RandomNumber7 == RandomNumber3) || (RandomNumber7 == RandomNumber4) || (RandomNumber7 == RandomNumber5) || (RandomNumber7 == RandomNumber6));
            do
            {
                Q7 = random.Next(1, 11);
            } while ((Q7 == Q1) || (Q7 == Q2) || (Q7 == Q3) || (Q7 == Q4) || (Q7 == Q5) || (Q7 == Q6));
            q7.Content = "7) " + RandomNumber7 + " x " +Q7;
            right_answer7 = RandomNumber7 * Q7;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber7)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q7)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber8 = random.Next(1, 11);
            } while ((RandomNumber8 == RandomNumber1) || (RandomNumber8 == RandomNumber2) || (RandomNumber8 == RandomNumber3) || (RandomNumber8 == RandomNumber4) || (RandomNumber8 == RandomNumber5) || (RandomNumber8 == RandomNumber6) || (RandomNumber8 == RandomNumber7));
            do
            {
                Q8 = random.Next(1, 11);
            } while ((Q8 == Q1) || (Q8 == Q2) || (Q8 == Q3) || (Q8 == Q4) || (Q8 == Q5) || (Q8 == Q6) || (Q8 == Q7));
            q8.Content = "8) " + RandomNumber8 + " x " + Q8;
            right_answer8 = RandomNumber8 * Q8;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber8)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q8)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            do
            {
                RandomNumber9 = random.Next(1, 11);
            } while ((RandomNumber9 == RandomNumber1) || (RandomNumber9 == RandomNumber2) || (RandomNumber9 == RandomNumber3) || (RandomNumber9 == RandomNumber4) || (RandomNumber9 == RandomNumber5) || (RandomNumber9 == RandomNumber6) || (RandomNumber9 == RandomNumber7) || (RandomNumber9 == RandomNumber8));
            do
            {
                Q9 = random.Next(1, 11);
            } while ((Q9 == Q1) || (Q9 == Q2) || (Q9 == Q3) || (Q9 == Q4) || (Q9 == Q5) || (Q9 == Q6) || (Q9 == Q7) || (Q9 == Q8));
            q9.Content = "9) " + RandomNumber9 + " x " + Q9;
            right_answer9 = RandomNumber9 * Q9;
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] == RandomNumber9)
                {
                    myIntArray[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] == Q9)
                {
                    myIntArray2[y] = 0;
                    continue;
                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray[y] != 0)
                {
                    RandomNumber10 = myIntArray[y];

                }
            }
            for (int y = 0; y < 10; y++)
            {
                if (myIntArray2[y] != 0)
                {
                    Q10 = myIntArray2[y];
                }
            }
           q10.Content = "10) " + RandomNumber10 + " x " + Q10;
           right_answer10 = RandomNumber10 * Q10;
        }
        private void Go_back(object sender, MouseButtonEventArgs e)
        {
            var newForm = new προπαίδειες();
            string propaideia = "";
            newForm.label.Content = "του " + i;
            newForm.Title = "Προπαίδεια του " + i;
            if (i == 1)
            {
                newForm.previous.Visibility = Visibility.Hidden;
            }
            else if (i == 10)
            {
                newForm.next.Visibility = Visibility.Hidden;
                newForm.test_all.Visibility = Visibility.Visible;
            }
            else
            {
                newForm.previous.Visibility = Visibility.Visible;
                newForm.next.Visibility = Visibility.Visible;
            }
            for (int y = 1; y <= 10; y++)
            {
                propaideia += y + " x " + i + " = " + y * i + "\n";
            }
            newForm.prop.Text = propaideia;
            newForm.i = i;
            this.Close();
            newForm.Show();
        }

       /* public void Store_Revision ()
        { 
            //so now revision_stats has eg prop1 as key an correct answers as value
            string logged = Αρχική.Get_Username();
            // this is for debbugging MessageBox.Show(logged.ToString());
           

            string connStr = @"server=localhost;userid=root;password=root;database=testdb";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");//this is used for debug purposes
                conn.Open();
                string sql = "update testdb.revision_stats set prop" + προπαίδειες.revision_stats[προπαίδειες.q1] + "=" + apotelesmata + " WHERE username=" + '"' + $"{ logged }" + '"';
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine(rdr); //this is used for debug purposes
                Console.WriteLine(apotelesmata);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); //this is used for debug purposes
            }
            conn.Close();
            Console.WriteLine("Done."); //this is used for debug purposes
            
            string logged = Αρχική.Get_Username();
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";
            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "update testdb.revision_stats set prop{0}={1} WHERE username="  +"'" + $"{ logged }" +"'";

            foreach (KeyValuePair<int, int> kvp in προπαίδειες.revision_stats)
            {
                string query_1 = "";
                query_1 += string.Format(sql, kvp.Key, kvp.Value);
                Console.WriteLine(query_1);
                try
                {
                    conn.Open();
                    Console.WriteLine(query_1);
                    MySqlCommand cmd = new MySqlCommand(query_1, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString()); //this is used for debug purposes
                    conn.Close();
                }
            }
            foreach (KeyValuePair<int, int> kvp in προπαίδειες.revision_quest)
            {
                // this dictionary has the "how many questions of this type are there?"
                string foo = "";
                foo += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine(foo);
            }

    


        } */

        public void Store_InDB(int number)
        {


           // if (προπαίδειες.revision == true) {
            
            //}
            // need to create an object reference 
            // to get the username
            // so create an instance of Αρχική
            // here in the calling method
            // so as to be able to access the 
            // wanted variable -> username

            //  Αρχική user = new Αρχική();
            // string logged = user.
            // MessageBox.Show(logged.ToString());
            string logged =  Αρχική.Get_Username();
            string connStr = @"server=localhost;userid=root;password=root;database=testdb";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");//this is used for debug if it connected successfully
                conn.Open();
                string sql = "update testdb.stats set prop" + number + "=" + apotelesmata + " WHERE username=" + '"' + $"{ logged }" + '"';
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine(rdr); //this is used for debug the sql query that was passed
                Console.WriteLine(apotelesmata);
                MessageBox.Show("Τα αποτελέσματα αποθηκεύτηκαν επιτυχώς");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); //this is used for debug the exception thrown
            }
            conn.Close();
            Console.WriteLine("Done."); //this shows that storing in Db is now finished
        }
    }
}
