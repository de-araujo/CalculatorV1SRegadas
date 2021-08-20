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
using Dangl.Calculator;

namespace U6_A2_Calculator
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
        private string CalcContent;
        private string Square;
        



        private void Button_Reg(object sender, RoutedEventArgs args)
        {
            if (sender is Button btn)
            {
                CalcContent += btn.Content;
                Calc1.Text = CalcContent;
            }
        }
        
        private void Exponential(object sender, RoutedEventArgs args)
        {
            if (sender is Button btn)
            {
                Square += btn.Content;
                Calc1.Text = CalcContent + "!";
            }
        }

        private void Button_C(object sender, RoutedEventArgs e)
        {
            //clears the desplay
            CalcContent = "";
            //changes what is held int he Calc1.text to th calc
            //so that the user may not hit equals and it desplay an answer
            Calc1.Text = CalcContent;
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            if (CalcContent.Length > 0)
            {
                CalcContent = CalcContent.Remove(CalcContent.Length - 1, 1);
                Calc1.Text = CalcContent;
            }
        }


        private void Calculation(object sender, RoutedEventArgs e)
        {
            
            CalculationResult calculation = Calculator.Calculate(CalcContent);
            if (calculation.IsValid)
            {
                CalcContent = calculation.Result.ToString();
                Calc1.Text = calculation.Result.ToString();
            }
            else
            {
                Calc1.Text = "Not A Number";
            }



        }
    }
}
