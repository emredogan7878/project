using System;
using System.Windows.Forms;

namespace gameofcrapsbenim
{
    public partial class Form1 : Form
    {
        int secretNumber;
        int attemptsLeft = 10;
        int round = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı üretilir
            round = 0;
            attemptsLeft = 10;

            lblLives.Text = "Attempts Left: " + attemptsLeft;
            lblDisplay1.Visible = false;
            lblDisplay2.Visible = false;
            lblDisplay3.Visible = false;
            lblDisplay4.Visible = false;
            btnCheck.Enabled = true;
            txtBoxGirdi.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int guess;
            if (!int.TryParse(txtBoxGirdi.Text, out guess))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            round++;
            attemptsLeft--;

            if (guess == secretNumber)
            {
                lblDisplay4.Text = "Yes, Correct. You win at round " + round;
                lblDisplay4.Visible = true;
                lblDisplay1.Visible = false;
                lblDisplay2.Visible = false;
                lblDisplay3.Visible = false;
                btnCheck.Enabled = false;
            }
            else if (guess > secretNumber)
            {
                lblDisplay1.Visible = true;
                lblDisplay2.Visible = false; // Diğer label'ların görünürlüğünü kapat
                lblDisplay3.Visible = false;
                lblDisplay4.Visible = false;
            }
            else
            {
                lblDisplay2.Visible = true;
                lblDisplay1.Visible = false; // Diğer label'ların görünürlüğünü kapat
                lblDisplay3.Visible = false;
                lblDisplay4.Visible = false;
            }

            lblLives.Text = "Attempts Left: " + attemptsLeft;

            if (attemptsLeft == 0)
            {
                lblDisplay3.Visible = true;
                lblDisplay2.Visible = false;
                lblDisplay4.Visible = false;
                lblDisplay1.Visible = false;
                btnCheck.Enabled = false;
            }
        }
    }
}
