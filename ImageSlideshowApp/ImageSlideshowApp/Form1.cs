using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace ImageSlideshowApp
{
    public partial class Form1 : Form
    {

        

        private string[] imagePaths = new string[]
        {

            "https://khalej-gate.com/user_images/news/image-20240725140007-1.png",
            "https://pbs.twimg.com/media/DknP7NcWwAIiYN-.jpg",
            "https://static.dw.com/image/43945149_604.jpg",
            "https://www.365scores.com/ar/news/magazine/wp-content/uploads/2021/08/ronaldo-11-1.jpg",



        };

        private int currentIndex = 0; 

        public Form1()
        {
            InitializeComponent();
            DisplayImage(); 
        }

        
        private void DisplayImage()
        {
            if (imagePaths.Length > 0)
            {
                pictureBox1.ImageLocation = imagePaths[currentIndex];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length; 
            DisplayImage();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length; 
            DisplayImage();
        }
    }
}
