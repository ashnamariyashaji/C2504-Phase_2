﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2Project
{
    public partial class EditorApp : Form
    {
        public EditorApp()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.IndianRed;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleTurquoise;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleGreen;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = dlgColor.Color;
                staColor.Text = txtEditor.BackColor.ToString();
            }
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = dlgColor.Color;
               staForeColor.Text = txtEditor.BackColor.ToString();
            }
        }

        private void mnuRedBg_Click(object sender, EventArgs e)
        {

            txtEditor.BackColor = Color.IndianRed;
            staColor.Text = txtEditor.BackColor.ToString();

        }

        private void mnuBlueBg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleTurquoise;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuGreenbg_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleGreen;
            staColor.Text = txtEditor.BackColor.ToString();

        }

        private void mnuBg_Click(object sender, EventArgs e)
        {
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.BackColor = dlgColor.Color;
                staColor.Text = txtEditor.BackColor.ToString();
            }
        }

        private void mnuFg_Click(object sender, EventArgs e)
        {
            var result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.ForeColor = dlgColor.Color;
                staForeColor.Text = txtEditor.BackColor.ToString();
            }
        }

        private void mnuRed2_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.IndianRed;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuBlue2_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleTurquoise;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuGreen2_Click(object sender, EventArgs e)
        {
            txtEditor.BackColor = Color.PaleGreen;
            staColor.Text = txtEditor.BackColor.ToString();
        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Left;
        }

        private void mnuAlignCenter_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Center;
        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            txtEditor.TextAlign = HorizontalAlignment.Right;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            var result = dlgFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEditor.Font = dlgFont.Font;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            var result = dlgSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgSave.FileName;
               
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(txtEditor.Text);
                    
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
               finally
                {
                    if(sw != null)
                    {
                      sw.Close();
                    }
                    if(fs!= null)
                    {

                    fs.Close(); 
                    }
                    
                }
                

            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            var result = dlgOpen.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgOpen.FileName;

                FileStream fs = null;
                StreamReader sw = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Open);
                    sw = new StreamReader(fs);
                    txtEditor.Text = sw.ReadToEnd();

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"{ex.Message}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                    if (fs != null)
                    {

                        fs.Close();
                    }

                }


            }
        }

        private void toRight_Click(object sender, EventArgs e)
        {
            mnuAlignRight_Click(null , null);
        }

        private void toCenter_Click(object sender, EventArgs e)
        {
            mnuAlignCenter_Click(null , null);
        }

        private void toLeft_Click(object sender, EventArgs e)
        {
            mnuAlignLeft_Click(null , null);
        }
    }
}
