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

namespace NameListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbl1.Content = "Names";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lblWarning.Content = "";
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (!lstNames.Items.Contains(txtName.Text))
                {
                    lstNames.Items.Add(txtName.Text);
                    txtName.Clear();
                }
                else
                {
                    lblWarning.Content = "Name exists!";
                }
            }
            else
            {
                lblWarning.Content = "Please enter a valid name!";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
        }
    }
}
