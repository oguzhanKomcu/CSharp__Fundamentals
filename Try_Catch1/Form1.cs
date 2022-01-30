namespace Try_Catch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFcc_Click(object sender, EventArgs e)
        {
            try
            {
                float tafpd = float.Parse(textTaopf.Text);
                float tl = float.Parse(textTl.Text);


                float penny_account = tl / tafpd;
                MessageBox.Show($" 1=km PRÝCE :  {Math.Round(penny_account)} TL ");
            }
            catch (Exception)
            {
                MessageBox.Show("NULL VALUE CANNOT BE ENTERED !!");

            }
        }
    }
}