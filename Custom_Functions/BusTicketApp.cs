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
     

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textseatnumber.Text = "1";
            btn1.BackColor = Color.White;
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "3";
            btn3.BackColor = Color.White;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "4";
            btn4.BackColor = Color.White;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "5";
            btn5.BackColor = Color.White;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "6";
            btn6.BackColor = Color.White;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "7";
            btn7.BackColor = Color.White;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "8";
            btn8.BackColor = Color.White;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "9";
            btn9.BackColor = Color.White;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "10";
            btn10.BackColor = Color.White;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "11";
            btn11.BackColor = Color.White;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "12";
            btn12.BackColor = Color.White;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "13";
            btn13.BackColor = Color.White;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "14";
            btn14.BackColor = Color.White;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "15";
            btn15.BackColor = Color.White;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "16";
            btn16.BackColor = Color.White;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "17";
            btn17.BackColor = Color.White;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "18";
            btn18.BackColor = Color.White;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "19";
            btn19.BackColor = Color.White;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "20";
            btn20.BackColor = Color.White;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "21";
            btn21.BackColor = Color.White;
            

        }
        private void btn12_Click_1(object sender, EventArgs e)
        {
            textseatnumber.Text = "12";
            btn12.BackColor = Color.White;

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
                totalprice.Add(i);
                int total = 185 + totalprice[0];
                totalprice[0] = total;

            }
 

            //Ticket.


            MessageBox.Show(
            $"Full Name : {fullname}\nID : {ıd}" +
            $"\nSelected Seat: {textseatnumber.Text}" +
            $"\nTicket Price: 185 TL" +
            $"\nSelected Seat: {textseatnumber.Text}" +
            $"\nTicket Price : 185 TL" +
            $"\nBus Departure Time : 09:00   Bus Platform : 15" +
            $"\nWe wish you a pleasant journey.." +
            $"\nTHEREC TRUZİM "
            );



            //Here, after choosing the first chief seat number, I changed the seat color from white to red after the ticket was purchased.

            switch (seatnumber)
            {
                case 1 : 
                    btn1.BackColor= Color.Red;
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


            //I deleted all the textboxes after the process was finished.

            textFirstName.Clear(); textLastName.Clear(); textId.Clear(); textseatnumber.Clear();




        }   

        private void btnGetReport_Click(object sender, EventArgs e)
        {


            //I showed the passenger report on the bus and the total amount of tickets sold. 


            REPORT.Items.Add("FULL NAME                ID                   SEAT NUMBER     ");
            foreach (string user1 in users)
            {
         
                REPORT.Items.Add(user1);

            }
            REPORT.Items.Add($"TOTAL GAINS : {totalprice[0]} TL ");


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textseatnumber.Text = "2";
            btn2.BackColor = Color.White;
        }


    }
}
