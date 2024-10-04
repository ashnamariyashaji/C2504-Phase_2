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

namespace Example13a
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        private MainWindow frmmainwindow =new MainWindow();
        private SumCalcWindow frmcalcWindow =new SumCalcWindow();
        private SquareCalcWindow1 frmsquarecalcWindow1 =new SquareCalcWindow1();
        private void btnCounter_Click(object sender, RoutedEventArgs e)
        {
            frmmainwindow.Show();
            frmmainwindow.Activate();
        }

        private void btnSumCalc_Click(object sender, RoutedEventArgs e)
        {
           frmcalcWindow.Show();
            frmcalcWindow.Activate();
        }

        private void btnSquareCubeCalc_Click(object sender, RoutedEventArgs e)
        {
            frmsquarecalcWindow1.Show();
            frmsquarecalcWindow1.Activate();
        }
    }
}
