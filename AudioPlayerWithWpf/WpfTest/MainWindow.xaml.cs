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
using FileSelector;
namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FileHandler file_handler = new FileHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void  Play_Audio(object sender, RoutedEventArgs e)
        {
            file_handler.SelectFileToPlay();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
