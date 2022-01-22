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
    public partial class AtmApp1 : Form
    {
        public AtmApp1()
        {
            InitializeComponent();
        }


        Dictionary<string, string > users = new Dictionary<string, string>();
        Dictionary<string, int> usersbalance = new Dictionary<string, int>();

        bool SignUp( string userId , string password)
        {
            if (userId == null && password == null) 
            {
                return false;  
            }
            else
            {
                users.Add(userId, password);
               
                return true;
            }

        }
        bool SignUpBalance(string userId, int balance)
        {
            usersbalance.Add(userId, balance); 
            return true;
        }



        private void AtmApp1_Load(object sender, EventArgs e)
        {
            groupBoxSignIn.Visible = false;
            groupBoxWelcome.Visible = false;    
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            bool result = SignUp(textUserId.Text, textPassword.Text);
            if (result = true)
            {
                groupBoxSignIn.Visible = true;
                groupBoxSignUp.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter correct information..!!");
            }
        }

      
        
    }
}
