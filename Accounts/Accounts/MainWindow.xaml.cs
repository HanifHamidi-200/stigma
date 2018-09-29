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

namespace Accounts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int mnStart = 5000;
        private List<int> _withdraw = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<String> _reason = new List<String> { null,null,null,null,null, null, null, null, null, null };
        private int mnTotal = 0;
        private int mnItem;

        private void fUpdateDisplay()
        {
            if (_withdraw[0] == 0)
            {
                lbl1.Content = "[1]";
            }
            else
            {
                lbl1.Content = "[1] WITHDRAW("+Convert.ToString(_withdraw[0])+") = "+_reason[0];
            }
            if (_withdraw[1] == 0)
            {
                lbl2.Content = "[2]";
            }
            else
            {
                lbl2.Content = "[2] WITHDRAW(" + Convert.ToString(_withdraw[1]) + ") = " + _reason[1];
            }
            if (_withdraw[2] == 0)
            {
                lbl3.Content = "[3]";
            }
            else
            {
                lbl3.Content = "[3] WITHDRAW(" + Convert.ToString(_withdraw[2]) + ") = " + _reason[2];
            }
            if (_withdraw[3] == 0)
            {
                lbl4.Content = "[4]";
            }
            else
            {
                lbl4.Content = "[4] WITHDRAW(" + Convert.ToString(_withdraw[3]) + ") = " + _reason[3];
            }
            if (_withdraw[4] == 0)
            {
                lbl5.Content = "[5]";
            }
            else
            {
                lbl5.Content = "[5] WITHDRAW(" + Convert.ToString(_withdraw[4]) + ") = " + _reason[4];
            }
            if (_withdraw[5] == 0)
            {
                lbl6.Content = "[6]";
            }
            else
            {
                lbl6.Content = "[6] WITHDRAW(" + Convert.ToString(_withdraw[5]) + ") = " + _reason[5];
            }
            if (_withdraw[6] == 0)
            {
                lbl7.Content = "[7]";
            }
            else
            {
                lbl7.Content = "[7] WITHDRAW(" + Convert.ToString(_withdraw[6]) + ") = " + _reason[6];
            }
            if (_withdraw[7] == 0)
            {
                lbl8.Content = "[8]";
            }
            else
            {
                lbl8.Content = "[8] WITHDRAW(" + Convert.ToString(_withdraw[7]) + ") = " + _reason[7];
            }
            if (_withdraw[8] == 0)
            {
                lbl9.Content = "[9]";
            }
            else
            { 
                lbl9.Content = "[9] WITHDRAW(" + Convert.ToString(_withdraw[8]) + ") = " + _reason[8];
            }
            if (_withdraw[9] == 0)
            {
                lbla.Content = "[10]";
            }
            else
            {
                lbla.Content = "[10] WITHDRAW(" + Convert.ToString(_withdraw[9]) + ") = " + _reason[9];
            }
            lblTotal.Content = "TOTAL = " + Convert.ToString(mnTotal);
        }

        private void fReset()
        {
            mnItem = 1;

            for (int i = 1; i <= 10; i++)
            {
                _withdraw[i - 1] = 0;
                _reason[i - 1] = null;
            }
            mnTotal = mnStart;

            fUpdateDisplay();
        }

        private void fUpdateTotal()
        {
            mnTotal = mnStart;
            for (int i = 1; i <= 10; i++)
            {
                if (_withdraw[i - 1] != 0)
                {
                    mnTotal -= _withdraw[i - 1];
                }
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            fReset();
            fUpdateDisplay();
        }

        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            if (mnItem == 11)
            {
                MessageBox.Show("Error!");
                return;
            }
            _withdraw[mnItem - 1] = Convert.ToInt32(txtAmount.Text);
            _reason[mnItem - 1] = txtReason.Text;
            fUpdateTotal();
            fUpdateDisplay();
            mnItem += 1;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
