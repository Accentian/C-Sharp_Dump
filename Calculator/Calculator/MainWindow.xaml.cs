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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare variables
        int answer = 0;
        string num = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "1";
                num += "1";
            }
            else
            {
                txtResults.Text += "1";
                num += "1";
            }
        } // End btn1

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "2";
                num += "2";
            }
            else
            {
                txtResults.Text += "2";
                num += "2";
            }
        } // End btn2

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "3";
                num += "3";
            }
            else
            {
                txtResults.Text += "3";
                num += "3";
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "4";
                num += "4";
            }
            else
            {
                txtResults.Text += "4";
                num += "4";
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "5";
                num += "5";
            }
            else
            {
                txtResults.Text += "5";
                num += "5";
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "6";
                num += "6";
            }
            else
            {
                txtResults.Text += "6";
                num += "6";
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "7";
                num += "7";
            }
            else
            {
                txtResults.Text += "7";
                num += "7";
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "8";
                num += "8";
            }
            else
            {
                txtResults.Text += "8";
                num += "8";
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "9";
                num += "9";
            }
            else
            {
                txtResults.Text += "9";
                num += "9";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text == "0")
            {
                txtResults.Clear();
                txtResults.Text += "0";
                num += "0";
            }
            else
            {
                txtResults.Text += "0";
                num += "0";
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
                txtResults.Text = "";
                answer = 0;
                num = "";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtResults.Text += " + ";
            answer = Convert.ToInt32(num) + answer;
            num = "";

        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResults.Text += " - ";
            answer = Convert.ToInt32(num) - answer;

            if (answer < 0)
            {
                answer = answer * -1;
            }
            
            num = "";
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (txtResults.Text.Contains(" - "))
            {
                answer -= Convert.ToInt32(num);
                txtResults.Text += " = " + (answer);
            }
            else
            {
                answer += Convert.ToInt32(num);
                txtResults.Text += " = " + (answer);
            }
        }
    } // End class
} // End namespace
