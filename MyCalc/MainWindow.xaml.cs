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

namespace MyCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ServiceReference1.Service1Client Match1;

        public MainWindow()
        {
            InitializeComponent();            
            //Math1 = new ServiceReference1.Service1Client();
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
