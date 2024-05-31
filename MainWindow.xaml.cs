using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calproj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string oper = "";
        string firstNumberstr = "";
        string secondNumberstr = "";
        int result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberClick(object sender, RoutedEventArgs e)
        {


            Button btnnumber = (Button)sender;

            if (oper == "")
            {
                firstNumberstr = firstNumberstr + btnnumber.Content.ToString();
                textresult.Text = firstNumberstr;
            }
            else
            {
                secondNumberstr = secondNumberstr + btnnumber.Content.ToString();
                textresult.Text = secondNumberstr;
            }
        }
        private void OperatorClick(object sender, RoutedEventArgs e)
        {
            Button btnoperator = (Button)sender;
            oper = btnoperator.Content.ToString();
        }
        private void btnoper_Click(object sender, RoutedEventArgs e)
        {



            //  if (firstNumberstr != "" && secondNumberstr != "" && oper != "")
            {

                int firstNumber = Convert.ToInt16(firstNumberstr);
                int secondNumber = Convert.ToInt16(secondNumberstr);
                int result = 0;
                CalClass classnum = new CalClass();
                if (oper == "+")
                {
                    result = classnum.Addnumber(firstNumber, secondNumber);
                }
                else if (oper == "-")
                {
                    result = classnum.Subnumber(firstNumber, secondNumber);
                }
                else if (oper == "*")
                {
                    result = classnum.Mulnumber(firstNumber, secondNumber);
                }
                else if (oper == "/")
                {
                    result = classnum.Divnumber(firstNumber, secondNumber);
                }
                else if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
                {
                    Button btnnumber = (Button)sender;
                    int btncontent = Convert.ToInt32(btnnumber.Content);
                    int values = btncontent;
                    classnum.Test(values, values);
                }
                
                textresult.Text = result.ToString();
            }


        }


        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            textresult.Clear();
            firstNumberstr = "";
            secondNumberstr = "";
            oper = "";
        }
    }
}