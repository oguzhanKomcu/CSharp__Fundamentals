namespace _01.Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFcc_Click(object sender, EventArgs e)
        {

            float tafpd = float.Parse(textTaopf.Text);
            float tl = float.Parse(textTl.Text);


            float penny_account = tl / tafpd;
            MessageBox.Show($" 1=km PRİCE :  {Math.Round(penny_account)} TL ");


        }

        private void btnRacfp_Click(object sender, EventArgs e)
        {
            double wr = Convert.ToDouble(textwidthofroom.Text);
            double lor = Convert.ToDouble(textTLOTR.Text);
            double hotr = Convert.ToDouble(textHOTR.Text);
            double dw = Convert.ToDouble(textDoorWidth.Text);
            double dh = Convert.ToDouble(textDoorHeight.Text);
            double ww = Convert.ToDouble(textWindowWidth.Text);
            double wh = Convert.ToDouble(textWindowHeight.Text);


            double window_are = ww * wh;
            double door_are = dw * dh;
            double area_to_be_painted = (lor * hotr * 2) + (wr * hotr * 2) - window_are + door_are;
            double ceiling_area = (lor * wr);

            MessageBox.Show($"Your area to be painted : {Math.Round(area_to_be_painted)}m²\nCeiling area of ​​your room: {ceiling_area}m² ");

        }

        private void btnLuc_Click(object sender, EventArgs e)
        {

            double mile = Convert.ToDouble(textMile.Text);
            double gallon = Convert.ToDouble(textGallon.Text);


            double km = 1.609344 * mile;
            double lr = 3.78541178 * gallon ;

            MessageBox.Show($"Kilometer : {Math.Round(km)}km\nLITER: {Math.Round(lr)}l");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}