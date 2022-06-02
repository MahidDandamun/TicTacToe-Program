namespace Basic_TicTacToe_program
{
    public partial class Form1 : Form
    {
        Boolean playersequence = true;
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
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn2.Text = "X";
            else
                btn2.Text = "O";
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn3.Text = "X";
            else
                btn3.Text = "O";
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn4.Text = "X";
            else
                btn4.Text = "O";
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn5.Text = "X";
            else
                btn5.Text = "O";
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn6.Text = "X";
            else
                btn6.Text = "O";
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn7.Text = "X";
            else
                btn7.Text = "O";
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn8.Text = "X";
            else
                btn8.Text = "O";
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (playersequence)
                btn9.Text = "X";
            else
                btn9.Text = "O";
            btn1.Enabled = false;
        }
    }
}