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

namespace Lecture_4_Lab_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double degreesC;
            double degreesF;
            double degreesG;
            degreesC = double.Parse(one.Text);
            degreesF = double.Parse(two.Text);
            degreesG = degreesF + 10;
            if (degreesC >= degreesF)
            {
                Canvas.Background = Brushes.Green;
                MessageBox.Show("You are driving the legal speed.");
            }
            else if (degreesF > degreesC && degreesF < degreesG)
            {
                Canvas.Background = Brushes.Yellow;
                MessageBox.Show("You are driving over the legal speed but there's no penalty.");

            }
            else if (degreesF > degreesG)
            {
                Canvas.Background = Brushes.Red;
                MessageBox.Show("You are driving over the legal speed and there will be a penalty.");

            }
            else
            {
                Canvas.Background = Brushes.Blue;
            }
        }
    }
}