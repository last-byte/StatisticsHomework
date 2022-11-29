using System;
using System.Drawing;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace HW4_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        double probabilityOfSuccess = 0.5;
        int simulations = 0;
        public Bitmap b;
        public Graphics g;
        public Chart c;
        public int heads = 0;                                                    // A trial toss is considered head if toss >= success prob
        public int tails = 0;
        public double head_rf = 0;                                               // heads & tails realative frequency 
        public double tails_rf = 0;
        public double head_nf = 0;                                               // heads & tails normalized frequency
        public double tail_nf = 0;
        public int count = 0;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.g = Graphics.FromImage(b);
            this.c = new Chart();
        }


        public int resizeX(double minX, double maxX, int W, double x)
        {
            return Convert.ToInt32(((x - minX) * W) / (maxX - minX));
        }
        public int resizeY(double minY, double maxY, int H, double y)
        {
            return Convert.ToInt32(H - ((y - minY) * H) / (maxY - minY));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Absolute Frequency")
            {
                this.numericUpDown1.Enabled = false;
                this.button1.Text = "Stop";
                probabilityOfSuccess = ((Convert.ToDouble(numericUpDown1.Value)) / 100);
                timer1.Start();
            }
            else
            {
                this.button1.Text = "Absolute Frequency";
                timer1.Stop();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int trials = 1000;
            int flip= 0;
            simulations+=1;

            Point[] points1 = new Point[trials];

            for (int i = 0; i < trials; i++)
            {
                double uniform = r.NextDouble();
                if (uniform < probabilityOfSuccess) { heads++; head_rf = flip * trials / (i + 1); head_nf = flip * (Math.Sqrt(trials)) / (Math.Sqrt(i + 1)); flip++; }
                else { tails++; tails_rf = (trials - flip) * trials / (i + 1); tail_nf = ((trials - flip) * (Math.Sqrt(trials))) / (Math.Sqrt(i + 1)); }

                Point dist_1 = new Point(); 
                dist_1.Y = resizeY(0, trials, pictureBox1.Height, flip);
                dist_1.X = resizeX(0, trials, pictureBox1.Width, i);


                points1[i] = dist_1;

            }

            this.g.DrawLines(Pens.Pink, points1);
            this.pictureBox1.Image = b;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "Relative Frequency")
            {
                this.numericUpDown1.Enabled = false;
                this.button2.Text = "Stop";
                probabilityOfSuccess = ((Convert.ToDouble(numericUpDown1.Value)) / 100);
                timer2.Start();
            }
            else
            {
                this.button2.Text = "Relative Frequency";
                timer2.Stop();
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int trials2 = 1000;
            int flip2 = 0;
            simulations+=1;
            Point[] points2 = new Point[trials2];
            for (int i = 0; i < trials2; i++)
            {
                double uniform = r.NextDouble();
                if (uniform < probabilityOfSuccess) flip2++;
                Point dist_2 = new Point(); 
                dist_2.Y = resizeY(0, trials2, pictureBox1.Height, flip2 * trials2 / (i + 1));
                dist_2.X = resizeX(0, trials2, pictureBox1.Width, i);
                points2[i] = dist_2;
            }
            this.g.DrawLines(Pens.DeepSkyBlue, points2);
            this.pictureBox1.Image = b;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text == "Normalized Frequency")
            {
                this.numericUpDown1.Enabled = false;
                this.button3.Text = "Stop";
                probabilityOfSuccess = ((Convert.ToDouble(numericUpDown1.Value)) / 100);
                timer3.Start();
            }
            else
            {
                this.button3.Text = "Normalized Frequency";
                timer3.Stop();
            }

        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            int trials3 = 1000;
            int flip3 = 0;
            simulations+=1;

            Point[] points3 = new Point[trials3];

            for (int i = 0; i < trials3; i++)
            {
                double uniform = r.NextDouble();
                if (uniform < probabilityOfSuccess) flip3++;
                Point dist_3 = new Point();
                dist_3.Y = resizeY(0, trials3 * probabilityOfSuccess, pictureBox1.Height, flip3 * (Math.Sqrt(trials3)) / (Math.Sqrt(i + 1)));
                dist_3.X = resizeX(0, trials3, pictureBox1.Width, i);
                points3[i] = dist_3;

            }
            this.g.DrawLines(Pens.OrangeRed, points3);
            this.pictureBox1.Image = b;
        }

        private void fillChart()
        {

            chart1.Series["Distributions"].Points.AddXY("N° Heads", heads);
            chart1.Series["Distributions"].Points.AddXY("N° Tails", tails);
            chart1.Series["Distributions"].Points.AddXY("Heads RF", head_rf);
            chart1.Series["Distributions"].Points.AddXY("Tails RF", tails_rf);
            chart1.Series["Distributions"].Points.AddXY("Heads NF", head_rf);
            chart1.Series["Distributions"].Points.AddXY("Tails NF", tails_rf);

            string c = "Distribution Chart " + count.ToString();
            chart1.Titles.Add(c);

        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (this.button4.Text == "Histogram")
            {
                fillChart();
                this.button4.Text = "Clear";

            }
            else
            {

                this.chart1.Series.Clear();
                this.button4.Text = "Histogram";
                heads = 0;
                tails = 0;
                head_rf = 0;
                tails_rf = 0;
                head_nf = 0;
                tail_nf = 0;
                simulations = 0;

            }
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text == "All")
            {
                this.numericUpDown1.Enabled = false;
                this.button5.Text = "Stop";
                probabilityOfSuccess = ((Convert.ToDouble(numericUpDown1.Value)) / 100);
                timer3.Start();
                timer1.Start();
                timer2.Start();
            }
            else
            {
                this.button5.Text = "All";
                timer3.Stop();
                timer1.Stop();
                timer2.Stop();
            }

        }
    }
}
