using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectt
{
    public partial class Form2 : Form
    {
        const double price1 = 900;
       const double  price2 = 600;
        const double price3= 750;
        const double price4 = 900;
        const double price5 = 500;
        const double price6= 900;

        const double price7 = 800;
        const double price8 = 650;
        const double price9 = 600;
        const double price10 = 700;

        double  Quantity1 =0;
        double Quantity2 = 0;
        double Quantity3 = 0;
        double Quantity4 = 0;
        double Quantity5 = 0;
        double Quantity6 = 0;
        double Quantity7 = 0;
        double Quantity8 = 0;
        double Quantity9 = 0;
        double Quantity10 = 0;
        double TotalPrice = 0;
        string DiscountCode = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                Quantity4 = int.Parse(textBox5.Text);
            }

            else
            {
                Quantity4 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                         (Quantity4 * price4) + (Quantity5 * price5)
                       + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                       (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                Quantity5 = int.Parse(textBox4.Text);
            }

            else
            {
                Quantity5 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                          (Quantity4 * price4) + (Quantity5 * price5)
                        + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                        (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Quantity1 = int.Parse(textBox1.Text);
            }

            else
            {
                Quantity1 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                                 (Quantity4 * price4) + (Quantity5 * price5)
                               + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                               (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Quantity2 = int.Parse(textBox2.Text);
            }

            else
            {
                Quantity2 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                          (Quantity3 * price4) + (Quantity3 * price5)
                        + (Quantity3 * price6) + (Quantity3 * price7) + (Quantity3 * price8) +
                        (Quantity3 * price9) + (Quantity3 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                Quantity3 = int.Parse(textBox3.Text);
            }

            else
            {
                Quantity3 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                          (Quantity4 * price4) + (Quantity5 * price5)
                        + (Quantity6* price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                        (Quantity9* price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked)
            {
                Quantity6 = int.Parse(textBox10.Text);
            }

            else
            {
                Quantity6 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                          (Quantity4 * price4) + (Quantity5 * price5)
                        + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                        (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                Quantity7 = int.Parse(textBox9.Text);
            }

            else
            {
                Quantity7 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                                    (Quantity4 * price4) + (Quantity5 * price5)
                                  + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                                  (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
            {
                Quantity8= int.Parse(textBox8.Text);
            }

            else
            {
                Quantity8 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                         (Quantity4 * price4) + (Quantity5 * price5)
                       + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                       (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                Quantity9= int.Parse(textBox7.Text);
            }

            else
            {
                Quantity9= 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                          (Quantity4 * price4) + (Quantity5 * price5)
                        + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                        (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                Quantity10 = int.Parse(textBox6.Text);
            }

            else
            {
                Quantity10 = 0;
            }
            TotalPrice = (Quantity1 * price1) + (Quantity2 * price2) + (Quantity3 * price3) +
                         (Quantity4 * price4) + (Quantity5 * price5)
                       + (Quantity6 * price6) + (Quantity7 * price7) + (Quantity8 * price8) +
                       (Quantity9 * price9) + (Quantity10 * price10);

            textBox11.Text = TotalPrice.ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            DiscountCode = textBox12.Text;

            if (DiscountCode == "adel_1" || DiscountCode == "ad_10")
            {
                TotalPrice = TotalPrice * 0.8;
            }

            textBox11.Text = TotalPrice.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Thank you for using our services. " +
                "\nYour order has been confirmed." +
                "\nYou will receive a message with shipping details ");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
