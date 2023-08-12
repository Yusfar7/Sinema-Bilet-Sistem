using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Sistem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int tabanFiyat = 0;
        int biletFiyat = 0;
        int a = 0;
        int b = 0;
        public void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        public void button25_Click(object sender, EventArgs e)
        {
            biletFiyat = Convert.ToInt32(textBox1.Text);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            button1.BackColor = Color.Orange;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            a = 2;
            button2.BackColor = Color.Orange;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            a = 3;
            button3.BackColor = Color.Orange;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            a = 4;
            button4.BackColor = Color.Orange;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            a = 5;
            button5.BackColor = Color.Orange;
        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            a = 6;
            button6.BackColor = Color.Orange;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            a = 7;
            button7.BackColor = Color.Orange;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            a = 8;
            button8.BackColor = Color.Orange;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            a = 9;
            button9.BackColor = Color.Orange;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            a = 10;
            button10.BackColor = Color.Orange;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            a = 11;
            button11.BackColor = Color.Orange;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            a = 12;
            button12.BackColor = Color.Orange;
        }

        public void button13_Click(object sender, EventArgs e)
        {
            a = 13;
            button13.BackColor = Color.Orange;
        }

        public void button14_Click(object sender, EventArgs e)
        {
            a = 14;
            button14.BackColor = Color.Orange;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            a = 15;
            button15.BackColor = Color.Orange;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            a = 16;
            button16.BackColor = Color.Orange;
        }

        public void button17_Click(object sender, EventArgs e)
        {
            a = 17;
            button17.BackColor = Color.Orange;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            a = 18;
            button18.BackColor = Color.Orange;
        }

        public void button19_Click(object sender, EventArgs e)
        {
            a = 19;
            button19.BackColor = Color.Orange;
        }

        public void button20_Click(object sender, EventArgs e)
        {
            a = 20;
            button20.BackColor = Color.Orange;
        }

        public void button21_Click(object sender, EventArgs e)
        {
            a = 21;
            button21.BackColor = Color.Orange;
        }

        public void button22_Click(object sender, EventArgs e)
        {
            a = 22;
            button22.BackColor = Color.Orange;
        }

        public void button23_Click(object sender, EventArgs e)
        {
            a = 23;
            button23.BackColor = Color.Orange;
        }

        public void button24_Click(object sender, EventArgs e)
        {
            a = 24;
            button24.BackColor = Color.Orange;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button26_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                button1.BackColor = Color.Red;
            }
            else if (a == 2)
            {
                button2.BackColor = Color.Red;
            }
            else if (a == 3)
            {
                button3.BackColor = Color.Red;
            }
            else if (a == 4)
            {
                button4.BackColor = Color.Red;
            }
            else if (a == 5)
            {
                button5.BackColor = Color.Red;
            }
            else if (a == 6)
            {
                button6.BackColor = Color.Red;
            }
            else if (a == 7)
            {
                button7.BackColor = Color.Red;
            }
            else if (a == 8)
            {
                button8.BackColor = Color.Red;
            }
            else if (a == 9)
            {
                button9.BackColor = Color.Red;
            }
            else if (a == 10)
            {
                button10.BackColor = Color.Red;
            }
            else if (a == 11)
            {
                button11.BackColor = Color.Red;
            }
            else if(a == 12)
            {
                button12.BackColor = Color.Red;
            }
            else if (a == 13)
            {
                button13.BackColor = Color.Red;
            }
            else if (a == 14)
            {
                button14.BackColor = Color.Red;
            }
            else if(a == 15)
            {
                button15.BackColor = Color.Red;
            }
            else if(a == 16)
            {
                button16.BackColor = Color.Red;
            }
            else if(a == 17)
            {
                button17.BackColor = Color.Red;
            }
            else if (a == 18)
            {
                button18.BackColor = Color.Red;
            }
            else if (a == 19)
            {
                button19.BackColor = Color.Red;
            }
            else if (a == 20)
            {
                button20.BackColor = Color.Red;
            }
            else if (a == 21)
            {
                button21.BackColor = Color.Red;
            }
            else if(a == 22)
            {
                button22.BackColor = Color.Red;
            }
            else if (a == 23)
            {
                button23.BackColor = Color.Red;
            }
            else if (a ==24) 
            {
                button24.BackColor = Color.Red;
            }
            if (radioButton2.Checked)
            {
                biletFiyat = (biletFiyat * 8) / 10;
            }
            if(b == 1)
            {
                biletFiyat = (biletFiyat * 8) / 10;
            }
            else if(b == 2)
            {
                biletFiyat = (biletFiyat * 6) / 10;
            }
            label3.Text = "Bilet Tutarı: " + biletFiyat;
            richTextBox1.Text += "Biletim: \n--------------------------------\n" + textBox3.Text;
            if (radioButton2.Checked)
            {
                richTextBox1.Text += "\nBilet Türü: ÖĞRENCİ\n";
            }
            else
            {
                richTextBox1.Text += "\nBilet Türü: TAM\n";
            }
            if (a == 1)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 2)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 3)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 4)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 5)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 6)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 7)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 8)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 9)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 10)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 11)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 12)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 13)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 14)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 15)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 16)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 17)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 18)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 19)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 20)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 21)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 22)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 23)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            else if (a == 24)
            {
                richTextBox1.Text += "Koltuk No: " + a + "\n";
            }
            richTextBox1.Text += "Bilet Tutarı: " + biletFiyat + "\n";
            biletFiyat = Convert.ToInt32(textBox1.Text);




        }

        public void button27_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "abc")
            {
                b = 1;
            }
            else if(textBox2.Text == "123") 
            {
                b = 2;
            }
            else
            {
                b = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }


        private void button28_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult answer = pd.ShowDialog();
            if (answer == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font,
           Brushes.DarkOrange, new Point(100, 100));
        }
    }
}
