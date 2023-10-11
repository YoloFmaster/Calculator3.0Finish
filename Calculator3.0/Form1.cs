namespace Calculator3._0
{
    public partial class Form1 : Form
    {
        string Znak = "";
        double num1;
        double num2;
        bool startEnter = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CALCULATE";
            btn1.Text = "1"; btn2.Text = "2"; btn3.Text = "3";
            btn4.Text = "4"; btn5.Text = "5"; btn6.Text = "6";
            btn7.Text = "7"; btn8.Text = "8"; btn9.Text = "9";
            btn0.Text = "0"; btnEquals.Text = "="; btnPlus.Text = "+";
            btnMinus.Text = "-"; btnMultiply.Text = "*"; btnDivided.Text = "/";
            btnClear.Text = "Clear";
        }

        private void Number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String Digit = button.Text;
            if (startEnter == true)
            {
                txtOutput.Text = Digit;
                startEnter = false;
                return;
            }
            if (startEnter == false )
            {
                txtOutput.Text = txtOutput.Text + Digit;
            }
        }
        private void Operation(object sender, EventArgs e)
        {
            num1 =  Double.Parse(txtOutput.Text);
            Button button = (Button)sender;
            Znak = button.Text;
            startEnter = true;
        }
        private void Equals(object sender, EventArgs e)
        {
            double Total = 0.0;
            num2 = Double.Parse(txtOutput.Text);
            if (Znak == "+") Total = num1 + num2;
            if (Znak == "-") Total = num1 - num2;
            if (Znak == "*") Total = num1 * num2;
            if (Znak == "/") Total = num1 / num2;
            Znak = null;
            txtOutput.Text = Total.ToString();
            num2 = Total;
            startEnter = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0"; Znak = null; startEnter = true;
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}

