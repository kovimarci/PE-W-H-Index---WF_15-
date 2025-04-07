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
