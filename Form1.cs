using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{ 
using System;
using System.Windows.Forms;


    public partial class Form1 : Form
    {
        private int randomNumber;
        private int attempts;
        private int score;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 100);
            attempts = 0;
            score = 0;
            UpdateAttemptsLabel();
            UpdateScoreLabel();
        }

        private void UpdateAttemptsLabel()
        {
            label1.Text = "Попытки: " + attempts;
        }

        private void UpdateScoreLabel()
        {
            label2.Text = "Счёт: " + score;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (attempts >= 1)
            {
                MessageBox.Show("У вас закончились попытки! Число было " + randomNumber);
                StartNewGame();
                return;
            }

            int guess;
            if (!int.TryParse(textBox1.Text, out guess))
            {
                MessageBox.Show("Неверный ввод.");
                return;
            }

            attempts++;
            UpdateAttemptsLabel();

            if (guess == randomNumber)
            {
                MessageBox.Show("Поздравляю ты угадал число.");
                score += 10 - attempts;
                UpdateScoreLabel();
                StartNewGame();
            }
            else if (guess < randomNumber)
            {
                MessageBox.Show("Число больше.");
            }
            else
            {
                MessageBox.Show("Число меньше.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
