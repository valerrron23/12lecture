using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace lektsia_12
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);
            Bitmap theImg = new Bitmap(@"l://star.bmp");
            Bitmap smallImg = new Bitmap(theImg, new Size(theImg.Width/3 , theImg.Height/3 ));
            Brush tBrush = new TextureBrush(smallImg,
                new Rectangle(0, 0, smallImg.Width, smallImg.Height)
            );

            Font tFont = new Font("Times New Roman", 32, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello, from Beginning Visual", tFont, tBrush, ClientRectangle);
            tBrush.Dispose();
            tFont.Dispose();

        }
    }
}