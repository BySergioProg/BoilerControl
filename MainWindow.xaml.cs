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

namespace BoilerControl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Test
    {
         public int TT { get; set; }
    }

    public partial class MainWindow : Window
    {
        Test test = new Test();
        Test test1 = new Test();
        public MainWindow()
        {
            InitializeComponent();
            
            test.TT = 1;
           
            test1.TT = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoilerRoom boilerRoom = new BoilerRoom();
            boilerRoom.Show();
        }


    }
}
