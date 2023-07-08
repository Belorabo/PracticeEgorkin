using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            Directory.CreateDirectory("data\\" + dir);

            var sw = new StreamWriter("data\\" + dir + "data.ls");

            string enctxt = Shifr.Encrypt(textBox1.Text);

            sw.WriteLine(enctxt);

            sw.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dir = textBox1.Text;

            StreamReader sr = new StreamReader(Application.StartupPath + "\\data\\" + dir + "data.ls");
            string line = sr.ReadLine();

            textBox1.Text = Shifr.Rashifr(Convert.ToString(line));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = textBox2.Text;
            Directory.CreateDirectory("data\\" + dir);

            var sw = new StreamWriter("data\\" + dir + "data.ls");

            string enctxt = Shifr.Encrypt(textBox1.Text);

            sw.WriteLine(enctxt);

            sw.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string dir = textBox2.Text;

            StreamReader sr = new StreamReader(Application.StartupPath + "\\data\\" + dir + "data.ls");
            string line = sr.ReadLine();

            textBox2.Text = Shifr.Rashifr(Convert.ToString(line));
        }
        
    }
}
