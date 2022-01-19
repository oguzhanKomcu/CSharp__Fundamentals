namespace ForeacH_Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int>   numbers = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            numbers.Add(186);
            numbers.Add(24);
            numbers.Add(32);
            numbers.Add(245);
            numbers.Add(96);
            numbers.Add(1907);
            numbers.Add(1881);
        }

        private void btnNewNumber_Click_1(object sender, EventArgs e)
        {
            //Let's add a new number to the numbers in the list we created earlier and add them.//

            int newnumber = Convert.ToInt32(textNewNumber.Text);
            numbers.Add(newnumber);
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
                

            }
            MessageBox.Show($"The sum of the numbers in the list before the new number is entered: {(total - newnumber)}" +
                $"\nThe sum of the numbers in the list with the newly entered number : {total}");


        }

        private void Examples1_Click(object sender, EventArgs e)
        {
            //Let's sort the teams in the nba east conference A-Z and print them in the listbox.//


            string[] NbaEasternConference = {"Chicago Bulls", "Miami Heat", "Brooklyn Heat", "Cleveland Cavaliers","Milwaukee Bucks", "Philadelphia 76ers","Charlotte Hornets",
                                               "Washington Wizards","Toronto Raaptors","Boston Celtics","New York Knicks","Atalanta Hawks",
                                                         "Indiana Pacers","Detroit Pistons","Orlando Magic"};


            Array.Sort(NbaEasternConference);

            foreach (string teams in NbaEasternConference)
            {
                
                listBox1.Items.Add(teams);
            }
           

        }

        private void Examples2_Click(object sender, EventArgs e)
        {
            //Let's sort the teams in the nba east conference Z-A and print them in the listbox.//

            string[] NbaEasternConference = {"Chicago Bulls", "Miami Heat", "Brooklyn Heat", "Cleveland Cavaliers","Milwaukee Bucks", 
                                                                 "Philadelphia 76ers","Charlotte Hornets",
                                               "Washington Wizards","Toronto Raaptors","Boston Celtics","New York Knicks","Atalanta Hawks",
                                                         "Indiana Pacers","Detroit Pistons","Orlando Magic"};


            Array.Reverse(NbaEasternConference);

            foreach (string teams in NbaEasternConference)
            {

                listBox1.Items.Add(teams);
            }
        }

        private void Examples3_Click(object sender, EventArgs e)
        {
            //Querying the end-of-term student status document according to the grades in the given list.

            int[] points = { 86, 75, 90, 100, 80, 64, 50, 92, 100, 87 };
            int average = 0;
            int total = 0;
            foreach (int point in points)
            {
                listBox1.Items.Add(point);
                total = point + total;
                average = total / points.Length;
            }

            
             if(average >= 85 )
             {
                listBox1.Items.Add($"Not Ortalamanýz: {average}");
                listBox1.Items.Add($" Takdir belgesi almaya hak kazandýnýz."); 
             }
             else if (average >= 70 && average < 85  )
             {
                listBox1.Items.Add($"Not Ortalamanýz: {average}");
                listBox1.Items.Add($"Teþekkür belgesi almaya hak kazandýnýz.");
            }
             else
             {
                listBox1.Items.Add($"Not Ortalamanýz: {average}");
                listBox1.Items.Add($"Üzgünüm.Belge hakký kazanamadýnýz.");
            }



        }
    }
}