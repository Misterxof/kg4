using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;


using System.Numerics;
using AForge.Imaging;

namespace kg4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Image image, origImage;

       

        private List<Vector2> ConvertToPointCollection(int[] values)
        {
          

            int max = values.Max();

           List<Vector2> points = new List<Vector2>();
            // first point (lower-left corner)
            points.Add(new Vector2(0, max));
            // middle points
            for (int i = 0; i < values.Length; i++)
            {
                points.Add(new Vector2(i, max - values[i]));
            }
            // last point (lower-right corner)
            points.Add(new Vector2(values.Length - 1, max));

            return points;
        }
        System.Drawing.Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                image = System.Drawing.Image.FromFile(ofd.FileName);
                //pictureBox2.Height = System.Drawing.Image.FromFile(ofd.FileName).Height;
               // pictureBox2.Width = System.Drawing.Image.FromFile(ofd.FileName).Width;
                //image.set = System.Drawing.Image.FromFile(ofd.FileName).Height;
            }
                

            pictureBox1.Image = image;
            //pictureBoxBoxStart.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxBoxEnd.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox1.Image = CalculateBarChart(image);


            bmp = new System.Drawing.Bitmap(ofd.FileName);
             // Luminance
             ImageStatisticsHSL hslStatistics = new ImageStatisticsHSL(bmp);
             int[] luminanceValues = hslStatistics.Luminance.Values;
             // RGB
             ImageStatistics rgbStatistics = new ImageStatistics(bmp);
             int[] redValues = rgbStatistics.Red.Values;
             int[] greenValues = rgbStatistics.Green.Values;
             int[] blueValues = rgbStatistics.Blue.Values;

           /* List<Vector2> l = ConvertToPointCollection(hslStatistics.Luminance.Values);
            //List<Vector2> r = ConvertToPointCollection(rgbStatistics.Red.Values);
            Point[] points = new Point[l.Count];

            for (int i = 0; i < l.Count; i++)
            {
                float x = l.ElementAt(i).X;
                float y = l.ElementAt(i).Y;
                
                //points[i] = new Point((int)x, (int)y);
                Console.WriteLine("x " + x + " y " + y);
                chart1.Series[0].Points.AddXY(x, y);
               
            }*/
           AForge.Math.Histogram activeHistogram = null;
            ImageStatistics stat;
           // var imag = (Bitmap)image.Clone();
            stat =  new ImageStatistics(bmp);
            histogram1.Color = Color.Red;
            histogram2.Color = Color.Green;
            histogram3.Color = Color.Blue;
            histogram4.Color = Color.Black;
            activeHistogram = stat.Red;
            histogram1.Values = activeHistogram.Values;
            activeHistogram = stat.Green;
            histogram2.Values = activeHistogram.Values;
            activeHistogram = stat.Blue;
            histogram3.Values = activeHistogram.Values;
            
            //activeHistogram = hslStatistics.;
            histogram4.Values = hslStatistics.Luminance.Values;
            /*Graphics g = CreateGraphics();
            g.DrawPolygon(Pens.Gray, points);*/




        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kernel = new double[,]
                             {{0.1, 0.1, 0.1},
                              {0.1, 0.1, 0.1},
                              {0.1, 0.1, 0.1}};
            var imag = (Bitmap)image.Clone();
            const double scale = 9;
            byte[,] mask3 = new byte[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            //Convolution(imag, kernel);
            pictureBox2.Image = Filter33(imag, mask3, scale);
        }

        static Bitmap Filter33(Bitmap image, byte[,] mask, double scale)
        {
            int imageWidth = image.Width, imageHeight = image.Height;
            Bitmap result = new Bitmap(imageWidth, imageHeight);
            for (int i = 2; i < imageWidth - 1; i++)
                for (int j = 2; j < imageHeight - 1; j++)
                {
                    int red = 0, green = 0, blue = 0, alpha = 0;
                    for (int x = -1; x <= 1; x++)
                        for (int y = -1; y <= 1; y++)
                        {
                            Color pixel = image.GetPixel(i + x, j + y);
                            red += pixel.R * mask[x + 1, y + 1];
                            green += pixel.G * mask[x + 1, y + 1];
                            blue += pixel.B * mask[x + 1, y + 1];
                            alpha += pixel.A;
                        }
                    result.SetPixel(i, j, Color.FromArgb(
                        (int)(alpha / scale),
                        (int)(red / scale),
                        (int)(green / scale),
                        (int)(blue / scale)));
                }
            return result;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var kernel = new double[,]
                             {{0.1, 0.3, 0.1},
                              {0.3, 0.16, 0.3},
                              {0.1, 0.3, 0.1}};
            var imag = (Bitmap)image.Clone();
            const double scale = 9;
            byte[,] mask3 = new byte[,] { { 1, 3, 1 }, { 3, 16, 3 }, { 1, 3, 1 } };
            //Convolution(imag, kernel);
            pictureBox2.Image = Gaussian(imag);
        }

        Bitmap Gaussian(Bitmap bmp)

        {

            Bitmap rezultImage = new Bitmap(bmp);

            int i, j, k, m, count;

            int R, G, B;

            int[] Red, Green, Blue;

            //Матрица для этого фильтра будет иметь вид:

            // 1 2 1 | A0 A1 A2

            // 2 4 2 | A3 A4 A5

            // 1 2 1 | A6 A7 A8

            for (i = 1; i < (bmp.Width - 1); i++)

            {

                for (j = 1; j < (bmp.Height - 1); j++)

                {

                    Red = new int[9];

                    Green = new int[9];

                    Blue = new int[9];

                    count = 0;

                    for (k = -1; k <= 1; k++)

                    {

                        for (m = -1; m <= 1; m++)

                        {

                            Red[count] = bmp.GetPixel(i + k, j + m).R;

                            Green[count] = bmp.GetPixel(i + k, j + m).G;

                            Blue[count] = bmp.GetPixel(i + k, j + m).B;

                            count++;

                        }

                    }

                    //Находим сумму красного в окне фильтра 3х3

                    R = Red[0] + 4 * Red[1] + Red[2] + 4 * Red[3] + 12 * Red[4] + 4 * Red[5] + Red[6] + 4 * Red[7] + Red[8];

                    //Выполняем аналогичные операции для синего (B) и зеленого (G)

                    G = Green[0] + 4 * Green[1] + Green[2] + 4 * Green[3] + 12 * Green[4] + 4 * Green[5] + Green[6] + 4 * Green[7] + Green[8];

                    B = Blue[0] + 4 * Blue[1] + Blue[2] + 4 * Blue[3] + 12 * Blue[4] + 4 * Blue[5] + Blue[6] + 4 * Blue[7] + Blue[8];

                    //Делим полученные значения на сумму коэффициентов матрицы

                    R = R / 32;

                    G = G / 32;

                    B = B / 32;

                    //Помещаем полученные значения средних в центральный пиксель i, j

                    rezultImage.SetPixel(i, j, Color.FromArgb(R, G, B));

                }

            }

            return rezultImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var kernel = new double[,]
                             {{0.1, 0.1, 0.1},
                              {0.1, 0.4, 0.1},
                              {0.1, 0.1, 0.1}};
            var imag = (Bitmap)image.Clone();
            const double scale = 12;
            byte[,] mask3 = new byte[,] { { 1, 1, 1 }, { 1, 4, 1 }, { 1, 1, 1 } };
            //Convolution(imag, kernel);
            pictureBox2.Image = Filter33(imag, mask3, scale);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap eq = equalizing(bmp);
            pictureBox2.Image = eq;
            ImageStatisticsHSL hslStatistics = new ImageStatisticsHSL(eq);
            histogram5.Values = hslStatistics.Luminance.Values;
           
        }
        public Bitmap equalizing(Bitmap bmp)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = bmpData.Stride * bmp.Height;
            byte[] grayValues = new byte[bytes];
            int[] R = new int[256];
            byte[] N = new byte[256];
            byte[] left = new byte[256];
            byte[] right = new byte[256];
            System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
            for (int i = 0; i < grayValues.Length; i++) ++R[grayValues[i]];
            int z = 0;
            int Hint = 0;
            int Havg = grayValues.Length / R.Length;
            for (int i = 0; i < N.Length - 1; i++)
            {
                N[i] = 0;
            }
            for (int j = 0; j < R.Length; j++)
            {
                if (z > 255) left[j] = 255;
                else left[j] = (byte)z;
                Hint += R[j];
                while (Hint > Havg)
                {
                    Hint -= Havg;
                    z++;
                }
                if (z > 255) right[j] = 255;
                else right[j] = (byte)z;

                N[j] = (byte)((left[j] + right[j]) / 2);
            }
            for (int i = 0; i < grayValues.Length; i++)
            {
                if (left[grayValues[i]] == right[grayValues[i]]) grayValues[i] = left[grayValues[i]];
                else grayValues[i] = N[grayValues[i]];
            }

            System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        const int L = 256;

        private void button6_Click(object sender, EventArgs e)
        {
            var imag = (Bitmap)image.Clone();
            Bitmap eq = AddContrastFilter(imag);
            pictureBox2.Image = eq;
            ImageStatisticsHSL hslStatistics = new ImageStatisticsHSL(eq);
            histogram5.Values = hslStatistics.Luminance.Values;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var imag = (Bitmap)image.Clone();
           // Bitmap eq = AddContrastFilter(imag);
            
            ImageStatisticsHSL hslStatistics = new ImageStatisticsHSL(imag);
            for (int i = 0; i < hslStatistics.Luminance.Values.Length; i++)
                hslStatistics.Luminance.Values[i] = hslStatistics.Luminance.Values[i] + hScrollBar1.Value;

            pictureBox2.Image = imag;
            histogram5.Values = hslStatistics.Luminance.Values;

        }

        Bitmap AddContrastFilter(Bitmap ptrImage)
        {
            //контраст
            //    pict_pixels = new int[image.Width * image.Height];

            int N = (100 / hScrollBar1.Maximum) * hScrollBar1.Value;
            if (N == 100) N = 99;
            if (N == -100) N = -99;

            //fill 
            if (N < 0)
                for (int x = 0; x < ptrImage.Width; x++)
                {
                    for (int y = 0; y < ptrImage.Height; y++)
                    {
                        int newR = (ptrImage.GetPixel(x, y).R * (100 - (N * (-1))) + 128 * (N * (-1))) / 100;
                        int newB = (ptrImage.GetPixel(x, y).B * (100 - (N * (-1))) + 128 * (N * (-1))) / 100;
                        int newG = (ptrImage.GetPixel(x, y).G * (100 - (N * (-1))) + 128 * (N * (-1))) / 100;

                        if (newR > 255) newR = 255;
                        if (newR < 0) newR = 0;
                        if (newB > 255) newB = 255;
                        if (newB < 0) newB = 0;
                        if (newG > 255) newG = 255;
                        if (newG < 0) newG = 0;

                        ptrImage.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                    }
                }

            else if (N > 0)
                for (int x = 0; x < ptrImage.Width; x++)
                {
                    for (int y = 0; y < ptrImage.Height; y++)
                    {
                        int newR = (ptrImage.GetPixel(x, y).R * 100 - 128 * N) / (100 - N);
                        int newB = (ptrImage.GetPixel(x, y).B * 100 - 128 * N) / (100 - N);
                        int newG = (ptrImage.GetPixel(x, y).G * 100 - 128 * N) / (100 - N);

                        if (newR > 255) newR = 255;
                        if (newR < 0) newR = 0;
                        if (newB > 255) newB = 255;
                        if (newB < 0) newB = 0;
                        if (newG > 255) newG = 255;
                        if (newG < 0) newG = 0;

                        ptrImage.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                    }
                }

            // pictureBox1.Image = image;
            return ptrImage;
        }
    }

  
}
