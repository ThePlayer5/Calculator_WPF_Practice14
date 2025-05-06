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
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;
        private bool _isOperationClicked;

        public void DivideMethod()
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                _firstNumber = double.Parse(Input.Text);
                _operation = "/";
                _isOperationClicked = true;
            }
        }
        public void MultiplyMethod()
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                _firstNumber = double.Parse(Input.Text);
                _operation = "*";
                _isOperationClicked = true;
            }
        }
        public void MinusMethod()
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                _firstNumber = double.Parse(Input.Text);
                _operation = "-";
                _isOperationClicked = true;
            }
        }
        public void PlusMethod()
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                _firstNumber = double.Parse(Input.Text);
                _operation = "+";
                _isOperationClicked = true;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _isOperationClicked = false;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 9;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            DivideMethod();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 6;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            MultiplyMethod();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 3;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            MinusMethod();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (_isOperationClicked)
            {
                Input.Text = "";
                _isOperationClicked = false;
            }
            Input.Text += 0;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (!Input.Text.Contains("."))
            {
                Input.Text += ".";
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text) && !string.IsNullOrEmpty(_operation))
            {
                _secondNumber = double.Parse(Input.Text);
                double result = 0;

                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + _secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - _secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * _secondNumber;
                        break;
                    case "/":
                        if (_secondNumber != 0)
                            result = _firstNumber / _secondNumber;
                        else
                        {
                            MessageBox.Show("Error");
                            return;
                        }
                        break;
                }

                Result.Text = result.ToString();
                _isOperationClicked = true;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            PlusMethod();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Input.Clear();
            Result.Clear();
            _isOperationClicked = false;
        }
    }
}
