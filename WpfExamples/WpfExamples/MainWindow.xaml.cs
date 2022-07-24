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

namespace WpfExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare variables
        int firstNum = 0;
        int secondNum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, RoutedEventArgs e)
        {
            lblDisplayMessage.Content = "Hello " + txtName.Text + ", go home.";


        } // End btnDisplay

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            lblAnwser.Content = "1 ";
            firstNum = 1;

        } // End btnOne

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            lblAnwser.Content += " + 2";
            secondNum = 2;

        } // End btnTwo

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            int answer = firstNum + secondNum;
            lblAnwser.Content += " = " + answer;
        } // End btnEquals
    } // End class
} // End namespace
