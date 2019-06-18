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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fileName = "test.txt";
            string sourcePath = $@"{textBox1.Text}";
            string targetPath = $@"{textBox2.Text}";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.Directory.CreateDirectory(targetPath);

            

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);


                foreach (string s in files)
                {

                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (!System.IO.Directory.Exists(@"C:\Users\Public\TestFolder\"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\TestFolder\");
            }

            System.IO.Directory.SetCurrentDirectory(@"C:\Users\Public\TestFolder\");

            string currentDirName = System.IO.Directory.GetCurrentDirectory();

            string[] files = System.IO.Directory.GetFiles(currentDirName, "*.txt");

            foreach (string s in files)
            {
                // Create the FileInfo object only when needed to ensure
                // the information is as current as possible.
                System.IO.FileInfo fi = null;
                try
                {
                    fi = new System.IO.FileInfo(s);
                }
                catch (System.IO.FileNotFoundException errors)
                {
                    // To inform the user and continue is
                    // sufficient for this demonstration.
                    // Your application may require different behavior.
                    Console.WriteLine(errors.Message);
                    continue;
                }
                Console.WriteLine("{0} : {1} : {2}", fi.Name, fi.Directory, fi.Length);
            }
        }
    }
}
