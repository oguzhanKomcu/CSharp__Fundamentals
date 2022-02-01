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



        void GroupboxCLEAR(GroupBox groupBox)
        {
            foreach (Control txt in groupBox.Controls)
            {
                if (txt is TextBox)  //textboxları silicek
                {
                    txt.Text = String.Empty;
                }

            }
        }

        bool numbercontrol(string text)
        {


            char[] control = text.ToLower().ToCharArray();
            bool result = false;

            foreach (char item in text)
            {
                switch (item)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        result = true;
                        break;

                    default:
                        break;


                }

            }

            return result;

        }


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




        bool SignUp(string userId, string password)
        {

            if (userId != "" && userId.Length == 11 )
            {
             
                if (password != "" && password.Length > 5 && numbercontrol(password) == true)
                {
                    users.Add(userId, password);
                    return true;
                }
                else
                {
                    MessageBox.Show("You entered the wrong password or ID . Your password must have a number .!!");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("You entered the wrong password or ID !!");
                return false;
            }
        }
       bool Balance()
        {
       
            double depositmoney1 = Convert.ToDouble(textTransactions.Text);
          
            double balance = 0;



            double totalbalance = depositmoney1 + usebalance[0];
            usebalance[0] = totalbalance;
            return true;

        }
       bool NewBalance()
        {
            double depositmoney1 = Convert.ToDouble(textTransactions.Text);

            double totalbalance = usebalance[0] - depositmoney1;
            usebalance[0] = totalbalance;
            return true;

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


            labelfullname.Text = textFirstName.Text + " " + textLastName.Text + "  , "+ "WELCOME";

            GroupboxCLEAR(groupBoxSignUp);


        }


        private void AtmApp2_Load(object sender, EventArgs e)
        {
            usebalance.Add(0);
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

           

            GroupboxCLEAR(groupBoxSignUp);




        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToDouble(textTransactions.Text) < usebalance[0])
            {
                NewBalance();
                MessageBox.Show($"Your withdrawal has been successfully completed.\nTotal Balance = {usebalance[0]}");
                labelBalance.Text = "";
               
                labelBalance.Text = usebalance[0].ToString()+" TL";
                textTransactions.Clear();
            }
            DialogResult atm = MessageBox.Show($"Would you like to return to ATM form?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (atm == DialogResult.No)
            {
                groupBoxHomePage.Visible=false; 
                groupBoxSignIn.Visible=false;   
                groupBoxSignUp.Visible= true;
                labelBalance.Text = "";

            }
            
        

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Balance();
                labelBalance.Text = usebalance[0].ToString()+" TL";
                MessageBox.Show("Your transaction has been completed successfully.");
                textTransactions.Clear();


        }
    }
}
