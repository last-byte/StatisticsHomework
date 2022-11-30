namespace RectangleResize
{
    public partial class Form1 : Form
    {
        Rectangle rec = new Rectangle(30, 30, 500, 200);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            Graphics g = Graphics.FromImage(b);
            g.DrawRectangle(new Pen(Color.Orange), rec);
            g.FillRectangle(Brushes.Orange, rec.Left, rec.Top, rec.Width, rec.Height);
        }

        private void pictureBox1_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                rec.Width = rec.Width + 50;
                rec.Height = rec.Height + 50;
            }
            else
            {
                rec.Width = rec.Width - 50;
                rec.Height = rec.Height - 50;
            }

            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            g.FillRectangle(Brushes.Black, 0, 0, b.Width, b.Height);
            g.DrawRectangle(new Pen(Color.Orange), new Rectangle(rec.Left, rec.Top, rec.Width, rec.Height));
            g.FillRectangle(Brushes.Orange, rec.Left, rec.Top, rec.Width, rec.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}