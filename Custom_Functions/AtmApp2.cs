using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Functions
{
    public partial class AtmApp2 : Form
    {
        public AtmApp2()
        {
            InitializeComponent();
        }

        Dictionary<string, string> users = new Dictionary<string, string>();
        Dictionary<string,string> usersFullName = new Dictionary<string, string>();
        List<double> usebalance = new List<double>();

        bool SignUpFullName( string firstname, string lastname)
        {
            if (firstname == "" && lastname == "")
            {
                return false;
            }
            else
            {
                usersFullName.Add(firstname, lastname);

                return true;
            }

        }


        bool Passwordnumberquery(string password)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            char[] numbers1 = password.ToCharArray(); 

            bool resault = false;

            for (int i = 0; i < numbers.Length; i++)
            {


                for (int j = 0; j < password.Length; j++)
                {
                    if (numbers1[j] == numbers[i])
                    {
                        resault = true;
                    }
                }

                


            }

            return resault;

        }

        bool SignUp(string userId, string password)
        {

            if (userId != "" && userId.Length == 11 )
            {
             
                if (password != "" && password.Length! > 5 && Passwordnumberquery(password) == true)
                {
                    users.Add(userId, password);
                    return true;
                }
                else
                {
                    MessageBox.Show("You entered the wrong password or ID !!");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("You entered the wrong password or ID !!");
                return false;
            }

        }
        double Balance()
        {
            double depositmoney1 = Convert.ToDouble(textTransactions.Text);
            double balance = 0;


            double totalbalance = depositmoney1 + balance;
            usebalance.Add(totalbalance);
            return totalbalance;

        }
        double NewBalance()
        {
            double depositmoney1 = Convert.ToDouble(textTransactions.Text);

            double totalbalance = usebalance[0] - depositmoney1;
           
            return totalbalance;

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            bool result1 = SignUpFullName(textFirstName.Text, textLastName.Text);
            if (result1 == true)
            {
                bool result2 = SignUp(textUserId.Text, textPassword.Text);

                if (result2 == true)
                {
                    MessageBox.Show("Your registration has been successfully created..");
                    groupBoxSignIn.Visible = true;
                    groupBoxSignUp.Visible = false;

                }
                else
                {
                    MessageBox.Show("Please enter correct information..!!");
                }
            }
            else
            {
                MessageBox.Show("You cannot register without entering first name and last name.");
            }


        }


        private void AtmApp2_Load(object sender, EventArgs e)
        {
            groupBoxSignIn.Visible = false;
            groupBoxHomePage.Visible = false;
        }

        private void btnSignİn_Click(object sender, EventArgs e)
        {
            bool resault1 = false;
            bool resault2 = false;  
            
            foreach (string userId in users.Keys)
            {
                if(userId == textSignİnUserID.Text)
                {
                    resault1 = true;
                    foreach (string password in users.Values)
                    {
                        if (password == textSignİnPassword.Text)
                        {
                            resault2 = true;
                        }

                    }
                    if(resault2 == false)
                    {
                        MessageBox.Show("You have entered incorrectly.");


                    }
                    else
                    {
                        MessageBox.Show("Login successful.\nWELCOME ! ");
                        groupBoxSignIn.Visible = false;
                        groupBoxHomePage.Visible = true;
                        
                        break;
                    }
                }

            }
            if(resault1 == false)
            {
                MessageBox.Show("You have entered incorrectly.\n Please try again.");
            }

        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToDouble(textTransactions.Text) < usebalance[0])
            {
                
                MessageBox.Show($"Your withdrawal has been successfully completed.\nTotal Balance = {NewBalance()}");
                labelBalance.Text = ""; 
                labelBalance.Text = NewBalance().ToString()+" TL";
                textTransactions.Clear();
            }
            
        

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
      
                labelBalance.Text = Balance().ToString();
                MessageBox.Show("Your transaction has been completed successfully.");
                textTransactions.Clear();


        }
    }
}
