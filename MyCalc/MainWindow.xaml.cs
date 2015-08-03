using System;
using System.Windows;

namespace MyCalc
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

        public ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = client.AddNumber(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = client.SubNumber(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = client.MultNumber(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = client.DivNumber(Convert.ToDouble(txtNumber1.Text), Convert.ToDouble(txtNumber2.Text));
        }
    }
}
