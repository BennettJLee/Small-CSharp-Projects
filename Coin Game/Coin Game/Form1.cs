using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal Balance = 20;
        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxBalance.Text = Balance.ToString("c");
        }
       
        /// <summary>
        /// This click event method will generate 2 coin flips and decide whether the user has won or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTossCoins_Click(object sender, EventArgs e)
        {

            //variables
            decimal BettingAmount = 0;
            int Coin1;
            int Coin2;

            //generates coin flip between 1 and 2 (1 being tails and 2 being heads)
            Random rng = new Random();
            Coin1 = rng.Next(1, 3);
            Coin2 = rng.Next(1, 3);

            try
            {
                //amount user wants to bet
                BettingAmount = decimal.Parse(textBoxBetting.Text);

                if (BettingAmount <= Balance)
                {
                    //creates CoinTotal
                    int CoinTotal = Coin1 + Coin2;
                    if (radioButtonHeads.Checked == true)
                    {
                        if (CoinTotal == 4) //Both heads
                        {
                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_H;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_H;
                            textBoxResults.Text = "H,H";
                            MessageBox.Show("You Win! You're balance has been updated");
                            //Update Balance
                            Balance = Balance + BettingAmount * 2;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }

                        else if (CoinTotal == 2) //Both Tails
                        {
                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_T;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_T;
                            textBoxResults.Text = "T,T";
                            MessageBox.Show("You Lose! You're balance has been updated");
                            //Update Balance
                            Balance = Balance - BettingAmount;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }

                        else //Both different
                        {
                            

                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_H;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_T;
                            textBoxResults.Text = "H,T";
                            MessageBox.Show("You Lose! You're balance has been updated");
                            //Update Balance
                            Balance = Balance - BettingAmount;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }
                    }
                    else if (radioButtonTails.Checked == true)
                    {
                        if (CoinTotal == 4) //Both Heads
                        {
                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_H;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_H;
                            textBoxResults.Text = "H,H";
                            MessageBox.Show("You Lose! You're balance has been updated");
                            //Update Balance
                            Balance = Balance - BettingAmount;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }
                        else if (CoinTotal == 2) //Both tails
                        {
                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_T;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_T;
                            textBoxResults.Text = "T,T";
                            MessageBox.Show("You Win! You're balance has been updated");
                            //Update Balance
                            Balance = Balance + BettingAmount * 2;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }

                        else //Both different
                        {
                            //Display results
                            pictureBoxHeads.Image = Properties.Resources.Bit_Coin_H;
                            pictureBoxTails.Image = Properties.Resources.Bit_Coin_T;
                            textBoxResults.Text = "H,T";
                            MessageBox.Show("You Lose! You're balance has been updated"); 
                            //Update Balance
                            Balance = Balance - BettingAmount;
                            textBoxBalance.Text = Balance.ToString("c");
                            //clear textBoxes and set focus
                            textBoxBetting.Clear();
                            textBoxBetting.Focus();
                        }
                    }
                    else
                    {
                        //Display serror message
                        MessageBox.Show("Oh No! looks like you don't have enough money");
                        //clear textBoxes
                        textBoxBetting.Clear();
                        textBoxResults.Clear();
                        //set focus
                        textBoxBetting.Focus();
                    }
                }
                else
                {
                    //Display serror message
                    MessageBox.Show("Oh No! looks like you don't have enough money");
                    //clear textBoxes
                    textBoxBetting.Clear();
                    textBoxResults.Clear();
                    //set focus
                    textBoxBetting.Focus();
                }
            }

            catch
            {
                //Display serror message
                MessageBox.Show("Please enter a numeric value");
                //clear textBoxes
                textBoxBetting.Clear();
                textBoxResults.Clear();
                //set focus
                textBoxBetting.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
