using System.Data.SqlTypes;

namespace CS311_Project2_BSJ
{
    public partial class frmCraps : Form
    {
        double money;
        double bet = 0;
        String gameState;
        int pointHolder;
        double betHolder;
        public frmCraps()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            money = 100;
            gameState = "Default";
            lblRoll1.Text = "";
            lblRoll2.Text = "";
            lblOutcome.Text = "";
            lblBal.Text = String.Format("{0:C}", money);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate_score();
        }

        private void calculate_score()
        {
            bet = Convert.ToDouble(txtBet.Text);
            if (money - bet < 0)
            {
                lblOutcome.Text = "Not Enough Money!";
                return;
            }
            //turns input text into bet value
            //exits method if bet value is greater than remaining balance
            Random rand = new Random();
            int r1, r2;
            r1 = rand.Next(6) + 1;
            r2 = rand.Next(6) + 1;
            int total = r1 + r2;
            //roll 2 random dice, then calculate total of the rolls

            lblRoll1.Text = r1.ToString();
            lblRoll2.Text = r2.ToString();
            //update the rolled value of the dice into the proper labels
            switch (gameState)
            {
                case "Point":
                    bet = betHolder;
                    //keeps the original bet value
                    if (total == pointHolder)
                    {
                        win();
                    }
                    else if (total == 7)
                    {
                        lose();
                    }
                    else
                    {
                        pnt(pointHolder, betHolder);
                    }
                    break;
                case "Default":
                    switch (total)
                    {
                        case 2: lose(); break;
                        case 3: lose(); break;
                        case 12: lose(); break;
                        case 7: win(); break;
                        case 11: win(); break;
                        default: pnt(total, bet); break;
                    }
                    //switch case to define the game state following the roll
                    break;
                    //overall switch case to decide what to do after the dice are rolled
            }

        }

        //one of the default gamestates
        //increases current balance by bet amount
        //sets outcome textbox appropriately
        public void win()
        {
            money += bet;
            lblOutcome.Text = "You Win!";
            reset();
        }

        //one of the default gamestates
        //reduces current balance by bet amount
        //sets outcome textbox appropriately
        public void lose()
        {
            money -= bet;
            lblOutcome.Text = "You Lose!";
            reset();
        }

        //player is in point gameState
        //keeps original bet and 'point'
        public void pnt(int t, double b)
        {
            lblOutcome.Text = "Point is " + t;
            pointHolder = t;
            betHolder = b;
            gameState = "Point";
        }

        //updates money, resets bet textbox, and sets gameState to Default
        public void reset()
        {
            lblBal.Text = String.Format("{0:C}", money);
            txtBet.Text = "enter your bet";
            gameState = "Default";
        }
    }
}