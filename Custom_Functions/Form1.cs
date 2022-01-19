namespace Custom_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //I made a function to find the factorial.
        /// <summary>
        /// This function finds the factorial of the entered integer value.
        /// </summary>
        /// <param name="value_1"></param>
        /// <returns>Returns data of type integer</returns>
        int Factorial(int value_1)
        {
            int number1 = Convert.ToInt32(textFactorialNumber.Text);
            int multiply = 1;

            for (int i = 2; i <= number1; i++)
            {
                multiply = multiply * i;
            }

            return multiply;

        }


        //let's check the working of our function
        private void btnFactorialFunction_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Factorial = {(Factorial(int.Parse(textFactorialNumber.Text)))} ");
        }

        //Let's do the Mile to Km converter function.
        /// <summary>
        /// This function converts the value in miles to kilometers.
        /// </summary>
        /// <param name="value_1"></param>
        /// <returns>Returns a value of type integer.</returns>
        double MileKm(double value_1)
        {
            double mile  = Convert.ToDouble(textNumber1.Text);
            double km = 1.609344;

            double result = mile * km;

            return result;

        }

        //let's check the working of our function
        private void btnExample1_Click(object sender, EventArgs e)
        {    
            MessageBox.Show($"Km = {(MileKm(double.Parse(textNumber1.Text)))}");
        }


        //Let's make the function that calculates the body mass index.
        /// <summary>
        /// This function calculates the body mass index according to the given height and weight value.
        /// </summary>
        /// <param name="value_1"></param>
        /// <param name="value_2"></param>
        /// <returns>Returns String data type</returns>

        string Bodymassindex(double value_1, double value_2 )
        {
             double height = Convert.ToDouble(textHeight.Text);        
             double Weight = Convert.ToDouble(textWeight.Text);


            double index1 = height * height;
            double index2 = Weight / index1;
            string message;


            if (index2 < 18.5)
            {
                message= $"Body mass index : {Math.Round(index2,2)}\nYou are underweight.";
            }
            else if (index2 >= 18.5 && index2 <= 24.9)
            {
                message = $"Body mass index : {Math.Round(index2, 2)}\nNormal weight.";
            }
            else if (index2 >= 25 && index2 <= 29.9)
            {
                message = $"Body mass index : {Math.Round(index2, 2)}\nOverweight.";
            }
            else if (index2 >= 30 && index2 <= 34.9)
            {
                message = $"Body mass index : {Math.Round(index2, 2)}\nObesity class I .";
            }
            else if (index2 >= 35 && index2 <= 39.9)
            {
                message = $"Body mass index : {Math.Round(index2, 2)}\nObesity class II ";
            }
            else if (index2 > 40)
            {
                message = $"Obesity class III";
            }
            else
            {
                message = ("You entered an incorrect number");
            }

            return message; 

        }

        private void btnBmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Bodymassindex(double.Parse(textHeight.Text), double.Parse(textWeight.Text))}");

        }


    }
}