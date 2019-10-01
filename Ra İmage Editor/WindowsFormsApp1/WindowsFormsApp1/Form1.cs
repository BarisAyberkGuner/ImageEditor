using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog dosya = new OpenFileDialog();
        Image file;

        Boolean acilmis = false;

        void resimAc()
        {
            //OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Goruntu Sec |*.jpg;*.png;*.bmp;*.jpeg";


            if (dosya.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(dosya.FileName);
                pictureBox1.Image = file;
            }
            Image resim = pictureBox1.Image;
            Bitmap yeni = new Bitmap(resim);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = yeni;
            acilmis = true;
        }
        void yenidenAc()
        {
            if (!acilmis)
            {
                MessageBox.Show("İşlem yapmak için bir görüntü seçmek zorundasınız !!", "UYARI");
            }
            else
            {
                if (acilmis)
                {
                    file = Image.FromFile(dosya.FileName);
                    pictureBox1.Image = file;
                    acilmis = true;
                }
                Image resim = pictureBox1.Image;
                Bitmap yeni = new Bitmap(resim);
                acilmis = true;
            }

        }
        void goruntuKaydet()
        {
            if (acilmis)
            {
                SaveFileDialog kaydet = new SaveFileDialog();
                kaydet.Filter = "Resimler|*.png;*.bmp;*.jpg";
                kaydet.Title = " Görüntünün Kaydedileceği Yeri Seçiniz !!";
                ImageFormat format = ImageFormat.Png; //Default formatı ayarlıyoruz
                if (kaydet.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(kaydet.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(kaydet.FileName, format);
                }

            }
            else { MessageBox.Show("Bir goruntu açılmadı !! Öncelikle bir görünütü açın !!", "UYARI"); }

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resimAc();

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }


        private void gARAVELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //histogram
            if (acilmis)
            {
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);

                int genis = resim.Width;
                int uzun = resim.Height;
                Color p;

                int[] kirmiziP = new int[256];
                int[] yesilP = new int[256];
                int[] maviP = new int[256];
                for (int i = 0; i < 256; i++)
                {
                    chart1.Series["Red"].Points.Clear();
                    chart1.Series["Green"].Points.Clear();
                    chart1.Series["Blue"].Points.Clear();

                }

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        p = bmpm.GetPixel(x, y);
                        kirmiziP[p.R]++;
                        yesilP[p.G]++;
                        maviP[p.B]++;
                    }
                }
                for (int i = 0; i < 256; i++)
                {
                    chart1.Series["Red"].Points.AddY(kirmiziP[i]);
                    chart1.Series["Green"].Points.AddY(yesilP[i]);
                    chart1.Series["Blue"].Points.AddY(maviP[i]);
                }
                chart1.Visible = true;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            }         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void görüntüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void terslemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Negatif Filtre
            if (acilmis)
            {
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);


                int uzun = resim.Height;
                int genis = resim.Width;

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        Color p = bmpm.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        bmpm.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                pictureBox1.Image = bmpm;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !! ", "UYARI");
            }

        }

        private void aynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aynalama
            if (acilmis)
            {
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);

                int genis = resim.Width;
                int uzun = resim.Height;

                Bitmap cevir = new Bitmap(genis, uzun);

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 1; x < genis; x++)
                    {
                        Color p = bmpm.GetPixel(genis - x, y);
                        cevir.SetPixel(x, y, p);
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            }
        }

        private void saatYönünde90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saga Don
            if (acilmis)
            {
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);

                int genis = resim.Width;
                int uzun = resim.Height;
                int yeniGenis = resim.Height;
                int yeniUzun = resim.Width;

                Bitmap cevir = new Bitmap(yeniGenis, yeniUzun);

                for (int y = 0; y < yeniUzun; y++)
                {
                    for (int x = 1; x < yeniGenis; x++)
                    {
                        Color p = bmpm.GetPixel(y, x);
                        cevir.SetPixel(yeniGenis - x, y, p);
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            }    
        }
       
        private void saatYönününTersine90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sola Don
            if (acilmis)
            {
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);

                int genis = resim.Width;
                int uzun = resim.Height;

                Bitmap cevir = new Bitmap(uzun, genis);

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 1; x < genis; x++)
                    {
                        Color p = bmpm.GetPixel(x, y);
                        cevir.SetPixel(y, genis - x, p);
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            }          
        }


        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goruntuKaydet();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yenidenAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidenAc();
        }

 
        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acilmis)
            {
                yenidenAc();
                Image resim = pictureBox1.Image;
                Bitmap yeni = new Bitmap(resim);

                int genis = yeni.Width;
                int uzun = yeni.Height;


                Bitmap cevir = new Bitmap(genis, uzun);
                Color p;

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        p = yeni.GetPixel(x, y);

                        int a = p.A;
                        int red = p.R;

                        cevir.SetPixel(x, y, Color.FromArgb(a, red, 0, 0));
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!" , "UYARI");
            
   
            
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acilmis)
            {
                yenidenAc();
                Image resim = pictureBox1.Image;
                Bitmap yeni = new Bitmap(resim);

                int genis = yeni.Width;
                int uzun = yeni.Height;


                Bitmap cevir = new Bitmap(genis, uzun);
                Color p;

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        p = yeni.GetPixel(x, y);

                        int a = p.A;
                        int green = p.G;

                        cevir.SetPixel(x, y, Color.FromArgb(a, 0, green, 0));
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acilmis)
            {
                yenidenAc();
                Image resim = pictureBox1.Image;
                Bitmap yeni = new Bitmap(resim);

                int genis = yeni.Width;
                int uzun = yeni.Height;


                Bitmap cevir = new Bitmap(genis, uzun);
                Color p;

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        p = yeni.GetPixel(x, y);

                        int a = p.A;
                        int blue = p.B;

                        cevir.SetPixel(x, y, Color.FromArgb(a, 0, 0, blue));
                    }
                }
                pictureBox1.Image = cevir;
            }
            else
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
           
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gri Filtre
            if (acilmis)
            {
                yenidenAc();
                Image resim = pictureBox1.Image;
                Bitmap bmpm = new Bitmap(resim);

                int genis = resim.Width;
                int uzun = resim.Height;

                Bitmap cevir = new Bitmap(genis, uzun);
                Color p;

                for (int y = 0; y < uzun; y++)
                {
                    for (int x = 0; x < genis; x++)
                    {
                        p = bmpm.GetPixel(x, y);

                        int a = p.A;
                        int red = p.R;
                        int green = p.G;
                        int blue = p.B;

                        int ort = (red + green + blue) / 3;

                        bmpm.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));
                    }
                }
                pictureBox1.Image = bmpm;
            }
            else
            {
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (acilmis)
            {
                int uzun;
                int genis;
                genis = Convert.ToInt32(textBox1.Text);
                uzun = Convert.ToInt32(textBox2.Text);
                


                Image resim = pictureBox1.Image;
                Bitmap yeni = new Bitmap(resim, genis, uzun);

                pictureBox1.Image = yeni;
            }
            else
                MessageBox.Show("Görüntü açmadan işlem yapamazsınız !!", "UYARI");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis;
            cikis = MessageBox.Show("Çıkmak istiyor musunuz ?", "ÇIKIŞ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                if (acilmis)
                {
                    goruntuKaydet();
                }
                Close();
            }
        }
    }

}
