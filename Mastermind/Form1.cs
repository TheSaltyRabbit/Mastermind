using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Created by Christian Mascunana
   Goal was to make a game entirely using one form*/

namespace Mastermind
{
    public partial class Form1 : Form
    {
        //Initialize Variables
        public int guessColor1, guessColor2, guessColor3, guessColor4, maxColors, guessCounter, correctSpot, wrongSpot, wrongColor;
        public bool gameOver;
        public int[] CorrectAnswer = { 0, 0, 0, 0 };
        public int[] GuessChecker = { 0, 0, 0, 0 };
        public int[] PlayerGuess = { 0, 0, 0, 0 };

        //Sets buttons to cycle ROYGBV on left click and VBGYOR on right
        private void btnGuess2_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    guessColor2 = guessColor2 + 1;
                    break;

                case MouseButtons.Right:
                    guessColor2 = guessColor2 - 1;
                    break;
            }
            if (guessColor2 <= 0) guessColor2 = maxColors;
            if (guessColor2 > maxColors) guessColor2 = 1;
            ButtonColorUpdate();
        }

        private void btnGuess3_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    guessColor3 = guessColor3 + 1;
                    break;

                case MouseButtons.Right:
                    guessColor3 = guessColor3 - 1;
                    break;
            }
            if (guessColor3 <= 0) guessColor3 = maxColors;
            if (guessColor3 > maxColors) guessColor3 = 1;
            ButtonColorUpdate();
        }

        private void btnGuess4_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    guessColor4 = guessColor4 + 1;
                    break;

                case MouseButtons.Right:
                    guessColor4 = guessColor4 - 1;
                    break;
            }
            if (guessColor4 <= 0) guessColor4 = maxColors;
            if (guessColor4 > maxColors) guessColor4 = 1;
            ButtonColorUpdate();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            /* Red = 1
            orange = 2
            Yellow = 3
            Green = 4
            Blue = 5
            Purple = 6*/
            guessCounter++;
           //Submits guess to the answer key and moves all the rows up one
            if (guessCounter ==10)
            {
                btnR10C1.BackColor = btnR9C1.BackColor;
                btnR10C2.BackColor = btnR9C2.BackColor;
                btnR10C3.BackColor = btnR9C3.BackColor;
                btnR10C4.BackColor = btnR9C4.BackColor;
                btnR10C1.Visible = true;
                btnR10C2.Visible = true;
                btnR10C3.Visible = true;
                btnR10C4.Visible = true;
                label10.Text = label9.Text;
            }
            if (guessCounter >=9)
            {
                btnR9C1.BackColor = btnR8C1.BackColor;
                btnR9C2.BackColor = btnR8C2.BackColor;
                btnR9C3.BackColor = btnR8C3.BackColor;
                btnR9C4.BackColor = btnR8C4.BackColor;
                btnR9C1.Visible = true;
                btnR9C2.Visible = true;
                btnR9C3.Visible = true;
                btnR9C4.Visible = true;
                label9.Text = label8.Text;
            }
            if (guessCounter >=8)
            {
                btnR8C1.BackColor = btnR7C1.BackColor;
                btnR8C2.BackColor = btnR7C2.BackColor;
                btnR8C3.BackColor = btnR7C3.BackColor;
                btnR8C4.BackColor = btnR7C4.BackColor;
                btnR8C1.Visible = true;
                btnR8C2.Visible = true;
                btnR8C3.Visible = true;
                btnR8C4.Visible = true;
                label8.Text = label7.Text;
            }
            if (guessCounter >=7)
            {
                btnR7C1.BackColor = btnR6C1.BackColor;
                btnR7C2.BackColor = btnR6C2.BackColor;
                btnR7C3.BackColor = btnR6C3.BackColor;
                btnR7C4.BackColor = btnR6C4.BackColor;
                btnR7C1.Visible = true;
                btnR7C2.Visible = true;
                btnR7C3.Visible = true;
                btnR7C4.Visible = true;
                label7.Text = label6.Text;
            }
            if (guessCounter >=6)
            {
                btnR6C1.BackColor = btnR5C1.BackColor;
                btnR6C2.BackColor = btnR5C2.BackColor;
                btnR6C3.BackColor = btnR5C3.BackColor;
                btnR6C4.BackColor = btnR5C4.BackColor;
                btnR6C1.Visible = true;
                btnR6C2.Visible = true;
                btnR6C3.Visible = true;
                btnR6C4.Visible = true;
                label6.Text = label5.Text;
            }
            if (guessCounter >=5)
            {
                btnR5C1.BackColor = btnR4C1.BackColor;
                btnR5C2.BackColor = btnR4C2.BackColor;
                btnR5C3.BackColor = btnR4C3.BackColor;
                btnR5C4.BackColor = btnR4C4.BackColor;
                btnR5C1.Visible = true;
                btnR5C2.Visible = true;
                btnR5C3.Visible = true;
                btnR5C4.Visible = true;
                label5.Text = label4.Text;
            }
            if (guessCounter >=4)
            {
                btnR4C1.BackColor = btnR3C1.BackColor;
                btnR4C2.BackColor = btnR3C2.BackColor;
                btnR4C3.BackColor = btnR3C3.BackColor;
                btnR4C4.BackColor = btnR3C4.BackColor;
                btnR4C1.Visible = true;
                btnR4C2.Visible = true;
                btnR4C3.Visible = true;
                btnR4C4.Visible = true;
                label4.Text = label3.Text;
            }
            if (guessCounter >=3)
            {
                btnR3C1.BackColor = btnR2C1.BackColor;
                btnR3C2.BackColor = btnR2C2.BackColor;
                btnR3C3.BackColor = btnR2C3.BackColor;
                btnR3C4.BackColor = btnR2C4.BackColor;
                btnR3C1.Visible = true;
                btnR3C2.Visible = true;
                btnR3C3.Visible = true;
                btnR3C4.Visible = true;
                label3.Text = label2.Text;
            }
            if (guessCounter >=2)
            {
                btnR2C1.BackColor = btnR1C1.BackColor;
                btnR2C2.BackColor = btnR1C2.BackColor;
                btnR2C3.BackColor = btnR1C3.BackColor;
                btnR2C4.BackColor = btnR1C4.BackColor;
                btnR2C1.Visible = true;
                btnR2C2.Visible = true;
                btnR2C3.Visible = true;
                btnR2C4.Visible = true;
                label2.Text = label1.Text;
            }
            if (guessCounter >=1)
            {
                btnR1C1.BackColor = btnGuess1.BackColor;
                btnR1C2.BackColor = btnGuess2.BackColor;
                btnR1C3.BackColor = btnGuess3.BackColor;
                btnR1C4.BackColor = btnGuess4.BackColor;
                btnGuess1.BackColor = SystemColors.Control;
                btnGuess2.BackColor = SystemColors.Control;
                btnGuess3.BackColor = SystemColors.Control;
                btnGuess4.BackColor = SystemColors.Control;
                btnR1C1.Visible = true;
                btnR1C2.Visible = true;
                btnR1C3.Visible = true;
                btnR1C4.Visible = true;
            }
            CheckAnswer();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            bool isEqual = Enumerable.SequenceEqual(PlayerGuess, GuessChecker);
            if (isEqual)
            {
                Reset();
            }
            else if (guessCounter == 10)
            {
                Reset();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart", "Restart?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                }
            }
        }

        private void Reset()
        {//Reset all variables, buttons, images//
            gameOver = false;

            btnR1C1.Visible = false;
            btnR1C2.Visible = false;
            btnR1C3.Visible = false;
            btnR1C4.Visible = false;

            btnR2C1.Visible = false;
            btnR2C2.Visible = false;
            btnR2C3.Visible = false;
            btnR2C4.Visible = false;

            btnR3C1.Visible = false;
            btnR3C2.Visible = false;
            btnR3C3.Visible = false;
            btnR3C4.Visible = false;

            btnR4C1.Visible = false;
            btnR4C2.Visible = false;
            btnR4C3.Visible = false;
            btnR4C4.Visible = false;

            btnR5C1.Visible = false;
            btnR5C2.Visible = false;
            btnR5C3.Visible = false;
            btnR5C4.Visible = false;

            btnR6C1.Visible = false;
            btnR6C2.Visible = false;
            btnR6C3.Visible = false;
            btnR6C4.Visible = false;

            btnR7C1.Visible = false;
            btnR7C2.Visible = false;
            btnR7C3.Visible = false;
            btnR7C4.Visible = false;

            btnR8C1.Visible = false;
            btnR8C2.Visible = false;
            btnR8C3.Visible = false;
            btnR8C4.Visible = false;

            btnR9C1.Visible = false;
            btnR9C2.Visible = false;
            btnR9C3.Visible = false;
            btnR9C4.Visible = false;

            btnR10C1.Visible = false;
            btnR10C2.Visible = false;
            btnR10C3.Visible = false;
            btnR10C4.Visible = false;

            groupBox1.Visible = true;

            btnGuess1.BackColor = SystemColors.Control;
            btnGuess2.BackColor = SystemColors.Control;
            btnGuess3.BackColor = SystemColors.Control;
            btnGuess4.BackColor = SystemColors.Control;

            btnAns1.Visible = false;
            btnAns2.Visible = false;
            btnAns3.Visible = false;
            btnAns4.Visible = false;

            guessCounter = 0;

            label11.Text = "";
            label12.Text = "";

            btnGuess1.Visible = false;
            btnGuess2.Visible = false;
            btnGuess3.Visible = false;
            btnGuess4.Visible = false;

            PlayerGuess[0] = 0;
            PlayerGuess[1] = 0;
            PlayerGuess[2] = 0;
            PlayerGuess[3] = 0;

            guessColor1 = 0;
            guessColor2 = 0;
            guessColor3 = 0;
            guessColor4 = 0;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckAnswer()
        {
            //reset the variables so nothing gets carried over//
            label1.Text = "";
            correctSpot = 0;
            wrongColor = 0;
            wrongSpot = 0;
            //Cement the guesses//
            GuessChecker[0] = CorrectAnswer[0];
            GuessChecker[1] = CorrectAnswer[1];
            GuessChecker[2] = CorrectAnswer[2];
            GuessChecker[3] = CorrectAnswer[3];

            PlayerGuess[0] = guessColor1;
            PlayerGuess[1] = guessColor2;
            PlayerGuess[2] = guessColor3;
            PlayerGuess[3] = guessColor4;

            bool isEqual = Enumerable.SequenceEqual(PlayerGuess, GuessChecker); //if you get it right//
            if (isEqual)
            {
                MessageBox.Show("You WIN!");
                btnSubmit.Visible = false;
                ShowAnswer();
                label11.Text = "The correct answer was";
                gameOver = true;
            }
            else if (guessCounter == 10) //if y
            {
                MessageBox.Show("You Lose!");
                btnSubmit.Visible = false;
                label11.Text = "The correct answer was";
                ShowAnswer();
                gameOver = true;
            }
            else
            {
                if (guessColor1 == GuessChecker[0])
                {
                    correctSpot++;
                    GuessChecker[0] = 0;
                    guessColor1 = 0;
                }
                if (guessColor2 == GuessChecker[1])
                {
                    correctSpot++;
                    GuessChecker[1] = 0;
                    guessColor2 = 0;
                }
                if (guessColor3 == GuessChecker[2])
                {
                    correctSpot++;
                    GuessChecker[2] = 0;
                    guessColor3 = 0;
                }
                if (guessColor4 == GuessChecker[3])
                {
                    correctSpot++;
                    GuessChecker[3] = 0;
                    guessColor4 = 0;
                }
                if (GuessChecker[0] != 0)
                {
                    if (GuessChecker[0] == guessColor2)
                    {
                        wrongSpot++;
                        GuessChecker[0] = 0;
                        guessColor2 = 0;
                    }
                    else if (GuessChecker[0] == guessColor3)
                    {
                        wrongSpot++;
                        GuessChecker[0] = 0;
                        guessColor3 = 0;
                    }
                    else if (GuessChecker[0] == guessColor4)
                    {
                        wrongSpot++;
                        GuessChecker[0] = 0;
                        guessColor4 = 0;
                    }
                    else
                    {
                        wrongColor++;
                        GuessChecker[0] = 0;
                    }
                }
                if (GuessChecker[1] != 0)
                {
                    if (GuessChecker[1] == guessColor1)
                    {
                        wrongSpot++;
                        GuessChecker[1] = 0;
                        guessColor1 = 0;
                    }
                    else if (GuessChecker[1] == guessColor3)
                    {
                        wrongSpot++;
                        GuessChecker[1] = 0;
                        guessColor3 = 0;
                    }
                    else if (GuessChecker[1] == guessColor4)
                    {
                        wrongSpot++;
                        GuessChecker[1] = 0;
                        guessColor4 = 0;
                    }
                    else
                    {
                        wrongColor++;
                        GuessChecker[1] = 0;
                    }
                }
                if (GuessChecker[2] != 0)
                {
                    if (GuessChecker[2] == guessColor1)
                    {
                        wrongSpot++;
                        GuessChecker[2] = 0;
                        guessColor1 = 0;
                    }
                    else if (GuessChecker[2] == guessColor2)
                    {
                        wrongSpot++;
                        GuessChecker[2] = 0;
                        guessColor2 = 0;
                    }
                    else if (GuessChecker[2] == guessColor4)
                    {
                        wrongSpot++;
                        GuessChecker[2] = 0;
                        guessColor4 = 0;
                    }
                    else
                    {
                        wrongColor++;
                        GuessChecker[0] = 0;
                    }
                }
                if (GuessChecker[3] != 0)
                {
                    if (GuessChecker[3] == guessColor1)
                    {
                        wrongSpot++;
                        GuessChecker[3] = 0;
                        guessColor1 = 0;
                    }
                    else if (GuessChecker[3] == guessColor2)
                    {
                        wrongSpot++;
                        GuessChecker[2] = 0;
                        guessColor2 = 0;
                    }
                    else if (GuessChecker[3] == guessColor3)
                    {
                        wrongSpot++;
                        GuessChecker[3] = 0;
                        guessColor3 = 0;
                    }
                    else
                    {
                        wrongColor++;
                        GuessChecker[3] = 0;
                    }
                }
            }
            if (correctSpot != 0)
            {
                label1.Text = correctSpot + " Correct ";
            }
            if (wrongSpot != 0)
            {
                label1.Text = label1.Text + wrongSpot + " in wrong spot ";
            }
            if (wrongColor !=0)
            {
                label1.Text = label1.Text + wrongColor + " incorrect";
            }
            guessColor1 = 0;
            guessColor2 = 0;
            guessColor3 = 0;
            guessColor4 = 0;
        }

        private void btnGuess1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    guessColor1 = guessColor1 + 1;
                    break;

                case MouseButtons.Right:
                    guessColor1 = guessColor1 - 1;
                    break;
            }
            if (guessColor1 <= 0) guessColor1 = maxColors;
            if (guessColor1 > maxColors) guessColor1 = 1;
            ButtonColorUpdate();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            Random randomnumber = new Random();
            
            if (radioButton2.Checked==true)
            {
                maxColors = 4;
            }
            else if (radioButton3.Checked==true)
            {
                maxColors = 5;
            }
            else if (radioButton4.Checked==true)
            {
                maxColors = 6;
            }
            CorrectAnswer[0] = randomnumber.Next(1, maxColors + 1);
            CorrectAnswer[1] = randomnumber.Next(1, maxColors + 1);
            CorrectAnswer[2] = randomnumber.Next(1, maxColors + 1);
            CorrectAnswer[3] = randomnumber.Next(1, maxColors + 1);
            groupBox1.Visible = false;
            btnGuess1.Visible = true;
            btnGuess2.Visible = true;
            btnGuess3.Visible = true;
            btnGuess4.Visible = true;
            btnSubmit.Visible = true;
            label12.Text = "Current Guess";
        }

        private void ShowAnswer()
        {
            switch (CorrectAnswer[0])
            {
                case 1:
                    btnAns1.BackColor = Color.Red;
                    break;
                case 2:
                    btnAns1.BackColor = Color.Orange;
                    break;
                case 3:
                    btnAns1.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnAns1.BackColor = Color.Green;
                    break;
                case 5:
                    btnAns1.BackColor = Color.Blue;
                    break;
                case 6:
                    btnAns1.BackColor = Color.Purple;
                    break;
            }
            switch (CorrectAnswer[1])
            {
                case 1:
                    btnAns2.BackColor = Color.Red;
                    break;
                case 2:
                    btnAns2.BackColor = Color.Orange;
                    break;
                case 3:
                    btnAns2.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnAns2.BackColor = Color.Green;
                    break;
                case 5:
                    btnAns2.BackColor = Color.Blue;
                    break;
                case 6:
                    btnAns2.BackColor = Color.Purple;
                    break;
            }
            switch (CorrectAnswer[2])
            {
                case 1:
                    btnAns3.BackColor = Color.Red;
                    break;
                case 2:
                    btnAns3.BackColor = Color.Orange;
                    break;
                case 3:
                    btnAns3.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnAns3.BackColor = Color.Green;
                    break;
                case 5:
                    btnAns3.BackColor = Color.Blue;
                    break;
                case 6:
                    btnAns3.BackColor = Color.Purple;
                    break;
            }
            switch (CorrectAnswer[3])
            {
                case 1:
                    btnAns4.BackColor = Color.Red;
                    break;
                case 2:
                    btnAns4.BackColor = Color.Orange;
                    break;
                case 3:
                    btnAns4.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnAns4.BackColor = Color.Green;
                    break;
                case 5:
                    btnAns4.BackColor = Color.Blue;
                    break;
                case 6:
                    btnAns4.BackColor = Color.Purple;
                    break;
            }
            btnAns1.Visible = true;
            btnAns2.Visible = true;
            btnAns3.Visible = true;
            btnAns4.Visible = true;
        }

        private void ButtonColorUpdate()
        {
            switch (guessColor1)
            {
                case 1:
                    btnGuess1.BackColor = Color.Red;
                    break;
                case 2:
                    btnGuess1.BackColor = Color.Orange;
                    break;
                case 3:
                    btnGuess1.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnGuess1.BackColor = Color.Green;
                    break;
                case 5:
                    btnGuess1.BackColor = Color.Blue;
                    break;
                case 6:
                    btnGuess1.BackColor = Color.Purple;
                    break;
            }
            switch (guessColor2)
            {
                case 1:
                    btnGuess2.BackColor = Color.Red;
                    break;
                case 2:
                    btnGuess2.BackColor = Color.Orange;
                    break;
                case 3:
                    btnGuess2.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnGuess2.BackColor = Color.Green;
                    break;
                case 5:
                    btnGuess2.BackColor = Color.Blue;
                    break;
                case 6:
                    btnGuess2.BackColor = Color.Purple;
                    break;
            }
            switch (guessColor3)
            {
                case 1:
                    btnGuess3.BackColor = Color.Red;
                    break;
                case 2:
                    btnGuess3.BackColor = Color.Orange;
                    break;
                case 3:
                    btnGuess3.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnGuess3.BackColor = Color.Green;
                    break;
                case 5:
                    btnGuess3.BackColor = Color.Blue;
                    break;
                case 6:
                    btnGuess3.BackColor = Color.Purple;
                    break;
            }
            switch (guessColor4)
            {
                case 1:
                    btnGuess4.BackColor = Color.Red;
                    break;
                case 2:
                    btnGuess4.BackColor = Color.Orange;
                    break;
                case 3:
                    btnGuess4.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnGuess4.BackColor = Color.Green;
                    break;
                case 5:
                    btnGuess4.BackColor = Color.Blue;
                    break;
                case 6:
                    btnGuess4.BackColor = Color.Purple;
                    break;
            }
        }
    }
}
