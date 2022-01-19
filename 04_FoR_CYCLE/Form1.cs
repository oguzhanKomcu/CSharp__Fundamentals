namespace _04_FoR_CYCLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {

            //Let's find the factorial of the entered number.

            int multiply = 1;
            int sayi1 = Convert.ToInt32(textSayi1.Text);

            for (int i = 1; i <= sayi1; i++)
            {
                multiply = i * multiply;
               
                

            }

            MessageBox.Show($"Conclusion :{sayi1}! = {multiply}");

        }


        private void btExample3_Click(object sender, EventArgs e)
        {
            //Let's print the teams in the nba western conference.
            string[] nba_teams = {"Denver Nuggets", "Minnesota Timberwolves", "Oklahoma City Thunder", "Portland Trail Blazers", 
                                         "Utah Jazz", "Dallas Mavericks" , "Houston Rockets","Memphis Grizzlies","New Orleans Hornets","San Antonio Spurs",
                                     "Golden STATE Warriors","Los Angeles Clippers","Los Angeles Lakers","Phoneix Suns","Sacramento Kings"};

            for (int i = 0; i < nba_teams.Length; i++)
            {
                listBox1.Items.Add(nba_teams[i]);
            }

        }

        private void btnPrimeNumbers_Click(object sender, EventArgs e)
        {
            //Let's print the actual numbers up to 100 on the screen.

            int sayi = 100;
            int sayac;

            for (int i = 10; i < sayi; i++)
            {
                sayac = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    listBox1.Items.Add(i);
                }
            }




        }
    }
}