using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameofcraps11
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            int dice1 = random.Next(1, 7); // Zar 1
            int dice2 = random.Next(1, 7); // Zar 2
            int total = dice1 + dice2;

            string result = "Zarlar: " + dice1.ToString() + " ve " + dice2.ToString() + "\n";

            if (total == 7 || total == 11)
            {
                result += "Kazandınız!";
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                result += "Kaybettiniz!";
            }
            else
            {
                int point = total;
                result += "Puana ulaştınız: " + point.ToString() + "\n";
                result += "Devam etmek için aynı puanı tekrar atın veya 7 atarak kaybedin.";

                while (true)
                {
                    dice1 = random.Next(1, 7);
                    dice2 = random.Next(1, 7);
                    int newTotal = dice1 + dice2;
                    result += "\nYeni zarlar: " + dice1.ToString() + " ve " + dice2.ToString();

                    if (newTotal == point)
                    {
                        result += "\nKazandınız!";
                        break;
                    }
                    else if (newTotal == 7)
                    {
                        result += "\nKaybettiniz!";
                        break;
                    }
                }
            }

            label1.Text = result;

        }
    }
}
