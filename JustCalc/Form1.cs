using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustCalc {

    // JUST CALC by DeLy

    public partial class MainForm : Form
    {
        const double VerCode = 0.2;

        char Mouchen = '0';
        double A = 0;
        double B = 0;
        double C = 0;

        public MainForm() // Initializing
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void numberClick(object sender, EventArgs e) // Number btn click
        {
            if (textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || textBox1.Text == "Divide by zero!")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + (sender as Button).Text;

            console.Text = console.Text + "Button ";
        }

        private void buttonBS_Click(object sender, EventArgs e) // Backspace btn click
        {
            if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "") textBox1.Text = "0";
        }

        private void mouchenClick(object sender, EventArgs e) // Mouchen btn click
        {
            if (textBox1.Text == "Divide by zero!") textBox1.Text = "0"; // Set 0 if text = "Divide by zero!"

            if (!(textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*" || textBox1.Text == "/"))
            {
                A = Convert.ToDouble(textBox1.Text);
            }

            char[] arr = (sender as Button).Text.ToCharArray();
            Mouchen = arr[0];

            //textBox1.Text = (sender as Button).Text; // Second variant
            textBox1.Text = Convert.ToString(Mouchen);
        }

        private void resultClick(object sender, EventArgs e) // Give result
        {
            B = Convert.ToDouble(textBox1.Text);

            if (Mouchen == '+')
            {
                C = A + B;
                console.Text = console.Text + Convert.ToString(A);
                console.Text = console.Text + Convert.ToString(B);
                console.Text = console.Text + Convert.ToString(C);
            }
            else if (Mouchen == '-') C = A - B;
            else if (Mouchen == '*') C = A * B;
            else if (Mouchen == '/')
            {
                if (B == 0) textBox1.Text = "Divide by zero!";
                else C = A / B;
            }

            textBox1.Text = Convert.ToString(C);
        }

        private void buttonCE_Click(object sender, EventArgs e) // CE btn click
        {
            textBox1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e) // C btn click
        {
            A = 0;
            B = 0;
            textBox1.Text = "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e) // "," click
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) // Key pressing imitation
        {

            /*if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) button1.PerformClick();                // Numbers
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) button2.PerformClick();
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) button3.PerformClick();
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) button4.PerformClick();
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) button5.PerformClick();
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) button6.PerformClick();
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) button7.PerformClick();
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) button8.PerformClick();
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) button3.PerformClick();
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) button0.PerformClick();
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add) buttonPlus.PerformClick();        // Math
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) buttonMinus.PerformClick();
            else if (e.KeyCode == Keys.Divide) buttonDiv.PerformClick();
            else if (e.KeyCode == Keys.Multiply) buttonMult.PerformClick();
            else if (e.KeyCode == Keys.Delete) buttonBS.PerformClick();                                    // Controls
            else if (e.KeyCode == Keys.Enter) buttonResult.PerformClick();

            if (e.KeyCode == Keys.Enter) buttonResult.PerformClick();
            else if (e.KeyCode == Keys.Delete) buttonC.PerformClick();*/
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                if (textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "0" || textBox1.Text == "Divide by zero!")
                {
                    textBox1.Text = "";
                }

                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                //e.Handled = true;
                buttonPoint.PerformClick();
            }*/
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "Divide by zero!")
            {
                textBox1.Text = "0";
            }

            if (e.KeyChar == '1') button1.PerformClick();                // Numbers
            else if (e.KeyChar == '2') button2.PerformClick();
            else if (e.KeyChar == '3') button3.PerformClick();
            else if (e.KeyChar == '4') button4.PerformClick();
            else if (e.KeyChar == '5') button5.PerformClick();
            else if (e.KeyChar == '6') button6.PerformClick();
            else if (e.KeyChar == '7') button7.PerformClick();
            else if (e.KeyChar == '8') button8.PerformClick();
            else if (e.KeyChar == '9') button3.PerformClick();
            else if (e.KeyChar == '0') button0.PerformClick();
            else if (e.KeyChar == '+') buttonPlus.PerformClick();        // Math
            else if (e.KeyChar == '-') buttonMinus.PerformClick();
            else if (e.KeyChar == '/') buttonDiv.PerformClick();
            else if (e.KeyChar == '*') buttonMult.PerformClick();        // Controls
            else if (e.KeyChar == '=') buttonResult.PerformClick();
            else if (e.KeyChar == ',' || e.KeyChar == '.') buttonPoint.PerformClick();
            else if (e.KeyChar == 8) buttonBS.PerformClick();
            else if (e.KeyChar == (char)Keys.Enter) buttonResult.PerformClick();
            else if (e.KeyChar == (char)Keys.Delete) buttonC.PerformClick();
        }

    }
}
