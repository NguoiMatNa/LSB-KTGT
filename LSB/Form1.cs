using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtOpenFile.Text = openDialog.FileName.ToString();
                pictureBox.ImageLocation = txtOpenFile.Text;
            }

        }

        private void btnencode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(txtOpenFile.Text);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < txtMsg.TextLength)
                    {
                        char letter = Convert.ToChar(txtMsg.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, txtMsg.TextLength));
                    }

                }
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
  
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtOpenFile.Text = saveFile.FileName.ToString();
                pictureBox.ImageLocation = txtOpenFile.Text;

                img.Save(txtOpenFile.Text);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(txtOpenFile.Text);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }
            MessageBox.Show(message,"Decode");
            txtMsg.Text = message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
