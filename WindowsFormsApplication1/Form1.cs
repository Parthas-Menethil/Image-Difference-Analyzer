using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bit = (Bitmap)Bitmap.FromFile("E:\\source.JPG");
            lbl_timespan.Text = "Process Time:" + EdgeOptimize(bit, (int)nud_offset.Value).ToString();
            bit.Save("E:\\refined.bmp");
        }
        private TimeSpan EdgeOptimize(Bitmap b){
            Color c;
            DateTime start_time = DateTime.Now;
            for (int x = 0; x < b.Size.Width; x++){
                for (int y = 0; y < b.Size.Height; y++){
                    c = b.GetPixel(x, y);
                    string hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
                    int ret = Convert.ToInt32(hex, 16);
                    if (ret <= 8388607){
                        c = Color.FromArgb(0, 0, 0);
                    }
                    else{
                        c = Color.FromArgb(255, 255, 255);
                    }
                    b.SetPixel(x, y, c);
                }
            }
            return DateTime.Now - start_time;
        }
        private TimeSpan EdgeOptimize(Bitmap b, int ignore)
        {
            Color c;
            ignore++;
            DateTime start_time = DateTime.Now;
            int picWidth = b.Size.Width, picHeight = b.Size.Height;
            for (int x = 0; x <= picWidth; x+=ignore)
            {
                for (int y = 0; y <= picHeight; y+=ignore)
                {
                    c = b.GetPixel(x, y);
                    string hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
                    int ret = Convert.ToInt32(hex, 16);
                    if (ret <= 8388607)
                    {
                        c = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        c = Color.FromArgb(255, 255, 255);
                    }
                    for (int tX = x; tX < x + ignore && tX < picWidth; tX++)
                    {
                        for (int tY = y; tY < y + ignore && tY < picHeight; tY++) {
                            b.SetPixel(tX, tY, c);
                        }
                    }
                        
                }
            }
            return DateTime.Now - start_time;
        }
    }
}
