using System;
using System.Windows.Forms;

namespace ReloadingCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //test
        private void Button1_Click(object sender, EventArgs e)
        {
            string result;
            double powder = Convert.ToDouble(textBox3.Text)
                            / Convert.ToDouble(textBox8.Text)
                            * Convert.ToDouble(textBox6.Text);
            double fraction = Convert.ToDouble(textBox5.Text)
                              / 1000
                              * Convert.ToDouble(textBox7.Text);
            result = Convert.ToString(Convert.ToDouble(textBox1.Text)
                                      + Convert.ToDouble(textBox2.Text)
                                      + Convert.ToDouble(textBox4.Text)
                                      + powder
                                      + fraction);
            label1.Text = $"Стоимость патрона равна :{result}";
            result = Convert.ToString((Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox9.Text))
                                      + (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox10.Text))
                                      + (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox11.Text))
                                      + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox12.Text))
                                      + (Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox13.Text)));
            label11.Text = $"Потрачено :{result} рублей";
            result = Convert.ToString(Math.Truncate(Convert.ToDouble(textBox8.Text)
                                                    / Convert.ToDouble(textBox6.Text)
                                                    * Convert.ToDouble(textBox11.Text)));
            label13.Text = $"Получится :{result} патрона из пороха";
            result = Convert.ToString(Math.Truncate(Convert.ToDouble(textBox13.Text)
                                                    * 1000
                                                    / Convert.ToDouble(textBox7.Text)));
            label14.Text = $"Получится :{result} патрона из дроби"; ;
        }
    }
}
