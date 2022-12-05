namespace Homework2._1Csharp
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        double sum=0; //usato per sommare numeir random
        double num=0; //per salvare il numero random
        int i =1;  //usato per dividere e formare la media
        double media = 0; //usato per salvare in quel momento la media

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.ScrollBars = ScrollBars.Vertical;
            num = r.NextDouble();
            this.textBox2.Text += num.ToString() + "\n";
            sum += num;
            media = sum / i;
            this.textBox1.Text = "media = " + media.ToString();
            i++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop(); 
        }
    }
}