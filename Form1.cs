namespace Basic_TicTacToe_program
{
    public partial class Form1 : Form
    {
        Boolean playersequence = true;
        byte moves=0;
        short score=0;  
        public Form1()
        {
            InitializeComponent();
        }

        

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn1.Text = "X";
            else
                btn1.Text = "O";
            btn1.Enabled = false;
            playersequence=! playersequence;
            moves++;
            winner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn2.Text = "X";
            else
                btn2.Text = "O";
            btn2.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn3.Text = "X";
            else
                btn3.Text = "O";
            btn3.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn4.Text = "X";
            else
                btn4.Text = "O";
            btn4.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn5.Text = "X";
            else
                btn5.Text = "O";
            btn5.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn6.Text = "X";
            else
                btn6.Text = "O";
            btn6.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn7.Text = "X";
            else
                btn7.Text = "O";
            btn7.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn8.Text = "X";
            else
                btn8.Text = "O";
            btn8.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn9.Text = "X";
            else
                btn9.Text = "O";
            btn9.Enabled = false;
            playersequence = !playersequence;
            moves++;
            winner();
        }
        
        void winner()
        {
            if((btn1.Text == "O" && btn2.Text=="O" && btn3.Text=="O")||  // Checking for winner horizontally
              (btn4.Text == "O" && btn5.Text== "O" && btn6.Text=="O")||
              (btn7.Text == "O" && btn8.Text == "O" && btn9.Text== "O" )||

              (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")|| // Checking for winner vertically 
              (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")||
              (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")||
              
              (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")|| // Checking for winner diagonally
              (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
            {
                MessageBox.Show("Player O is the Winner");

                score = short.Parse(lblScoreO.Text);
                lblScoreO.Text = (score+1).ToString();
                pnl1.Enabled = false;

            }
            else if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") ||  // Checking for winner horizontally
              (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") ||
              (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") ||

              (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") || // Checking for winner vertically 
              (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") ||
              (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") ||

              (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") || // Checking for winner diagonally 
              (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
            {
                MessageBox.Show("Player X is the Winner");
                score = short.Parse(lblScoreX.Text);
                lblScoreX.Text = (score + 1).ToString();
                pnl1.Enabled=false;

             
            }
            
            else if(moves==9)
            {
                MessageBox.Show("Draw");
                score = short.Parse(lblScoreDraw.Text);
                lblScoreDraw.Text = (score + 1).ToString();
                pnl1.Enabled = false;
             
            }
        }

        private void btnReset_Click(object sender, EventArgs e)  // to just reset the board and continue playing
        {
         
            moves = 0;
            pnl1.Enabled = true; // to enable the panel of tictactoe
            playersequence = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = ""; // to clear text
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.Enabled = true; // to enable the buttons again 
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            moves = 0;
            pnl1.Enabled = true; // to enable the panel of tictactoe
            playersequence = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = ""; // to clear text
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";


            lblScoreDraw.Text = "0"; // to reset scoreboard
            lblScoreO.Text = "0";
            lblScoreX.Text = "0";


            btn1.Enabled = true; // to enable the buttons again 
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
    }
}   