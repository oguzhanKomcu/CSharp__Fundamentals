namespace VOID_METHODS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //VOID METHODS

        void SpeedFormula(int path, int time)
        {
            int speed = path / time;
            MessageBox.Show($"Your Speed : {speed} km/s");
        }

        //CONTROLA
        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            SpeedFormula(int.Parse(textPath.Text), int.Parse(textTime.Text));
        }

        //OVERLOAD METHODS


        void Membership(DateTime startingdate, DateTime end_date)
        {

            if (startingdate == end_date)
            {
                MessageBox.Show("The dates should not be the same.");

            }
            else
            {

                TimeSpan membershipdays = end_date.Subtract(startingdate);
                MessageBox.Show($"{textFullName.Text} Welcome\nTotal subscription time : {membershipdays.Days} days");
            }



        }
        void Membership(DateTime startingdate, DateTime end_date, DateTime nowdate)
        {

            TimeSpan membershipdays = end_date.Subtract(startingdate);
            TimeSpan remaining_time = nowdate.Subtract(startingdate);

            MessageBox.Show($"{textFullName.Text} Welcome\nTotal subscription time : {membershipdays.Days} days\nRemaining day = {remaining_time.Days}");


        }
        //CONTROLA
        private void btnCalculate2_Click(object sender, EventArgs e)
        {

            Membership(DateTime.Parse(textStartingdate.Text), DateTime.Parse(textEndDATE.Text), DateTime.Parse(textNowDate.Text));
        }



        //USING OUT IN METHODS

        void DiscountAccount(double oldprice, double newprice, out double discountamount, out double percent)
        {
            discountamount = oldprice - newprice;
            percent = (discountamount / oldprice) * 100;

        }


        private void btnCalculate3_Click(object sender, EventArgs e)
        {
            double discountamount;
            double percent;
            DiscountAccount(double.Parse(textOldprice.Text), double.Parse(textNewprice.Text), out discountamount, out percent);

            MessageBox.Show($"Discount difference to the product:  {(Math.Round(discountamount, 2))} TL\nPercentage of discount on the product:  {(Math.Round(percent))} %");
        }
    }
}
