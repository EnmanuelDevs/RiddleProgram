namespace RiddleProgram
{
    public partial class Form1 : Form
    {
        private int numberAleatory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumMin.Text, out int minNumber) ||
                !int.TryParse(txtNumMax.Text, out int maxNumber) ||
                minNumber >= maxNumber)
            {
                MessageBox.Show("Please, Enter Valid Integers");
                return;
            }


            Random random = new Random();
            numberAleatory = random.Next(minNumber, maxNumber + 1);

            txtRiddle.Text = "";
            btnVerify.Enabled = true;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRiddle.Text, out int riddleNumber))
            {
                MessageBox.Show("Please, Enter a Valid Integer");
                return;
            }

            while (true)
            {
                if (riddleNumber == numberAleatory)
                {
                    MessageBox.Show("Congratulations, You guessed the number");
                    break;
                }

                else if (riddleNumber < numberAleatory)
                {
                    MessageBox.Show("The number is greater");
                }
                else
                {
                    MessageBox.Show("The number is less");
                }


                riddleNumber = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter another Number"));
            }
        }
    }
}
