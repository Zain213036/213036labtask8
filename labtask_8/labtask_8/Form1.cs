using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labtask_8
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImages(string folderPath)
        {
            imageFiles = System.IO.Directory.GetFiles(folderPath, "*.jpg");

            if (imageFiles.Length > 0)
            {
                DisplayImage(currentIndex);
            }
            else
            {
                MessageBox.Show("No images found in the selected folder.");
            }
        }

        private void DisplayImage(int index)
        {
            if (index >= 0 && index < imageFiles.Length)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[index]);
                label1.Text = $"{index + 1} / {imageFiles.Length}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    LoadImages(folderDialog.SelectedPath);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayImage(currentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                DisplayImage(currentIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}