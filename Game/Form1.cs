using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int? lastNumber1 = null;
        int? lastNumber2 = null;
        int? lastNumber3 = null;
        int? lastNumber4 = null;
        int? lastNumber5 = null;
        int? lastNumber6 = null;
        int? lastNumber7 = null;
        int? lastNumber8 = null;
        int? lastNumber9 = null;
        int? lastNumber10 = null;
        int? lastNumber11 = null;
        int? lastNumber12 = null;
        int? lastNumber13 = null;
        int? lastNumber14 = null;
        int? lastNumber15 = null;
        int? lastNumber16 = null;

        List<Button> selectedButtons = new List<Button>();
        List<int> selectedNumbers = new List<int>();

        List<int> cards = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        Random random = new Random();

        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1, ref lastNumber1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2, ref lastNumber2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3, ref lastNumber3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button4, ref lastNumber4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button5, ref lastNumber5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button6, ref lastNumber6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button7, ref lastNumber7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button8, ref lastNumber8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button9, ref lastNumber9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button10, ref lastNumber10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button11, ref lastNumber11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button12, ref lastNumber12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button13, ref lastNumber13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button14, ref lastNumber14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button15, ref lastNumber15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button16, ref lastNumber16);
        }

        private void HandleButtonClick(Button button, ref int? lastNumber)
        {
            if (selectedButtons.Count == 2)
            {
                return;
            }

            if (selectedButtons.Contains(button))
            {
                return;
            }

            if (lastNumber != null)
            {
                button.Text = lastNumber.ToString();
                AddToSelected(button, lastNumber.Value);
                return;
            }

            if (cards.Count > 0)
            {
                int randomIndex = random.Next(cards.Count);
                int randomNumber = cards[randomIndex];
                button.Text = randomNumber.ToString();
                cards.RemoveAt(randomIndex);
                lastNumber = randomNumber;

                AddToSelected(button, randomNumber);
                if (!gameTimer.Enabled)
                {
                    gameTimer.Start();
                }
            }
        }

        private void AddToSelected(Button button, int number)
        {
            selectedButtons.Add(button);
            selectedNumbers.Add(number);

            if (selectedButtons.Count == 2)
            {
                CheckSelectedCards();
            }
        }
        private void CheckSelectedCards()
        {
            if (selectedNumbers[0] != selectedNumbers[1])
            {
                System.Windows.Forms.Timer clearTimer = new System.Windows.Forms.Timer { Interval = 1000 };
                clearTimer.Tick += (s, e) =>
                {
                    selectedButtons[0].Text = "";
                    selectedButtons[1].Text = "";
                    selectedButtons.Clear();
                    selectedNumbers.Clear();
                    clearTimer.Stop();
                };
                clearTimer.Start();
            }
            else
            {
                selectedButtons[0].Enabled = false;
                selectedButtons[1].Enabled = false;
                selectedButtons.Clear();
                selectedNumbers.Clear();
            }

            if (AllButtonsClicked())
            {
                gameTimer.Stop();
                label1.Text = "Kazandınız";
            }
        }

        private bool AllButtonsClicked()
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" &&
                   button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" &&
                   button9.Text != "" && button10.Text != "" && button11.Text != "" && button12.Text != "" &&
                   button13.Text != "" && button14.Text != "" && button15.Text != "" && button16.Text != "";
        }

        int dakika = 0;
        int saniye = 0;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            label3.Text = saniye.ToString("00");
            label4.Text = dakika.ToString("00");

            if (AllButtonsClicked())
            {
                gameTimer.Stop();
                label3.Text = saniye.ToString("00");
                label4.Text = dakika.ToString("00");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lastNumber1 = null;
            lastNumber2 = null;
            lastNumber3 = null;
            lastNumber4 = null;
            lastNumber5 = null;
            lastNumber6 = null;
            lastNumber7 = null;
            lastNumber8 = null;
            lastNumber9 = null;
            lastNumber10 = null;
            lastNumber11 = null;
            lastNumber12 = null;
            lastNumber13 = null;
            lastNumber14 = null;
            lastNumber15 = null;
            lastNumber16 = null;

            selectedButtons.Clear();
            selectedNumbers.Clear();

            cards = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";

            button1.Enabled = true; button2.Enabled=true; button3.Enabled=true;
            button4.Enabled=true; button5.Enabled=true;
            button6.Enabled=true; button7.Enabled=true;
            button8.Enabled=true; button9.Enabled=true;
            button10.Enabled=true; button11.Enabled=true;
            button12.Enabled=true; button13.Enabled=true;
            button14.Enabled=true; button15.Enabled=true;
            button16.Enabled=true;
            dakika = 0;
            saniye = 0;
            label3.Text = "00";
            label4.Text = "00";
            label1.Text = "";

            gameTimer.Stop();
        }
    }
}
