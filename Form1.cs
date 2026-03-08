using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class 힘들어요 : Form
    {
        Color[] myColors = new Color[] {
            Color.FromArgb(156, 175, 136),
            Color.FromArgb(25, 42, 81),
            Color.FromArgb(210, 201, 175),
            Color.FromArgb(170, 160, 145),
            Color.FromArgb(10, 68, 152)
        };

        int currentColorIndex = 0;

        private List<Image> imageList = new List<Image>();
        private int currentIndex = 0;

        public 힘들어요()
        {
            InitializeComponent();
            LoadImages();
            ShowImage();
        }


        
        private void LoadImages()
        {
            imageList.Add(Properties.Resources.photo1);
            imageList.Add(Properties.Resources.photo2);
            imageList.Add(Properties.Resources.photo3);
            imageList.Add(Properties.Resources.photo4);
            imageList.Add(Properties.Resources.photo5);

        }

        private void ShowImage()
        {
            if (imageList.Count > 0)
            {
                pictureBox1.Image = imageList[currentIndex];
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = imageList.Count - 1;
            }

            ShowImage();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageList.Count == 0) return;

            currentIndex++;
            if (currentIndex >= imageList.Count)
            {
                currentIndex = 0;
            }

            ShowImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentColorIndex = (currentColorIndex + 1) % myColors.Length;
            this.BackColor = myColors[currentColorIndex];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/2wx8nd-creator",
                UseShellExecute = true
            });
        }
    }
}
