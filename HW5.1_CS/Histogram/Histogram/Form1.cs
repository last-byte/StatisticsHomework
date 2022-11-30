namespace Histogram
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

        private void drawHistogram(Rectangle rec, double[] distr)
        {
            Form fHorizontal = new Form2();
            Form fVertical = new Form2();
            Bitmap b = new Bitmap(fHorizontal.Width, fHorizontal.Height);
            Bitmap b2 = new Bitmap(fHorizontal.Width, fHorizontal.Height);
            fHorizontal.BackgroundImageLayout = ImageLayout.Center;
            fHorizontal.BackgroundImage = b;
            fVertical.BackgroundImageLayout = ImageLayout.Center;
            fVertical.BackgroundImage = b2;
            Graphics g = Graphics.FromImage(b);
            Graphics g2 = Graphics.FromImage(b2);
            g.DrawRectangle(new Pen(Color.Black), rec);
            g2.DrawRectangle(new Pen(Color.Black), rec);

            int x = rec.X;
            double maxN = distr.Max() + 1;
            int recWidth = rec.Width / distr.Length;
            SolidBrush brush = new SolidBrush(Color.Orange);
            Pen pen = new Pen(Color.Gray);
            for (int i = distr.Length - 1; i >= 0; i--)
            {
                int recHeight = (int)((rec.Height * distr[i]) / maxN);
                g.FillRectangle(brush, new Rectangle(x, rec.Top, recWidth, recHeight));
                g.DrawRectangle(pen, new Rectangle(x, rec.Top, recWidth, recHeight));

                g2.FillRectangle(brush, new Rectangle(x, rec.Top, recWidth, recHeight));
                g2.DrawRectangle(pen, new Rectangle(x, rec.Top, recWidth, recHeight));

                x += recWidth;
            }

            b.RotateFlip(RotateFlipType.Rotate180FlipNone);
            fHorizontal.Show();

            b2.RotateFlip(RotateFlipType.Rotate270FlipNone);
            fVertical.Show();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {   
            Rectangle rec = new Rectangle(20, 20, 400, 200);
            double[] numList = new double[] { 2.7, 5.5, 4.9, 7.7, 9.2, 1.1, 1.7, 3.5, 3.2 };
            drawHistogram(rec, numList);
        }
    }
}
