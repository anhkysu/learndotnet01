using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                panel6.Size = panel6.MaximumSize;
                panel8.Size = panel8.MaximumSize;
                return;
            }
            else 
            {
                panel6.Size = panel6.MinimumSize;
                panel8.Size = panel8.MinimumSize;
                return;
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            
           
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void TextBox1_MouseMove(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, folderBrowserDialog1.SelectedPath);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            textBox2.Text = folderBrowserDialog2.SelectedPath;
        }

        private void TextBox2_MouseMove(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox2, folderBrowserDialog2.SelectedPath);
        }
    }
}
