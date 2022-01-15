namespace _03_SwiTch_CaSe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string message;
            switch (comboDays.Text) 
            {
                case "Monday" :
                    message = " 09:00 = Math\n 11:00 = Science\n 13:00 = Lunch break\n 15:00 = Social Studies ";
                    break;
                case "Thuersday" :
                    message = " 09:00 = Art\n 11:00 = Music\n 13:00 = Lunch break\n 15:00 = History ";
                    break;
                case "Wednesday" :
                    message = " 09:00 = Psychology\n 11:00 = English\n 13:00 = Lunch break\n 15:00 = Physical Education (PE) ";
                    break;
                case "Thursday" :
                    message = " 09:00 = Economics\n 11:00 = Geography\n 13:00 = Lunch break\n 15:00 = Archaeology ";
                    break;
                case "Friday" :
                    message = " 09:00 = Biology\n 11:00 = Chemistry\n 13:00 = Lunch break\n 15:00 = Drama ";
                    break;
               default :
                    message = " You don't have class today.";
                    break;

            }
            MessageBox.Show(message);

        }
    }
}
