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

namespace WpfApp1
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
        public void beraberlesdirm()
        {
            
        }



        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt2.Text = txt1.Text;
        }

        private void txt3_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt4.Text = txt3.Text;
        }

        private void txt5_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt6.Text = txt5.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text=" ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";
            txt5.Text = " ";
            txt6.Text = " ";
        }
    }
}
