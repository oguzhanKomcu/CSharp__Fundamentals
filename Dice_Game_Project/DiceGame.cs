namespace Dice_Game_Project
{
    public partial class DiceGame : Form
    {
        public DiceGame()
        {
            InitializeComponent();
        }

        List<int> user1balance1 = new List<int>(1);


        bool user1balance()
        {
            user1balance1.Add(1000);

            return true;
        }
        bool newbalance()
        {
            int BetAmount = Convert.ToInt32(textBetAmount.Text);

            int totalbalance = user1balance1[0] - BetAmount;
            user1balance1[0] = totalbalance;
            return true;


        }
        bool newbalance2()
        {
            int BetAmount = Convert.ToInt32(textBetAmount.Text);
            user1balance1[0] = user1balance1[0] - BetAmount;
            int totalbalance = user1balance1[0] + (BetAmount * 2);
            user1balance1[0] = totalbalance;
            return true;
        }

        private void btnBarbut2_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int[] numbers1 = new int[1];
            int[] numbers2 = new int[1];


            bool resault = false;

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = random.Next(1, 6);


                for (int j = 0; j < numbers2.Length; j++)
                {
                    numbers2[i] = random.Next(1, 6);
                    break;
                }

            }


            int total = numbers1[0] + numbers2[0];

            if (textBetAmount.Text != "")
            {

                if (int.Parse(textBetAmount.Text) <= user1balance1[0])
                {
                    if (total <= 6)
                    {
                        labelResault.Text = $"{numbers1[0]} - {numbers2[0]} ";

                        MessageBox.Show("YOU LOSE !!");
                        newbalance();
                        labelBalance.Text = user1balance1[0].ToString();
                        textBetAmount.Clear();

                    }
                    else if (total > 6)
                    {
                        labelResault.Text = $"{numbers1[0]} - {numbers2[0]} ";
                        MessageBox.Show("YOU WINN !!!");
                        labelBalance.Text = "";
                        newbalance2();
                        labelBalance.Text = user1balance1[0].ToString();
                        textBetAmount.Clear();
                    }


                }
                else
                {
                    MessageBox.Show("Your balance is insufficient..!!!");
                    textBetAmount.Clear();
                }


            }
            else
            {
                MessageBox.Show("You have not entered the bet amount..!!!");
            }

            if (labelBalance.Text == "0")
            {
                MessageBox.Show("Your balance is over !\n You need to restart the game !");
            }

        }

        private void DiceGame_Load(object sender, EventArgs e)
        {
            user1balance();
            labelBalance.Text = user1balance1[0].ToString();
        }
    }
}
