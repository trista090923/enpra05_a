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

namespace enpra05_a
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

            Double NUM1 = Convert.ToDouble(NUM_1_TEXTBOX.Text.ToString());
            Double NUM2 = Convert.ToDouble(NUM_2_TEXTBOX.Text.ToString());
            string ch = cal_ComboBox.Text;
            string result = "";
            switch (ch)
            {
                case "+":
                    result = (NUM1 + NUM2).ToString();
                    OUTPUT_TEXTBOX.Text = result;
                    break;
                case "-":
                    result = (NUM1 - NUM2).ToString();
                    OUTPUT_TEXTBOX.Text = result;
                    break;
                case "*":
                    result = (NUM1 * NUM2).ToString();
                    OUTPUT_TEXTBOX.Text = result;
                    break;
                case "/":
                    result = (NUM1 / NUM2).ToString();
                    OUTPUT_TEXTBOX.Text = result;
                    break;
                default:
                    break;
            }
        }
    }
}
