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

namespace Prog_122_L8_RTB_Lists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow

        private void btnDisplayText_Click(object sender, RoutedEventArgs e)
        {

            AccidentInfo();

        } // btnDisplayText_Click

        public void AccidentInfo()
        {
            string driver = txtDriverName.Text;
            string address = txtAddress.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;
            string year = txtYear.Text;
            string info = rtbAccidentInfo.Text;

            //string formattedInformation = $"{driver} {address} {make} {model} {year} {info}";

            rtbDisplay.Text = $"Driver Name: {driver}\n";
            rtbDisplay.Text += $"Address : {address}";
            rtbDisplay.Text += $"Make : {make}";
            rtbDisplay.Text += $"Model : {model}";
            rtbDisplay.Text += $"Year : {year}";
            rtbDisplay.Text += $"Info : {info}";




        } // AccidentInfo

    } // class

} // namespace
