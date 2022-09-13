namespace Calculator1
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDesplayResult.Text == "0" || (isOperationPerformed))
                tbDesplayResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            //validation on decimals more than 1
            if (button.Text == ".")
            {
                if (!tbDesplayResult.Text.Contains("."))
                    tbDesplayResult.Text += button.Text;
            }
            else
            {
                tbDesplayResult.Text += button.Text;

            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDesplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDesplayResult.Text = "0";
            resultValue = 0;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbDesplayResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbDesplayResult.Text = (resultValue + double.Parse(tbDesplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDesplayResult.Text = (resultValue - double.Parse(tbDesplayResult.Text)).ToString();
            }
            else if (operationPerformed == "*")
            {
                tbDesplayResult.Text = (resultValue * double.Parse(tbDesplayResult.Text)).ToString();
            }
            else
            {
                tbDesplayResult.Text = (resultValue / double.Parse(tbDesplayResult.Text)).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tbDesplayResult.Text.Length > 0)
                tbDesplayResult.Text = tbDesplayResult.Text.Remove(tbDesplayResult.Text.Length - 1, 1);
            if (tbDesplayResult.Text == "")
                tbDesplayResult.Text = "0";
        }
    }
}