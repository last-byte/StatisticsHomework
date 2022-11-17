using System.Net;

namespace HW1_CS
{
    public partial class Form1 : Form
    {
        string username = "";
        string hostname = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            richTextBox1.Text = this.username + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hostname = Dns.GetHostName();
            richTextBox1.Text = this.hostname + '\n';
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}