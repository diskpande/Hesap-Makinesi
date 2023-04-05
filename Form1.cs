namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void nmb(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum) //txtSonuctaki 0 yazýsýný sildi
                txtSonuc.Clear();

            optDurum = false;

            Button btn = (Button)sender; //rakamlara ortak click num ismi verildikten sonra gözükmesi saðlandý
            txtSonuc.Text += btn.Text;
        }

        private void OptCalc(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lblSonuc.Text = lblSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }

            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }

            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }

            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}