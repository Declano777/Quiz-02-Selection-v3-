namespace Quiz_02_Selection_v3_
{
    public partial class Form1 : Form
    {
        string q1correct = "Carney";
        string q2correct = "Yes";
        string q2Incorect = "No";
        int q4age = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is a chance that when you are using if statments thta multiple if statments can overlap and caus isues. this is solved with els if");



        }

        private void q1Button_Click(object sender, EventArgs e)
        {

            if (q1TextBox.Text == q1correct)
            {
                q1OutputLabel.Text = "corect";

            }
            else
            {
                q1OutputLabel.Text = "incorect";
            }

        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            if (q2TextBox.Text == q2correct)
            {
                q2OutputLabel.Text = "GO lEAFS";

            }
            else if (q2TextBox.Text == q2Incorect)
            {
                q2OutputLabel.Text = "BOOOOOOOOO";
            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            if (q3TextBox.Text == "9>")
            {

                q3OutputLabel.Text = "Elementery";
            }
            else if (q3TextBox.Text == "9")
            {

                q3OutputLabel.Text = "Freshmen";
            }
            else if (q3TextBox.Text == "10")
            {

                q3OutputLabel.Text = "Softmore";
            }
            else if (q3TextBox.Text == "11")
            {

                q3OutputLabel.Text = "Junior";
            }
            else if (q3TextBox.Text == "12")
            {

                q3OutputLabel.Text = "Sineor";
            }
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            q4age = Convert.ToInt32(ageTextBox.Text);

            if (q4age >= 13)
            {
                q4OutputLabel.Text = "You can watch";
 
            }
            else if (parentTextBox.Text == "yes" && timeTextBox.Text == "yes")
            {
                q4OutputLabel.Text = "You can watch";


            }
            else
            {
                q4OutputLabel.Text = "You cant watch";
            }

        }
    }
}
