using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpCalculette
{
    public partial class frmCalculette : Form
    {
        List<double> Numbers = new List<double>();
        List<string> Operators = new List<string>();

        string Operation;
        public frmCalculette()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(frmCalculette_KeyPress);
            this.KeyPreview = true;
        }
        private void frmCalculette_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                btn_supLast_Click(null, null);
            }
            else
            {
                HandleKeyPress(e.KeyChar);
            }
        }
        private void HandleOperator(string newOperator)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            Operators.Add(newOperator);

            txtAffichage.Text = "0";
        }
        private void HandleKeyPress(char key)
        {
            if (char.IsDigit(key))
            {
                if (txtAffichage.Text == "0" || txtAffichage.Text == "-0")
                {
                    txtAffichage.Text = key.ToString();
                }
                else
                {
                    if (txtAffichage.Text == "-" && txtAffichage.Text.Length == 1)
                    {
                        txtAffichage.Text += key;
                    }
                    else
                    {
                        txtAffichage.Text += key;
                    }
                }
            }
        
            else
            {
                switch (key)
                {
                    case '+':
                        HandleOperator("+");
                        break;
                    case '-':
                        HandleOperator("-");
                        break;
                    case '*':
                        HandleOperator("*");
                        break;
                    case '/':
                        HandleOperator("/");
                        break;
                    case '.':
                        if (!txtAffichage.Text.Contains("."))
                        {
                            txtAffichage.Text += key;
                        }
                        break;
                    case (char)Keys.Enter:
                        btnCalculer_Click(null, null); 
                        break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtAffichage.TextAlign = HorizontalAlignment.Right;
           // txtAffichage.SelectionStart = txtAffichage.Text.Length;
          //  txtAffichage.SelectionLength = 0;
            txtAffichage.Enabled = false;
        }
      


        private void btn1_Click(object sender, EventArgs e)
        {
          
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "1";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "1";
            }
            pictureBox2.Focus();

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "2";
            }
            else

                txtAffichage.Text = txtAffichage.Text + "2";
            pictureBox2.Focus();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "3";
            }
            else
                txtAffichage.Text = txtAffichage.Text + "3";
            pictureBox2.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "4";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "4";
            }
            pictureBox2.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "5";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "5";
            }
            pictureBox2.Focus();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "6";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "6";
            }
            pictureBox2.Focus();
        }

        private void btnsev_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "7";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "7";
            }
            pictureBox2.Focus();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "8";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "8";
            }
            pictureBox2.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" && txtAffichage.Text != null)
            {
                txtAffichage.Text = "9";
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + "9";
            }
            pictureBox2.Focus();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtAffichage.Text == "0")
                return;
            txtAffichage.Text = txtAffichage.Text + "0";
            pictureBox2.Focus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            Operators.Add("+");

            txtAffichage.Text = "0";
            pictureBox2.Focus();
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            Operators.Add("-");

            txtAffichage.Text = "0";
            pictureBox2.Focus();


        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            Operators.Add("*");

            txtAffichage.Text = "0";

            pictureBox2.Focus();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            Operators.Add("/");

            txtAffichage.Text = "0";
                pictureBox2.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            txtAffichage.Focus();
            pictureBox2.Focus();
        }



        private void btnCalculer_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(txtAffichage.Text);
            Numbers.Add(currentNumber);
            double Result = CalculateResult();
            txtAffichage.Text = Convert.ToString(Result);
            txtAffichage.Focus();
            pictureBox2.Focus();
        }
        private double CalculateResult()
        {
            double Result = Numbers[0];

            for (int i = 1; i < Numbers.Count; i++)
            {
                double currentNumber = Numbers[i];
                string currentOperator = Operators[i - 1];

                switch (currentOperator)
                {
                    case "+":
                        Result += currentNumber;
                        break;
                    case "-":
                        Result -= currentNumber;
                        break;
                    case "*":
                        Result *= currentNumber;
                        break;
                    case "/":
                        if (currentNumber == 0)
                        {
                            txtAffichage.Text = "Cannot divide by zero";
                            return 0;
                        }
                        Result /= currentNumber;
                        break;
                }
            }

            Numbers.Clear();
            Operators.Clear();
            return Result;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAffichage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_supLast_Click(object sender, EventArgs e)
          {

            if (txtAffichage.Text.Length > 0)
            {
                StringBuilder sb = new StringBuilder(txtAffichage.Text);
                sb.Remove(sb.Length - 1, 1);
                txtAffichage.Text = sb.ToString();
            }
             if (txtAffichage.Text.Length == 0)
                txtAffichage.Text = "0";
            pictureBox2.Focus();

        }

        private void btn_vergule_Click(object sender, EventArgs e)
        {
            if ( txtAffichage.Text == null)
            {
                return;
            }
            else
            {
                txtAffichage.Text = txtAffichage.Text + ".";
            }
            pictureBox2.Focus();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtAffichage.Text, out float parsedValue) && parsedValue > 0)
            {
                txtAffichage.Text = (-parsedValue).ToString();
            }
            else if (float.TryParse(txtAffichage.Text, out float parsedVal) && parsedVal < 0) // Fix the variable name here
            {
                txtAffichage.Text = (-parsedVal).ToString();
            }
            else
                return;
            pictureBox2.Focus();
        }


        private void btn_pourcentage_Click(object sender, EventArgs e)
        {
           float.TryParse(txtAffichage.Text, out float parsetwo);
            txtAffichage.Text = (parsetwo / 100).ToString();
            pictureBox2.Focus();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            pictureBox2.Focus();
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            float.TryParse(txtAffichage.Text, out float parsetwo);
            double res = Math.Sqrt(parsetwo);
            txtAffichage.Text = res.ToString();
            pictureBox2.Focus();

        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            float.TryParse(txtAffichage.Text, out float parsetwo);
            double res = parsetwo*parsetwo;
            txtAffichage.Text = res.ToString();
            pictureBox2.Focus();
        }

        private void btn_1surx_Click(object sender, EventArgs e)
        {
            float.TryParse(txtAffichage.Text, out float parsetwo);
            double res = 1/ parsetwo;
            txtAffichage.Text = res.ToString();
            pictureBox2.Focus();
        }
    }
}