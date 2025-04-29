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

namespace Calculator_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> numbers = new List<int>();
        public int seven = 7;
        public int eight = 8;
        public int nine = 9;
        public int four = 4;
        public int five = 5;
        public int six = 6;
        public int one = 1;
        public int two = 2;
        public int three = 3;
        public int zero = 0;
        public int result = 0;

        public void DivideMethod()
        {
            foreach (var num in Input.Text)
            {
                if (!(char.IsSymbol(num) || char.IsPunctuation(num)))
                {
                    numbers.Add(Convert.ToInt32(num));
                }
            }
            
        }
        public void MultiplyMethod()
        {

        }
        public void MinusMethod()
        {

        }
        public void PlusMethod()
        {

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += seven;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += eight;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += nine;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += '/';
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += four;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += five;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += six;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += '*';
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += one;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += two;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += three;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += '-';
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += zero;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += '.';
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;
            if (Input.Text.Contains("/"))
            {
                foreach(var i in Input.Text)
                {
                    if (i == one)
                        x = one;
                    if (i == two)
                        x = two;
                    if (i == three)
                        x = three;
                    if (i == four)
                        x = four;
                    if (i == five)
                        x = five;
                    if (i == six)
                        x = six;
                    if (i == seven)
                        x = seven;
                    if (i == eight)
                        x = eight;
                    if (i == nine)
                        x = nine;
                    if (i == zero)
                        x = zero;
                }
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += '+';
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Input.Clear();
        }
    }
}
