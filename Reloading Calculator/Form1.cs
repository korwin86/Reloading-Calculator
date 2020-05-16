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
        

        //порох
        double powder;
        //дробь
        double shot;
        //капсюль
        //пыж-контейнер
        //гильза
        //стоимость патрона
        string sumCartridge;
        //количество потраченных денег
        string sumMoney;
        //количество патронов из пороха
        string sumCartridgeInPowder;
        //количество патронов из дроби
        string sumCartridgeInShot;

        private void Button1_Click(object sender, EventArgs e)
        {

            powder = Cost(textBox3.Text, textBox8.Text, textBox6.Text);
            shot = Cost(textBox5.Text, Convert.ToString(1000), textBox7.Text);
            sumCartridge = Convert.ToString(Convert.ToDouble(textBox1.Text)
                                      + Convert.ToDouble(textBox2.Text)
                                      + Convert.ToDouble(textBox4.Text)
                                      + powder
                                      + shot);
            label1.Text = $"Стоимость патрона равна :{sumCartridge}";
            sumMoney = Convert.ToString((Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox9.Text))
                                      + (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox10.Text))
                                      + (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox11.Text))
                                      + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox12.Text))
                                      + (Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox13.Text)));
            label11.Text = $"Потрачено :{sumMoney} рублей";
            sumCartridgeInPowder = Convert.ToString(Math.Truncate(Convert.ToDouble(textBox8.Text)
                                                    / Convert.ToDouble(textBox6.Text)
                                                    * Convert.ToDouble(textBox11.Text)));
            label13.Text = $"Получится :{sumCartridgeInPowder} патрона из пороха";
            sumCartridgeInShot = Convert.ToString(Math.Truncate(Convert.ToDouble(textBox13.Text)
                                                    * 1000
                                                    / Convert.ToDouble(textBox7.Text)));
            label14.Text = $"Получится :{sumCartridgeInShot} патрона из дроби"; ;
        }

        double Cost(string i, string ii, string iii)

        {
            double result = Convert.ToDouble(i) / Convert.ToDouble(ii) * Convert.ToDouble(iii);
            return result;
        }

    }
}
