using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace First
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
            gameField.Text = "0";
        }
        
        private void MoreBtn_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var newCard = rnd.Next(0, 11);
            var deck = int.Parse(gameField.Text.ToString()) + newCard;
            gameField.Text = deck.ToString();        
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            var finalDeck = int.Parse(gameField.Text.ToString());
            var computerDeck = computerDeckFinal();
            if ((finalDeck < 22) && (finalDeck > computerDeck))
            {
                gameField.Text = "Yo" + computerDeck.ToString();
            }
            else if ( finalDeck > 21)
            {
                gameField.Text = "You Lose";
            }
        }

        private int computerDeckFinal()
        {
            var startComputerDeck = 0;
            var rnd = new Random();
            startComputerDeck = rnd.Next(1, 12) + rnd.Next(1, 12);
            if (startComputerDeck < 13 )
            {
                startComputerDeck += rnd.Next(1, 12);
            }

            return startComputerDeck;
        }
        
    }
}
