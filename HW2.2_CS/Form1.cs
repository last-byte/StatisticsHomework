using Microsoft.VisualBasic.FileIO;

namespace Homework2._2Csharp
{
    public partial class Form1 : Form
    {
        TextFieldParser parser = new TextFieldParser(@"C:/email.csv");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while(!parser.EndOfData)
            {
                string line = parser.ReadLine();
                this.textBox1.Text += line + "\r\n";

            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            parser = new TextFieldParser(@"C:/email.csv");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}