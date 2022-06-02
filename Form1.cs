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

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}