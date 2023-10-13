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

            ArrayDemonstration();

        } // MainWindow

        public void ArrayDemonstration()
        {
            string[] students = new string[4];
            students[0] = "Hafsa";
            students[1] = "Kira";
            students[2] = "Juan";
            students[3] = "Matthew";

            for(
                int i = 0; // Start
                i < students.Length; // End 
                i++) // Change
            {
                rtbDisplay.Text += students[i] + "\n";
            }

            //rtbDisplay.Text = students[0];



        }

        public void TestData()
        {
            txtDriverName.Text = "Will";
            txtAddress.Text = "128379 asdfhl";
            txtMake.Text = "Hyundai";
            txtModel.Text = "Sonata";
            txtYear.Text = "1823";
            rtbAccidentInfo.Text = "asdkjf;ajsfd";
        }

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

            string formattedInformation = $"" +
                $"Driver : {driver}\n " +
                $"Address : {address}\n " +
                $"Make : {make}\n " +
                $"Model : {model}\n " +
                $"Year : {year}\n " +
                $"Info : {info}\n";

            rtbDisplay.Text = formattedInformation;

            //rtbDisplay.Text = $"Driver Name: {driver}";
            //rtbDisplay.Text += "\n";
            //rtbDisplay.Text += $"Address : {address}";
            //rtbDisplay.Text += "\n";
            //rtbDisplay.Text += $"Make : {make}";
            //rtbDisplay.Text += "\n";
            //rtbDisplay.Text += $"Model : {model}";
            //rtbDisplay.Text += "\n";
            //rtbDisplay.Text += $"Year : {year}";
            //rtbDisplay.Text += "\n";
            //rtbDisplay.Text += $"Info : {info}";

        } // AccidentInfo

    } // class

} // namespace
