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
    public partial class BusTicketApp : Form
    {
        public BusTicketApp()
        {
            InitializeComponent();
        }


        private void BusTicketApp_Load(object sender, EventArgs e)
        {
            grpPayment.Visible = false;
            grpTicket.Visible = false;
            totalprice.Add(0);

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textseatnumber.Text = "1";
            btn1.BackColor = Color.White;
            totalprice[0] += 185;
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "3";
            btn3.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "4";
            btn4.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "5";
            btn5.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "6";
            btn6.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "7";
            btn7.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "8";
            btn8.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "9";
            btn9.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "10";
            btn10.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "11";
            btn11.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "12";
            btn12.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "13";
            btn13.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "14";
            btn14.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "15";
            btn15.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "16";
            btn16.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "17";
            btn17.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "18";
            btn18.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "19";
            btn19.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "20";
            btn20.BackColor = Color.White;
            totalprice[0] += 185;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "21";
            btn21.BackColor = Color.White;
            totalprice[0] += 185;


        }
        private void btn12_Click_1(object sender, EventArgs e)
        {
            textseatnumber.Text = "12";
            btn12.BackColor = Color.White;
            totalprice[0] += 185;

        }


        //Here, after choosing the first chief seat number, I changed the seat color from white to red after the ticket was purchased.
        bool seatstate(int seatnumber)
        {
            switch (seatnumber)
            {
                case 1:
                    btn1.BackColor = Color.Red;
                    break;
                case 2:
                    btn2.BackColor = Color.Red;
                    break;
                case 3:
                    btn3.BackColor = Color.Red;
                    break;
                case 4:
                    btn4.BackColor = Color.Red;
                    break;
                case 5:
                    btn5.BackColor = Color.Red;
                    break;
                case 6:
                    btn6.BackColor = Color.Red;
                    break;
                case 7:
                    btn7.BackColor = Color.Red;
                    break;
                case 8:
                    btn8.BackColor = Color.Red;
                    break;
                case 9:
                    btn9.BackColor = Color.Red;
                    break;
                case 10:
                    btn10.BackColor = Color.Red;
                    break;
                case 11:
                    btn11.BackColor = Color.Red;
                    break;
                case 12:
                    btn12.BackColor = Color.Red;
                    break;
                case 13:
                    btn13.BackColor = Color.Red;
                    break;
                case 14:
                    btn14.BackColor = Color.Red;
                    break;
                case 15:
                    btn15.BackColor = Color.Red;
                    break;
                case 16:
                    btn16.BackColor = Color.Red;
                    break;
                case 17:
                    btn17.BackColor = Color.Red;
                    break;
                case 18:
                    btn18.BackColor = Color.Red;
                    break;
                case 19:
                    btn19.BackColor = Color.Red;
                    break;
                case 20:
                    btn20.BackColor = Color.Red;
                    break;
                case 21:
                    btn21.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            return true;

        }


        List<string> users = new List<string>();
        List<int> totalprice = new List<int>(); 
        private void btnBuyAticket_Click(object sender, EventArgs e)
        {


            string firstname = textFirstName.Text;
            string lastname = textLastName.Text;    
            string ıd = textId.Text;
            int seatnumber = Convert.ToInt32(textseatnumber.Text);

           

            string fullname = firstname +" "+ lastname + "   " + ıd + "    " + textseatnumber.Text;

            for (int i = 0; i < 1; i++)
            { 
               
                users.Add(fullname); 

            }

            groupBoxBusTicket.Visible = false;
            groupBoxSeatBumber.Visible = false;
            grpPayment.Visible = true;

            labelFULLNAME.Text = firstname + " " + lastname;
            labelAmount.Text = totalprice[0].ToString();


           

            //Here, after choosing the first chief seat number, I changed the seat color from white to red after the ticket was purchased.
            seatstate(seatnumber);
            

        }   


        private void btn2_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "2";
            btn2.BackColor = Color.White;
            totalprice[0] += 185;
        }




        private void btnpayment_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(mskExpareDate.Text) || String.IsNullOrWhiteSpace(mskCVS.Text) || String.IsNullOrWhiteSpace(mskCardNo.Text))
            {
                MessageBox.Show("Please enter your information completely.!");
            }
            else if (mskCardNo.Text.Length < 19 || mskCVS.Text.Length < 3 || mskExpareDate.Text.Length < 5) 
            {
                MessageBox.Show("Please enter your information completely..!");
            }

            else
            {
                DialogResult dr = MessageBox.Show("Complete your payment? ", "Caution", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("YOUR TRANSACTION HAS BEEN CANCELED..!");


                    //I showed the passenger report on the bus and the total amount of tickets sold. 

                    TİCKET.Items.Add("FULL NAME                ID                   SEAT NUMBER     ");
                    foreach (string user1 in users)
                    {

                        TİCKET.Items.Add(user1);
                        TİCKET.Items.Add("Bus Departure Time: 09:00 Bus Platform: 15");
                        TİCKET.Items.Add("We wish you a pleasant journey..");
                        TİCKET.Items.Add("THEREC TRUZİM");
                    }
                    TİCKET.Items.Add($"TOTAL AMOUNT: {totalprice[0]} TL ");
                    grpTicket.Visible = true;   

                }
                else
                {
                    MessageBox.Show("YOUR PROCESS IS DONE.!");
                   
                }
            }
        }
    }
}
