namespace _02_iF_ELse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            double your_balance = Convert.ToDouble(textYour_Balance.Text);
            double number_of_goes = Convert.ToDouble(textNumber_Of_Goes.Text);
            double student_fee = 2.67;

            if (your_balance >= 2.67)
            {
                if (number_of_goes == 1)
                {
                    double available_balance = your_balance - student_fee;
                    double balance = student_fee - 1.73;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes == 2)

                {
                    double available_balance = your_balance - student_fee;
                    double balance = student_fee - 1.88;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");

                }
                else if (number_of_goes == 3)

                {
                    double available_balance = your_balance - student_fee;
                    double balance = student_fee - 2.19;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }

                else if (number_of_goes >= 4 && number_of_goes <= 9)

                {
                    double available_balance = your_balance - student_fee;
                    double balance = student_fee - 2.50;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes > 9)

                {
                    double available_balance = your_balance - student_fee;

                    MessageBox.Show($"You are not entitled to a balance refund." +
                        $"\nYour remaining balanceb : {available_balance}TL");
                }


            }
            else
            {
                MessageBox.Show("Your balance is insufficient.");
            }

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            double your_balance = Convert.ToDouble(textYour_Balance.Text);
            double number_of_goes = Convert.ToDouble(textNumber_Of_Goes.Text);
            double normal_fee = 8.13;



            if (your_balance >= 8.13)
            {
                if (number_of_goes == 1)
                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 3.92;

                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes == 2)
                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 4.69;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes == 3)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 5.48;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }

                else if (number_of_goes >= 4 && number_of_goes <= 9)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 6.26;
                    double balance2 = balance + available_balance;
                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 10 && number_of_goes <= 15)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 6.88;

                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 16 && number_of_goes <= 21)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 7.19;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 22 && number_of_goes <= 27)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 7.43;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 28 && number_of_goes <= 33)

                {
                    double available_balance = your_balance - normal_fee;
                    double balance = normal_fee - 7.59;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }

                else if (number_of_goes > 34)

                {
                    double available_balance = your_balance - normal_fee;

                    MessageBox.Show($"You are not entitled to a balance refund." +
                        $"\nYour remaining balanceb : {available_balance} TL");
                }


            }
            else
            {
                MessageBox.Show("Your balance is insufficient.");
            }
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            double your_balance = Convert.ToDouble(textYour_Balance.Text);
            double number_of_goes = Convert.ToDouble(textNumber_Of_Goes.Text);
            double social_fee = 3.92;

            if (your_balance >= 3.92)
            {
                if (number_of_goes == 1)
                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 2.42;

                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes == 2)
                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 2.90;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes == 3)

                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 3.36;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }

                else if (number_of_goes >= 4 && number_of_goes <= 9)

                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 3.92;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 10 && number_of_goes <= 15)

                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 3.98;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }
                else if (number_of_goes >= 16 && number_of_goes <= 21)

                {
                    double available_balance = your_balance - social_fee;
                    double balance = social_fee - 4.23;
                    double balance2 = balance + available_balance;

                    MessageBox.Show($"Refunded amount : {Math.Round(balance, 2)}TL" +
                        $"\nYour remaining balanceb : {Math.Round(balance2, 2)} TL ");
                }

                else if (number_of_goes > 22)

                {
                    double available_balance = your_balance - social_fee;

                    MessageBox.Show($"You are not entitled to a balance refund." +
                        $"\nYour remaining balanceb : {available_balance}TL");
                }


            }
            else
            {
                MessageBox.Show("Your balance is insufficient.");
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textVize.Text);
            double final = Convert.ToDouble(textFinal.Text);
            double odev = Convert.ToDouble(textOdev.Text);

            double ortalama = (vize / 100 * 30) + (final / 100 * 60) + (odev / 100 * 10);
            string harfnotu1 = "CC", harfnotu2 = "CB", harfnotu3 = "BB", harfnotu4 = "BA", harfnotu5 = "AA";

            if (vize >= 0 && final >= 0 && odev >= 0)
            {

                if (ortalama >= 0 && ortalama < 40)
                    MessageBox.Show($"Ortalama:{ortalama} FF ");


                else if (ortalama >= 40 && ortalama < 50)
                { MessageBox.Show($"Ortalama:{ortalama}\nHarf Notu: {harfnotu1}"); }

                else if (ortalama >= 50 && ortalama < 65)
                { MessageBox.Show($"Ortalama:{ortalama}\nHarf Notu: {harfnotu2}"); }

                else if (ortalama >= 65 && ortalama < 75)
                { MessageBox.Show($"Ortalama:{ortalama}\nHarf Notu: {harfnotu3}"); }

                else if (ortalama >= 75 && ortalama < 85)
                { MessageBox.Show($"Ortalama:{ortalama}\nHarf Notu: {harfnotu4}"); }
                else if (ortalama >= 85 && ortalama <= 100)
                { MessageBox.Show($"Ortalama:{ortalama}\nHarf Notu: {harfnotu5}"); }

                else
                { MessageBox.Show("100'den büyük deðer giremezsiniz"); }


            }
            else
            {
                MessageBox.Show("0'dan küçük sayý giremezsiniz!");


            }
        }
    }
}