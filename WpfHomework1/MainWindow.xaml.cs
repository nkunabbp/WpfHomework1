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

namespace WpfHomework1
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
        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The blue color on the Flag of the Azerbaijan Republic shows the Turkic origin of the Azerbaijani people");
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The red color on the Flag of the Azerbaijan Republic shows desire to build a modern society and develop democracy ");
        }


        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The green color on the Flag of the Azerbaijan Republic shows belonging to the Islamic religion.");
        }
    }
}