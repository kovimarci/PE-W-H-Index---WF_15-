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

namespace WF_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main();
        }
        private void Main()
        {
            Height.GotFocus += FocusEvent;
            Weight.GotFocus += FocusEvent;
            Height.LostFocus += LostFocusEvent;
            Weight.LostFocus += LostFocusEvent;
            Height.KeyUp += EnterEvent;
            Weight.KeyUp += EnterEvent;
        }
        private void EnterEvent(object obj, KeyEventArgs arg)
        {
            if (arg.Key == Key.Enter)
            {
                int height = -1;
                int weight = -1;
                int.TryParse(Weight.Text.Trim(' '), out int rw);
                weight = rw;
                int.TryParse(Height.Text.Trim(' '), out int rh);
                height = rh;
                if (height > 0 && weight > 0)
                {
                    MessageBox.Show($"Magasság: {height}, Súly: {weight}");
                    SList.Children.Add(new TextBox
                    {
                        Text = $"BMI: {CalcBMI(height, weight)}, {NameType(CalcBMI(height, weight))}"
                    });
                }
            }
        }
        private double CalcBMI(int height, int weight)
        {
            return weight / Math.Pow((double)height / 100, 2);
        }
        private string NameType(double BMI)
        {
            if (BMI < 18.5)
                return "Sovány";
            if (BMI < 24.9)
                return "Normál";
            if (BMI < 29.9)
                return "Túlsúlyos";
            return "Nagyon túlsúlyos";
        }
        private void FocusEvent(object obj, EventArgs arg)
        {
            TextBox t = obj as TextBox;
            if(t.Text == t.Name.ToString())
                t.Clear();
        }
        private void LostFocusEvent(object obj, EventArgs arg)
        {
            TextBox t = obj as TextBox;
            if (t.Text.Length < 1)
                t.Text = t.Name;
        }
    }
}
