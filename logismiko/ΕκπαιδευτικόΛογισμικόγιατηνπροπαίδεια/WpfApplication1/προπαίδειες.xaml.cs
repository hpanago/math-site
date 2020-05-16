using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Interaction logic for προπαίδειες.xaml
    /// </summary>

    public partial class προπαίδειες : Window
    {

        public προπαίδειες()
        {
            InitializeComponent();
        }
        void prop_at_text(int prop_number)
        {
            string propaideia = "";
            for (int i = 1; i <= 10; i++)
            {
                propaideia += i + " x " + prop_number + " = " + i * prop_number + "\n";
            }
            prop.Text = propaideia;
        }
        public int i;
       public static bool revision; // to xreiazomaste gia na ksexwrisume thn propaideia tou 10 apo thn epanalhpsh
        public static int q1;
        public static int q2;
        public static int q3;
        public static int q4;
        public static int q5;
        public static int q6;
        public static int q7;
        public static int q8;
        public static int q9;
        public static int q10;
       // public static Dictionary<int,int> revision_stats = new Dictionary<int, int>();
       // public static Dictionary<int, int> revision_quest = new Dictionary<int, int>();
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            if (i == 10)
            {
                next.Visibility = Visibility.Hidden;
                test_all.Visibility = Visibility.Visible;
            }
            else
            {
                next.Visibility = Visibility.Visible;
                test_all.Visibility = Visibility.Hidden;
            }
            if (i != 1)
            {
                previous.Visibility = Visibility.Visible;
            }
            label.Content = "του " + i.ToString();
            prop_at_text(i);
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            i = i - 1;
            if (i != 10)
            {
                next.Visibility = Visibility.Visible;
            }
            test_all.Visibility = Visibility.Hidden;
            if (i != 1)
            {
                previous.Visibility = Visibility.Visible;
            }
            else
            {
                previous.Visibility = Visibility.Hidden;
            }

            label.Content = "του " + i.ToString();
            prop_at_text(i);
        }
        static Random random = new Random();
        int RandomNumber1, RandomNumber2, RandomNumber3, RandomNumber4, RandomNumber5;
        int RandomNumber6, RandomNumber7, RandomNumber8, RandomNumber9, RandomNumber10;

        private void Go_back(object sender, MouseButtonEventArgs e)
        {
            var newform = new MainWindow();
            this.Close();
            newform.Show();
        }

        // Generate and display 5 random integers between 0 and 100.
        /*public int Create_Numbers()
        {
            // List<int> integers = new List<int>();
            int[] integers = new int[11];
            Console.WriteLine("Ten random integers between 1 and 10:");
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                // Console.Write("{0,8:N0}", random.Next(11));
                //integers.Add(random.Next(11));
                integers[ctr] = random.Next(1, 11);

            }
            //Console.WriteLine(integers);
            //Console.WriteLine(integers[1]);
            try
            {
                revision_stats.Add(integers[2], 0);
                revision_quest.Add(integers[2], 0);
            }
            catch
            {
                revision_quest[integers[2]] = 0;
            }
            return integers[2];

        }*/
        
        private void Do_test(object sender, RoutedEventArgs e)
        {
            var newtest = new test();
            int[] myIntArray = new int[10] { 1, 2, 3, 4, 5,6,7,8,9,10 };
            newtest.number.Content = "στην προπαίδεια του " + i;
            RandomNumber1 = random.Next(1, 11);
            newtest.q1.Content = "1) " + RandomNumber1 + " x " + i;
            newtest.right_answer1 = RandomNumber1 * i;
            for(int y=0; y<10; y++)
            {
                 if(myIntArray[y]==RandomNumber1)
                 {
                     myIntArray[y]=0;
                     continue;
                 }
            }
            do
            { 
                  RandomNumber2 = random.Next(1, 11 );
            } while(RandomNumber2==RandomNumber1);
            newtest.q2.Content = "2) " + RandomNumber2 + " x " + i;
            newtest.right_answer2 = RandomNumber2 * i;
            for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber2)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
             {
                  RandomNumber3 = random.Next(1, 11);
             }while((RandomNumber3 == RandomNumber1)||(RandomNumber3==RandomNumber2));
               newtest.q3.Content = "3) " + RandomNumber3 + " x " + i;
               newtest.right_answer3 = RandomNumber3 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber3)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
             {
               RandomNumber4 = random.Next(1, 11);
             }while((RandomNumber4==RandomNumber1)||(RandomNumber4==RandomNumber2)||(RandomNumber4==RandomNumber3));
             newtest.q4.Content = "4) " + RandomNumber4 + " x " + i;
             newtest.right_answer4 = RandomNumber4 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber4)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
             {
                 RandomNumber5 = random.Next(1, 11);
             } while((RandomNumber5==RandomNumber1)||(RandomNumber5==RandomNumber2)||(RandomNumber5==RandomNumber3)||(RandomNumber5==RandomNumber4));
             newtest.q5.Content = "5) " + RandomNumber5 + " x " + i;
             newtest.right_answer5 = RandomNumber5 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber5)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
              {
                 RandomNumber6 = random.Next(1, 11);
              }while((RandomNumber6==RandomNumber1)||(RandomNumber6==RandomNumber2)||(RandomNumber6==RandomNumber3)||(RandomNumber6==RandomNumber4)||(RandomNumber6==RandomNumber5));
               newtest.q6.Content = "6) " + RandomNumber6 + " x " + i;
               newtest.right_answer6 = RandomNumber6 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber6)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
               {
                 RandomNumber7 = random.Next(1, 11);
               }while((RandomNumber7==RandomNumber1)||(RandomNumber7==RandomNumber2)||(RandomNumber7==RandomNumber3)||(RandomNumber7==RandomNumber4)||(RandomNumber7==RandomNumber5)||(RandomNumber7==RandomNumber6));
               newtest.q7.Content = "7) " + RandomNumber7 + " x " + i;
               newtest.right_answer7 = RandomNumber7 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber7)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
               {
                 RandomNumber8 = random.Next(1, 11);
               } while((RandomNumber8==RandomNumber1)||(RandomNumber8==RandomNumber2)||(RandomNumber8==RandomNumber3)||(RandomNumber8==RandomNumber4)||(RandomNumber8==RandomNumber5)||(RandomNumber8==RandomNumber6)||(RandomNumber8==RandomNumber7));
               newtest.q8.Content = "8) " + RandomNumber8 + " x " + i;
               newtest.right_answer8 = RandomNumber8 * i;
             for (int y = 0; y < 10; y++)
             {
                 if (myIntArray[y] == RandomNumber8)
                 {
                     myIntArray[y] = 0;
                     continue;
                 }
             }
             do
               {
                 RandomNumber9 = random.Next(1, 11);
               } while((RandomNumber9==RandomNumber1)||(RandomNumber9==RandomNumber2)||(RandomNumber9==RandomNumber3)||(RandomNumber9==RandomNumber4)||(RandomNumber9==RandomNumber5)||(RandomNumber9==RandomNumber6)||(RandomNumber9==RandomNumber7)||(RandomNumber9==RandomNumber8));
               newtest.q9.Content = "9) " + RandomNumber9 + " x " + i;
               newtest.right_answer9 = RandomNumber9 * i;
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
                
                if (myIntArray[y] != 0)
                 {
                     RandomNumber10 = myIntArray[y];
             
                 }
             }
             newtest.q10.Content = "10) " + RandomNumber10 + " x " + i;
             newtest.right_answer10 = RandomNumber10 * i;
             newtest.i = i;
             this.Close();
             newtest.Show();
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
    
        private void Do_test_all(object sender, RoutedEventArgs e)
        {
            var newtest = new test();
            int[] myIntArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myIntArray2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            newtest.retake.Visibility = Visibility.Visible;
            newtest.number.Content = "Σε όλη την προπαίδεια";
            RandomNumber1 = random.Next(1, 11);
            q1 = random.Next(1, 11);
            newtest.q1.Content = "1) " + RandomNumber1 + " x " + q1;
            newtest.right_answer1 = RandomNumber1 * q1;
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
                if (myIntArray2[y] == q1)
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
                q2 = random.Next(1, 11);
            } while (q2 == q1);
            newtest.q2.Content = "2) " + RandomNumber2 + " x " + q2;
            newtest.right_answer2 = RandomNumber2 * q2;
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
                if (myIntArray2[y] == q2)
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
                q3 = random.Next(1, 11);
            } while ((q3 == q1) || (q3 == q2));
            newtest.q3.Content = "3) " + RandomNumber3 + " x " + q3;
            newtest.right_answer3 = RandomNumber3 * q3;
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
                if (myIntArray2[y] == q3)
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
                q4 = random.Next(1, 11);
            } while ((q4 == q1) || (q4 == q2) || (q4 == q3));
            newtest.q4.Content = "4) " + RandomNumber4 + " x " + q4;
            newtest.right_answer4 = RandomNumber4 * q4;
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
                if (myIntArray2[y] == q4)
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
                q5 = random.Next(1, 11);
            } while ((q5 == q1) || (q5 == q2) || (q5 == q3) || (q5 == q4));
            newtest.q5.Content = "5) " + RandomNumber5 + " x " + q5;
            newtest.right_answer5 = RandomNumber5 * q5;
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
                if (myIntArray2[y] == q5)
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
                q6 = random.Next(1, 11);
            } while ((q6 == q1) || (q6 == q2) || (q6 == q3) || (q6 == q4)||(q6==q5));
            newtest.q6.Content = "6) " + RandomNumber6 + " x " + q6;
            newtest.right_answer6 = RandomNumber6 * q6;
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
                if (myIntArray2[y] == q6)
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
                q7 = random.Next(1, 11);
            } while ((q7 == q1) || (q7 == q2) || (q7 == q3) || (q7 == q4) || (q7 == q5) || (q7 == q6));
            newtest.q7.Content = "7) " + RandomNumber7 + " x " + q7;
            newtest.right_answer7 = RandomNumber7 * q7;
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
                if (myIntArray2[y] == q7)
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
                q8 = random.Next(1, 11);
            } while ((q8 == q1) || (q8 == q2) || (q8 == q3) || (q8 == q4) || (q8 == q5) || (q8 == q6) || (q8 == q7));
            newtest.q8.Content = "8) " + RandomNumber8 + " x " + q8;
            newtest.right_answer8 = RandomNumber8 * q8; 
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
                if (myIntArray2[y] == q8)
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
                q9 = random.Next(1, 11);
            } while ((q9 == q1) || (q9 == q2) || (q9 == q3) || (q9 == q4) || (q9 == q5) || (q9 == q6) || (q9 == q7) || (q9 == q8));
            newtest.q9.Content = "9) " + RandomNumber9 + " x " + q9;
            newtest.right_answer9 = RandomNumber9 * q9;
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
                if (myIntArray2[y] == q9)
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
                    q10 = myIntArray2[y];
                }
            }
            newtest.q10.Content = "10) " + RandomNumber10 + " x " + q10;
            newtest.right_answer10 = RandomNumber10 * q10;
            revision = true;
            newtest.i = i;
            this.Close();
            newtest.Show();
        
        }
      public static bool Get_Revision()
       {
          return revision;
       }

    }
}
