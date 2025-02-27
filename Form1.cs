namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "2";
            }
            else
            {
                ay.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "3";
            }
            else
            {
                ay.Text += "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "1";
            }
            else
            {
                ay.Text += "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "4";
            }
            else
            {
                ay.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "5";
            }
            else
            {
                ay.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "6";
            }
            else
            {
                ay.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "7";
            }
            else
            {
                ay.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "8";
            }
            else
            {
                ay.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "9";
            }
            else
            {
                ay.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = "0";
            }
            else
            {
                ay.Text += "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ay.Text == "0")
            {
                ay.Text = ",";
            }
            else
            {
                ay.Text += ",";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ay.Text);
            ay.Text = "x";
            ay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ay.Text);
            ay.Text = "/";
            ay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ay.Text);
            ay.Text = "-";
            ay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(ay.Text);
            ay.Text = "+";
            ay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(ay.Text);
            switch (opr)
            {
                case 1:
                    ay.Text = Convert.ToString(bil1 * bil2);
                    break;
                case 2:
                    ay.Text = Convert.ToString(bil1 / bil2);
                    break;
                case 3:
                    ay.Text = Convert.ToString(bil1 - bil2);
                    break;
                case 4:
                    ay.Text = Convert.ToString(bil1 + bil2);
                    break;

            }
            opr_selesai = false;
        }
    }
}

