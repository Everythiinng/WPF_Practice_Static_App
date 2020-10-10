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

namespace Practice_Static_App
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hi {this.DescriptionTextBox.Text}");
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text += (string)((CheckBox)sender).Content;
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            //this.LengthTextBox.Text += (string)((CheckBox)sender).Content;
            var temp = (string)((CheckBox)sender).Content;
            var replaced = this.LengthTextBox.Text.Replace(temp,"");
            this.LengthTextBox.Text = replaced;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WealdCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.LaserCheckbox.IsChecked =
                this.PurchaseCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked =
                this.RollCheckbox.IsChecked = this.SawCheckbox.IsChecked = false;
        }

    }
}
