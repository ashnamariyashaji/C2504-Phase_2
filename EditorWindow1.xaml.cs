using System;
using System.Collections.Generic;
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


namespace Example14Project
{
    /// <summary>
    /// Interaction logic for EditorWindow1.xaml
    /// </summary>
    public partial class EditorWindow1 : Window
    {
        public EditorWindow1()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.OpenFileDialog dlgOpen = new System.Windows.Forms.OpenFileDialog();
        private System.Windows.Forms.SaveFileDialog dlgSave = new System.Windows.Forms.SaveFileDialog();
        private System.Windows.Forms.FontDialog dlgFont = new System.Windows.Forms.FontDialog();
        private System.Windows.Forms.ColorDialog dlgColor = new System.Windows.Forms.ColorDialog();

        internal Forms.OpenFileDialog DlgOpen { get => dlgOpen; set => dlgOpen = value; }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var result = DlgOpen.ShowDialog();
            using (FileStream fs = new FileStream(DlgOpen.FileName, FileMode.Open))
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void mnuRed_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.PaleGoldenrod;
        }

        private void mnuBlue_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Background = Brushes.Cyan;
        }

        //private void mnuMoreBackColor_Click(object sender, RoutedEventArgs e)
        //{
        //    var result = dlgColor.ShowDialog();
        //    System.Drawing.Color color = dlgColor.Color;
        //    txtEditor.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
        // }

        private void mnuFont_Click(object sender, RoutedEventArgs e)
        {
            var result = dlgFont.ShowDialog();
            System.Drawing.Font font =  dlgFont.Font;
            txtEditor.FontFamily = new FontFamily(font.Name);
            txtEditor.FontSize = font.Size;
            txtEditor.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
            txtEditor.FontStyle = font.Italic ? FontStyles.Italic : FontStyles.Normal;

        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment = HorizontalAlignment.Left;
            txtStatus.Text = "Left Aligned";
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment = HorizontalAlignment.Center;
            txtStatus.Text = "Center Aligned";

        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.HorizontalContentAlignment = HorizontalAlignment.Right;
            txtStatus.Text = "Right Aligned";

        }
    }
}
