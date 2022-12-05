using Microsoft.VisualBasic.FileIO;

namespace Homewrok3Csharp
{
    
    public partial class Form1 : Form
    {
        TextFieldParser parser = new TextFieldParser(@"..\\..\\..\\wireshark.csv");
        string[]? values = null;

        public Form1()
        {  
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            values = parser.ReadFields();
            foreach (string s in values)
            {
                string m = s.Trim('"');
                dataGridView3.Columns.Add(m, m);

            }
        while (!parser.EndOfData)
            {
                string[] line = parser.ReadFields();
                for (int i = 0; i < line.Length; i++)
                {
                    line[i] = line[i].Trim('"');

                }
                dataGridView3.Rows.Add(line);

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}