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
using System.Windows.Shapes;
using GettingReal;

namespace DCM
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Controller c = new Controller();
            c.Søg(SearchBox.Text, int.Parse(SearchBox.Text));
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Opret o = new Opret();
            o.Show();
        }
    }
}
