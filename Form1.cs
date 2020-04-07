using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerform = "";
        bool isOperationPerform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text=="0")||(isOperationPerform)) {
                textBox_Result.Clear();
            }
            isOperationPerform = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerform = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            lebelOperation.Text = resultValue + "" + operationPerform;
            isOperationPerform = true;
        }

        private void BtnClear_Entry_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerform) { 
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
