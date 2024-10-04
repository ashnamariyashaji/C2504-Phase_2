using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using Microsoft.Win32;

namespace Example14Project
{
    /// <summary>
    /// Interaction logic for EditorWindow.xaml
    /// </summary>
    public partial class EditorWindow : Window
    {
        public EditorWindow()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.OpenFileDialog dlgOpen = new OpenFileDialog();
        private System.Windows.Forms.SaveFileDialog dlgSave = new System.Windows.SaveFileDialog();
        private System.Windows.Forms.FontDialog dlgFont = new FontDialog();
        private System.Windows.Forms.ColorDialog dlgColor = new ColorDialog();

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalAlignment = HorizontalAlignment.Left;
            txtStatus.Text = "Left_Aligned";

        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalAlignment = HorizontalAlignment.Center;
            txtStatus.Text = "Center_Aligned";

        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalAlignment = HorizontalAlignment.Right;
            txtStatus.Text = "Right_Aligned";
        }

        private void mnuRed_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.Red;
        }

        private void mnuBlue_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.Blue;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           var result = dlgOpen.ShowDialog();
            using (FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    txtEditor.Text = sr.ReadToEnd();
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var result = dlgSave.ShowDialog();
            using (FileStream fs = new FileStream(dlgSave.FileName, FileMode.Create))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                   sr.Write(txtEditor.Text);
                }
            }
        }

        private void mnuMoreBackColor_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgColor.ToString();
            System.Drawing.Color color = (System.Drawing.Color)dlgColor.Color();
            txtEditor.Background = new SolidColorBrush(System.Drawing.Color.FromArgb(color.A,
                                                                      color.R,
                                                                      color.G,
                                                                      color.B));


        }

        private void mnuFont_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgFont.ShowDialog();
            System.Drawing.Font font = dlgFont.Font;
            txtEditor.FontFamily = new FontFamily(font.Name);
            txtEditor.FontSize =font.Size;
            txtEditor.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
            txtEditor.FontStyle = font.Italic ? FontStyles.Normal : FontStyles.Italic;


        }

       

    }
}
